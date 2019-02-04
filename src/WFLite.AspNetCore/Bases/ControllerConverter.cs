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
using WFLite.Logging.Bases;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerConverter<TController> : LoggingConverter
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerConverter(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override object convert(ILogger logger, object value)
        {
            return convert(logger, _controller, value);
        }

        protected abstract object convert(ILogger logger, TController controller, object value);
    }
}
