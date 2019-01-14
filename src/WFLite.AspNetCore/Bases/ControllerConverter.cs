/*
 * ControllerConverter.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;

namespace WFLite.AspNetCore.Bases
{
    public abstract class ControllerConverter : WFLite.Bases.Converter
    {
        private readonly Controller _controller;

        public ControllerConverter(Controller controller)
        {
            _controller = controller;
        }

        protected sealed override object convert(object value)
        {
            return convert(_controller, value);
        }

        protected abstract object convert(Controller controller, object value);
    }
}
