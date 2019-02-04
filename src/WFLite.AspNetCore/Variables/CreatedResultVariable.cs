/*
 * CreatedResultVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using WFLite.AspNetCore.Bases;
using WFLite.Interfaces;

namespace WFLite.AspNetCore.Variables
{
    public class CreatedResultVariable : ControllerOutVariable<ControllerBase>
    {
        public IOutVariable<string> Resource
        {
            private get;
            set;
        }

        public IOutVariable Value
        {
            private get;
            set;
        }

        public CreatedResultVariable(ILogger logger, ControllerBase controller)
            : base(logger, controller)
        {
        }

        public CreatedResultVariable(ILogger logger, ControllerBase controller, IOutVariable<string> resource, IOutVariable value)
            : base(logger, controller)
        {
            Resource = resource;
            Value = value;
        }

        protected sealed override object getValue(ILogger logger, ControllerBase controller)
        {
            var request = controller.HttpContext.Request;
            var scheme = request.Scheme;
            var host = request.Host;
            var path = request.Path;
            var resource = Convert.ToString(Resource.GetValue());
            var value = Value.GetValueAsObject();

            return new CreatedResult($"{scheme}://{host}{path}/{resource}", value);
        }
    }
}
