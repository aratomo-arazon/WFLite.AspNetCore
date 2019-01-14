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
    public abstract class ControllerAsyncActivity : AsyncActivity
    {
        private readonly Controller _controller;

        public ControllerAsyncActivity(Controller controller)
        {
            _controller = controller;
        }

        protected sealed override Task<bool> run(CancellationToken cancellationToken)
        {
            return run(_controller, cancellationToken);
        }

        protected abstract Task<bool> run(Controller controller, CancellationToken cancellationToken);
    }
}
