﻿using System;
using System.Collections;
using Flee.ExpressionElements.Base;
using Flee.InternalTypes;

namespace Flee.ExpressionElements.MemberElements
{
    [Obsolete("Encapsulates an argument list")]
    internal class ArgumentList
    {
        private readonly System.Collections.Generic.IList<ExpressionElement> _myElements;
        public ArgumentList(ICollection elements)
        {
            ExpressionElement[] arr = new ExpressionElement[elements.Count];
            elements.CopyTo(arr, 0);
            _myElements = arr;
        }

        private string[] GetArgumentTypeNames()
        {
            System.Collections.Generic.List<string> l = new System.Collections.Generic.List<string>();

            foreach (ExpressionElement e in _myElements)
            {
                l.Add(e.ResultType.Name);
            }

            return l.ToArray();
        }

        public Type[] GetArgumentTypes()
        {
            System.Collections.Generic.List<Type> l = new System.Collections.Generic.List<Type>();

            foreach (ExpressionElement e in _myElements)
            {
                l.Add(e.ResultType);
            }

            return l.ToArray();
        }

        public override string ToString()
        {
            string[] typeNames = this.GetArgumentTypeNames();
            return Utility.FormatList(typeNames);
        }

        public ExpressionElement[] ToArray()
        {
            ExpressionElement[] arr = new ExpressionElement[_myElements.Count];
            _myElements.CopyTo(arr, 0);
            return arr;
        }

        public ExpressionElement this[int index] => _myElements[index];

        public int Count => _myElements.Count;
    }
}
