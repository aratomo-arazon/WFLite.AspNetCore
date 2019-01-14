/*
 * NotFoundResultVariable.cs
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
    public class NotFoundResultVariable : Variable
    {
        protected override object getValue()
        {
            return new NotFoundResult();
        }

        protected override void setValue(object value)
        {
            throw new NotSupportedException();
        }
    }
}
