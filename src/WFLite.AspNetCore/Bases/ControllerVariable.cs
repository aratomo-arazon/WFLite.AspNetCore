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
using WFLite.Bases;
using WFLite.Interfaces;
using WFLite.Logging.Bases;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerVariable<TController> : Variable
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerVariable(TController controller)
        {
            _controller = controller;
        }

        public ControllerVariable(TController controller, IConverter converter = null)
            : base(converter)
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

    public abstract class ControllerVariable<TCategoryName, TController> : LoggingVariable<TCategoryName>
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerVariable(ILogger<TCategoryName> logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        public ControllerVariable(ILogger<TCategoryName> logger, TController controller, IConverter converter = null)
            : base(logger, converter)
        {
            _controller = controller;
        }

        protected sealed override object getValue(ILogger<TCategoryName> logger)
        {
            return getValue(logger, _controller);
        }

        protected sealed override void setValue(ILogger<TCategoryName> logger, object value)
        {
            setValue(logger, _controller, value);
        }

        protected abstract object getValue(ILogger<TCategoryName> logger, TController controller);

        protected abstract void setValue(ILogger<TCategoryName> logger, TController controller, object value);
    }
}
