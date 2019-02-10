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

        public ControllerSyncActivity(TController controller)
        {
            _controller = controller;
        }

        public ControllerSyncActivity(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override bool run()
        {
            return run(_controller);
        }

        protected abstract bool run(TController controller);
    }
}
