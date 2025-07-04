﻿using System;
using System.Reflection.Emit;
using Flee.ExpressionElements.Base.Literals;
using Flee.InternalTypes;


namespace Flee.ExpressionElements.Literals
{
    internal class StringLiteralElement : LiteralElement
    {
        private readonly string _myValue;
        public StringLiteralElement(string value)
        {
            _myValue = value;
        }

        public override void Emit(FleeILGenerator ilg, IServiceProvider services)
        {
            ilg.Emit(OpCodes.Ldstr, _myValue);
        }

        public override System.Type ResultType => typeof(string);
    }
}
