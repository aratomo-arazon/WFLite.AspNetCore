/*
 * BadRequestObjectResultVariable.cs
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
    public class BadRequestObjectResultVariable : OutVariable<IActionResult>
    {
        public IOutVariable Error
        {
            private get;
            set;
        }

        public BadRequestObjectResultVariable()
        {
        }

        public BadRequestObjectResultVariable(IOutVariable error, IConverter<IActionResult> converter = null)
            : base(converter)
        {
            Error = error;
        }

        protected override object getValue()
        {
            return new BadRequestObjectResult(Error.GetValueAsObject());
        }
    }
}
