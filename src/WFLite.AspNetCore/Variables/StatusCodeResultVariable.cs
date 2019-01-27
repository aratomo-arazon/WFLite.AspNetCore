/*
 * StatusCodeResultVariable.cs
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
    public class StatusCodeResultVariable : Variable
    {
        public IVariable StatusCode
        {
            private get;
            set;
        }

        public StatusCodeResultVariable()
        {
        }

        public StatusCodeResultVariable(IVariable statusCode, IConverter converter = null)
            : base(converter)
        {
            StatusCode = statusCode;
        }

        protected override object getValue()
        {
            return new StatusCodeResult(Convert.ToInt32(StatusCode.GetValue()));
        }

        protected override void setValue(object value)
        {
            throw new NotSupportedException();
        }
    }
}
