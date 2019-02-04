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
using WFLite.Interfaces;
using WFLite.Logging.Bases;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerInOutVariable<TController> : LoggingInOutVariable
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerInOutVariable(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        public ControllerInOutVariable(ILogger logger, TController controller, IConverter converter = null)
            : base(logger, converter)
        {
            _controller = controller;
        }

        protected sealed override object getValue(ILogger logger)
        {
            return getValue(logger, _controller);
        }

        protected sealed override void setValue(ILogger logger, object value)
        {
            setValue(logger, _controller, value);
        }

        protected abstract object getValue(ILogger logger, TController controller);

        protected abstract void setValue(ILogger logger, TController controller, object value);
    }

    public abstract class ControllerInOutVariable<TController, TValue> : LoggingInOutVariable<TValue>
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerInOutVariable(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        public ControllerInOutVariable(ILogger logger, TController controller, IConverter<TValue> converter = null)
            : base(logger, converter)
        {
            _controller = controller;
        }

        protected sealed override object getValue(ILogger logger)
        {
            return getValue(logger, _controller);
        }

        protected sealed override void setValue(ILogger logger, object value)
        {
            setValue(logger, _controller, value);
        }

        protected abstract object getValue(ILogger logger, TController controller);

        protected abstract void setValue(ILogger logger, TController controller, object value);
    }

    public abstract class ControllerInOutVariable<TController, TInValue, TOutValue> : LoggingInOutVariable<TInValue, TOutValue>
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerInOutVariable(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        public ControllerInOutVariable(ILogger logger, TController controller, IConverter<TInValue, TOutValue> converter = null)
            : base(logger, converter)
        {
            _controller = controller;
        }

        protected sealed override object getValue(ILogger logger)
        {
            return getValue(logger, _controller);
        }

        protected sealed override void setValue(ILogger logger, object value)
        {
            setValue(logger, _controller, value);
        }

        protected abstract object getValue(ILogger logger, TController controller);

        protected abstract void setValue(ILogger logger, TController controller, object value);
    }
}
