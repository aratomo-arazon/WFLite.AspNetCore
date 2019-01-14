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
    public abstract class ControllerCondition : Condition
    {
        private readonly Controller _controller;

        public ControllerCondition(Controller controller)
        {
            _controller = controller;
        }

        protected sealed override bool check()
        {
            return check(_controller);
        }

        protected abstract bool check(Controller controller);
    }
}
