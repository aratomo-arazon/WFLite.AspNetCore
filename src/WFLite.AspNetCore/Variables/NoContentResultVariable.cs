/*
 * NoContentResultVariable.cs
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
    public class NoContentResultVariable : OutVariable<IActionResult>
    {
        public NoContentResultVariable()
        {
        }

        public NoContentResultVariable(IConverter<IActionResult> converter = null)
            : base(converter)
        {
        }

        protected override object getValue()
        {
            return new NoContentResult();
        }
    }
}
