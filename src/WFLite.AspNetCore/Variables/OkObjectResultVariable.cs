/*
 * OkObjectResultVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.AspNetCore.Variables
{
    public class OkObjectResultVariable : OutVariable<IActionResult>
    {
        public IOutVariable Value
        {
            private get;
            set;
        }

        public OkObjectResultVariable()
        {
        }

        public OkObjectResultVariable(IOutVariable value, IConverter<IActionResult> converter = null)
            : base(converter)
        {
            Value = value;
        }

        protected override object getValue()
        {
            return new OkObjectResult(Value.GetValueAsObject());
        }
    }
}
