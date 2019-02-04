/*
 * ControllerCondition.cs
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
    public abstract class ControllerCondition<TController> : LoggingCondition
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerCondition(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override bool check(ILogger logger)
        {
            return check(logger, _controller);
        }

        protected abstract bool check(ILogger logger, TController controller);
    }
}
