/*
 * NotFoundObjectResultVariable.cs
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
    public class NotFoundObjectResultVariable : OutVariable<IActionResult>
    {
        public IOutVariable Value
        {
            private get;
            set;
        }

        public NotFoundObjectResultVariable()
        {
        }

        public NotFoundObjectResultVariable(IOutVariable value, IConverter<IActionResult> converter = null)
            : base(converter)
        {
            Value = value;
        }

        protected override object getValue()
        {
            return new NotFoundObjectResult(Value.GetValueAsObject());
        }
    }
}
