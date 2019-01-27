/*
 * OkObjectResultVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using System;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.AspNetCore.Variables
{
    public class OkObjectResultVariable : Variable
    {
        public IVariable Value
        {
            private get;
            set;
        }

        public OkObjectResultVariable()
        {
        }

        public OkObjectResultVariable(IVariable value, IConverter converter = null)
            : base(converter)
        {
            Value = value;
        }

        protected override object getValue()
        {
            return new OkObjectResult(Value.GetValue());
        }

        protected override void setValue(object value)
        {
            throw new NotSupportedException();
        }
    }
}
