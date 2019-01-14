/*
 * OkResultVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using System;
using WFLite.Bases;

namespace WFLite.AspNetCore.Variables
{
    public class OkResultVariable : Variable
    {
        protected override object getValue()
        {
            return new OkResult();
        }

        protected override void setValue(object value)
        {
            throw new NotSupportedException();
        }
    }
}
