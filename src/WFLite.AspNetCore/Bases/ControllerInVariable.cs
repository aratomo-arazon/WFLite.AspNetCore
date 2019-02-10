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
    public abstract class ControllerInVariable<TController> : LoggingInVariable
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerInVariable(TController controller)
        {
            _controller = controller;
        }

        public ControllerInVariable(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override void setValue(object value)
        {
            setValue(_controller, value);
        }

        protected abstract void setValue(TController controller, object value);
    }

    public abstract class ControllerInVariable<TController, TValue> : LoggingInVariable<TValue>
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerInVariable(TController controller)
        {
            _controller = controller;
        }

        public ControllerInVariable(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override void setValue(object value)
        {
            setValue(_controller, value);
        }

        protected abstract void setValue(TController controller, object value);
    }
}
