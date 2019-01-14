/*
 * ControllerVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using System;
using WFLite.Bases;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerVariable : Variable
    {
        private readonly Controller _controller;

        public ControllerVariable(Controller controller)
        {
            _controller = controller;
        }

        protected sealed override object getValue()
        {
            return getValue(_controller);
        }

        protected sealed override void setValue(object value)
        {
            setValue(_controller, value);
        }

        protected abstract object getValue(Controller controller);

        protected abstract void setValue(Controller controller, object value);
    }
}
