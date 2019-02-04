/*
 * ControllerVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WFLite.Logging.Bases;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerOutVariable<TController> : LoggingOutVariable
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerOutVariable(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override object getValue(ILogger logger)
        {
            return getValue(logger, _controller);
        }

        protected abstract object getValue(ILogger logger, TController controller);
    }

    public abstract class ControllerOutVariable<TController, TOutValue> : LoggingOutVariable<TOutValue>
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerOutVariable(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override object getValue(ILogger logger)
        {
            return getValue(logger, _controller);
        }

        protected abstract object getValue(ILogger logger, TController controller);
    }
}
