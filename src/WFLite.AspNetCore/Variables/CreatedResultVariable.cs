/*
 * CreatedResultVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using System;
using WFLite.AspNetCore.Bases;
using WFLite.Interfaces;

namespace WFLite.AspNetCore.Variables
{
    public class CreatedResultVariable : ControllerVariable
    {
        public IVariable Resource
        {
            private get;
            set;
        }

        public IVariable Value
        {
            private get;
            set;
        }

        public CreatedResultVariable(Controller controller)
            : base(controller)
        {
        }

        protected sealed override object getValue(Controller controller)
        {
            var request = controller.HttpContext.Request;
            var scheme = request.Scheme;
            var host = request.Host;
            var path = request.Path;
            var resource = Convert.ToString(Resource.GetValue());
            var value = Value.GetValue();

            return new CreatedResult($"{scheme}://{host}{path}/{resource}", value);
        }

        protected sealed override void setValue(Controller controller, object value)
        {
            throw new NotSupportedException();
        }
    }
}
