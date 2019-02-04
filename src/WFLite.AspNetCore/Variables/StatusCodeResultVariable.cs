/*
 * StatusCodeResultVariable.cs
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
    public class StatusCodeResultVariable : OutVariable<IActionResult>
    {
        public IOutVariable StatusCode
        {
            private get;
            set;
        }

        public StatusCodeResultVariable()
        {
        }

        public StatusCodeResultVariable(IOutVariable statusCode, IConverter<IActionResult> converter = null)
            : base(converter)
        {
            StatusCode = statusCode;
        }

        protected override object getValue()
        {
            return new StatusCodeResult(StatusCode.GetValue<int>());
        }
    }
}
