﻿using CIL2Java.Java;
using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        ILExpression firstCall = null;

        private byte[] GenerateMethodProlog()
        {
            codeGenerator = new JavaBytecodeWriter();

            if (thisMethod.IsConstructor)
            {
                if (firstCall != null)
                    CompileExpression(firstCall, ExpectType.Any);
                else if (!thisMethod.IsStatic)
                {
                    string typeName = namesController.TypeNameToJava(thisMethod.DeclaringType.BaseType.Fullname);
                    if ((thisMethod.DeclaringType.IsValueType) && (thisMethod.Parameters.Count > 0))
                    {
                        //call to this() to initialize all fields
                        typeName = namesController.TypeNameToJava(thisMethod.DeclaringType.Fullname);
                    }

                    MethodRef superCall = new MethodRef(typeName, ClassNames.JavaConstructorMethodName, "()V");
                    codeGenerator
                        .Add(OpCodes.aload_0)
                        .Add(OpCodes.invokespecial, superCall);
                }

                var valueTypeFields = thisMethod.DeclaringType.Fields
                    .Where(F => ((F.FieldType.IsValueType) && (F.IsStatic == thisMethod.IsStatic)));
                OpCodes putfield = thisMethod.IsStatic ? OpCodes.putstatic : OpCodes.putfield;

                foreach (InterField fld in valueTypeFields)
                {
                    Java.Constants.Class fldTypeRef = new Java.Constants.Class(
                        namesController.TypeNameToJava(fld.FieldType.Fullname));
                    MethodRef ctorRef = new MethodRef(fldTypeRef.Value, ClassNames.JavaConstructorMethodName, "()V");
                    FieldRef fldRef = new FieldRef(namesController.TypeNameToJava(fld.DeclaringType.Fullname),
                        namesController.FieldNameToJava(fld.Name), namesController.GetFieldDescriptor(fld.FieldType));

                    if (!thisMethod.IsStatic)
                        codeGenerator.Add(OpCodes.aload_0);

                    codeGenerator
                        .Add(OpCodes._new, fldTypeRef)
                        .Add(OpCodes.dup)
                        .Add(OpCodes.invokespecial, ctorRef)
                        .Add(putfield, fldRef);
                }
            }

            foreach (ValueTypeVar v in valueTypesVars)
            {
                Java.Constants.Class typeRef = new Java.Constants.Class(namesController.TypeNameToJava(v.varType.Fullname));
                Java.Constants.MethodRef ctorRef = new Java.Constants.MethodRef(typeRef.Value,
                    ClassNames.JavaConstructorMethodName, "()V");

                codeGenerator
                    .Add(Java.OpCodes._new, typeRef)
                    .Add(Java.OpCodes.dup)
                    .Add(Java.OpCodes.invokespecial, ctorRef)
                    .AddStore(JavaPrimitiveType.Ref, v.varIndex);
            }

            return codeGenerator.End(constsPool).CodeBytes;
        }
    }
}
