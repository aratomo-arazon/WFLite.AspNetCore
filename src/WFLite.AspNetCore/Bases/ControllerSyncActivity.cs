/*
 * ControllerSyncActivity.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WFLite.Activities;
using WFLite.Bases;
using WFLite.Enums;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerSyncActivity : SyncActivity
    {
        private readonly Controller _controller;

        public ControllerSyncActivity(Controller controller)
        {
            _controller = controller;
        }

        protected sealed override bool run()
        {
            return run(_controller);
        }

        protected abstract bool run(Controller controller);
    }
}
