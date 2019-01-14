/*
 * BadRequestObjectResultVariable.cs
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
    public class BadRequestObjectResultVariable : Variable
    {
        public IVariable Error
        {
            private get;
            set;
        }

        protected override object getValue()
        {
            return new BadRequestObjectResult(Error.GetValue());
        }

        protected override void setValue(object value)
        {
            throw new NotSupportedException();
        }
    }
}
