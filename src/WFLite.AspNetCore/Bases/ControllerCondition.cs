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
using WFLite.Bases;
using WFLite.Logging.Bases;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerCondition<TController> : Condition
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerCondition(TController controller)
        {
            _controller = controller;
        }

        protected sealed override bool check()
        {
            return check(_controller);
        }

        protected abstract bool check(TController controller);
    }

    public abstract class ControllerCondition<TCategoryName, TController> : LoggingCondition<TCategoryName>
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerCondition(ILogger<TCategoryName> logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override bool check(ILogger<TCategoryName> logger)
        {
            return check(logger, _controller);
        }

        protected abstract bool check(ILogger<TCategoryName> logger, TController controller);
    }
}
