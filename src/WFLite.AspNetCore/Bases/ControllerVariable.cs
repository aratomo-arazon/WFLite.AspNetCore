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
    public abstract class ControllerVariable<TController> : Variable
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerVariable(TController controller)
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

        protected abstract object getValue(TController controller);

        protected abstract void setValue(TController controller, object value);
    }

    public abstract class ControllerVariable : ControllerVariable<ControllerBase>
    {
        public ControllerVariable(ControllerBase controller)
            : base(controller)
        {
        }
    }
}
