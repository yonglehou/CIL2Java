﻿using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public class AssemblyResolver : DefaultAssemblyResolver
    {
        public override AssemblyDefinition Resolve(AssemblyNameReference name)
        {
            AssemblyDefinition result = null;

            if (Program.CachedAssemblies.ContainsKey(name.Name))
                return Program.CachedAssemblies[name.Name];

            try
            {
                if (Program.ReplacedAssemblies.ContainsKey(name.Name))
                    result = base.Resolve(Program.ReplacedAssemblies[name.Name], Program.AssemblyReaderParams);
                else
                    result = base.Resolve(name, Program.AssemblyReaderParams);
            }
            catch (Exception)
            {
                if (Program.AssemblyReaderParams.ReadSymbols)
                {
                    Program.AssemblyReaderParams.ReadSymbols = false;

                    if (Program.ReplacedAssemblies.ContainsKey(name.Name))
                        result = base.Resolve(Program.ReplacedAssemblies[name.Name], Program.AssemblyReaderParams);
                    else
                        result = base.Resolve(name, Program.AssemblyReaderParams);

                    Program.AssemblyReaderParams.ReadSymbols = true;
                }
                else
                    throw;
            }

            Program.CachedAssemblies.Add(name.Name, result);

            return result;
        }
    }
}
