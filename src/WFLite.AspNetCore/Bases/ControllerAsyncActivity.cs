/*
 * ControllerAsyncActivity.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using WFLite.Activities;
using WFLite.Enums;
using WFLite.Extensions;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerAsyncActivity<TController> : AsyncActivity
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerAsyncActivity(TController controller)
        {
            _controller = controller;
        }

        protected sealed override Task<bool> run(CancellationToken cancellationToken)
        {
            return run(_controller, cancellationToken);
        }

        protected abstract Task<bool> run(TController controller, CancellationToken cancellationToken);
    }

    public abstract class ControllerAsyncActivity : ControllerAsyncActivity<ControllerBase>
    {
        public ControllerAsyncActivity(ControllerBase controller)
            : base(controller)
        {
        }
    }
}
