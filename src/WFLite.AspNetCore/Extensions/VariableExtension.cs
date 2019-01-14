/*
 * VariableExtension.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using WFLite.Interfaces;

namespace WFLite.AspNetCore.Extensions
{
    public static class VariableExtension
    {
        public static IActionResult GetActionResult(this IVariable variable)
        {
            return variable.GetValue<IActionResult>();
        }
    }
}
