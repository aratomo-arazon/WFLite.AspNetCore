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
    public abstract class ControllerConverter<TController> : WFLite.Bases.Converter
        where TController : ControllerBase
    {
        private readonly TController _controller;

        public ControllerConverter(TController controller)
        {
            _controller = controller;
        }

        protected sealed override object convert(object value)
        {
            return convert(_controller, value);
        }

        protected abstract object convert(TController controller, object value);
    }

    public abstract class ControllerConverter : ControllerConverter<ControllerBase>
    {
        public ControllerConverter(ControllerBase controller)
            : base(controller)
        {
        }
    }
}
