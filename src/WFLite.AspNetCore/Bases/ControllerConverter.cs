/*
 * ControllerConverter.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WFLite.Bases;
using WFLite.Logging.Bases;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerConverter<TController> : Converter
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerConverter(TController controller)
        {
            _controller = controller;
        }

        protected sealed override object convert(object value)
        {
            return convert(_controller, value);
        }

        protected abstract object convert(TController controller, object value);
    }

    public abstract class ControllerConverter<TController, TCategoryName> : LoggingConverter<TCategoryName>
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerConverter(ILogger<TCategoryName> logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override object convert(ILogger<TCategoryName> logger, object value)
        {
            return convert(logger, _controller, value);
        }

        protected abstract object convert(ILogger<TCategoryName> logger, TController controller, object value);
    }
}
