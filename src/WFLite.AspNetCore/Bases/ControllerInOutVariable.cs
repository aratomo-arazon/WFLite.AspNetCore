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

        public ControllerInOutVariable(TController controller)
        {
            _controller = controller;
        }

        public ControllerInOutVariable(TController controller, IConverter converter = null)
            : base(converter)
        {
            _controller = controller;
        }

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

        protected sealed override object getValue()
        {
            return getValue(_controller);
        }

        protected sealed override void setValue(object value)
        {
            setValue(_controller, value);
        }

        protected abstract object getValue(TController controller);

        protected abstract void setValue(TController controller, object value);
    }

    public abstract class ControllerInOutVariable<TController, TValue> : LoggingInOutVariable<TValue>
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerInOutVariable(TController controller)
        {
            _controller = controller;
        }

        public ControllerInOutVariable(TController controller, IConverter<TValue> converter = null)
            : base(converter)
        {
            _controller = controller;
        }

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

        protected sealed override object getValue()
        {
            return getValue(_controller);
        }

        protected sealed override void setValue(object value)
        {
            setValue(_controller, value);
        }

        protected abstract object getValue(TController controller);

        protected abstract void setValue(TController controller, object value);
    }

    public abstract class ControllerInOutVariable<TController, TInValue, TOutValue> : LoggingInOutVariable<TInValue, TOutValue>
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerInOutVariable(TController controller)
        {
            _controller = controller;
        }

        public ControllerInOutVariable(TController controller, IConverter<TInValue, TOutValue> converter = null)
            : base(converter)
        {
            _controller = controller;
        }

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

        protected sealed override object getValue()
        {
            return getValue(_controller);
        }

        protected sealed override void setValue(object value)
        {
            setValue(_controller, value);
        }

        protected abstract object getValue(TController controller);

        protected abstract void setValue(TController controller, object value);
    }
}
