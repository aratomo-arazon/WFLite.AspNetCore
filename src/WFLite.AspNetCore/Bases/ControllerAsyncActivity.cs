/*
 * ControllerAsyncActivity.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using WFLite.Logging.Bases;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerAsyncActivity<TController> : LoggingAsyncActivity
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerAsyncActivity(TController controller)
        {
            _controller = controller;
        }

        public ControllerAsyncActivity(ILogger logger, TController controller)
            : base(logger)
        {
            _controller = controller;
        }

        protected sealed override Task<bool> run(CancellationToken cancellationToken)
        {
            return run(_controller, cancellationToken);
        }

        protected abstract Task<bool> run(TController controller, CancellationToken cancellationToken);
    }
}
