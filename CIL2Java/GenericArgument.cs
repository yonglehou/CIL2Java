﻿using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public enum GenericArgumentOwnerType
    {
        Type,
        Method
    }

    public struct InterGenericArgument
    {
        public static readonly List<InterGenericArgument> EmptyGenericArgsList = new List<InterGenericArgument>();


        public GenericArgumentOwnerType Owner { get; set; }
        public InterType OwnerType { get; set; }
        public InterMethod OwnerMethod { get; set; }
        public int Position { get; set; }
        public InterType Type { get; set; }

        public InterGenericArgument(GenericArgumentOwnerType owner, InterType ownerType, InterMethod ownerMethod, int position, InterType type)
            : this()
        {
            this.Owner = owner;
            this.OwnerType = ownerType;
            this.OwnerMethod = ownerMethod;
            this.Position = position;
            this.Type = type;
        }
    }
}
