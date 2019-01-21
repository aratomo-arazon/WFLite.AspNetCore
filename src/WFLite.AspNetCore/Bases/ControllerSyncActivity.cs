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
using WFLite.Activities;
using WFLite.Logging.Bases;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerSyncActivity<TController> : SyncActivity
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerSyncActivity(TController controller)
        {
            _controller = controller;
        }

        protected sealed override bool run()
        {
            return run(_controller);
        }

        protected abstract bool run(TController controller);
    }

    public abstract class ControllerSyncActivity<TCategoryName, TController> : LoggingSyncActivity<TCategoryName>
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerSyncActivity(ILogger<TCategoryName> logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override bool run(ILogger<TCategoryName> logger)
        {
            return run(logger, _controller);
        }

        protected abstract bool run(ILogger<TCategoryName> logger, TController controller);
    }
}
