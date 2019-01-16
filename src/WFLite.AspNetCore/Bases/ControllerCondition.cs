/*
 * ControllerCondition.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using WFLite.Bases;

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

    public abstract class ControllerCondition : ControllerCondition<ControllerBase>
    {
        public ControllerCondition(ControllerBase controller)
            : base(controller)
        {
        }
    }
}
