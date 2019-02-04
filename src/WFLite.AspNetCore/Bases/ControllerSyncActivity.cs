/*
 * ControllerSyncActivity.cs
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
    public abstract class ControllerSyncActivity<TController> : LoggingSyncActivity
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerSyncActivity(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override bool run(ILogger logger)
        {
            return run(logger, _controller);
        }

        protected abstract bool run(ILogger logger, TController controller);
    }
}
