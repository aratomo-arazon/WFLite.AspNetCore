/*
 * ModelStateValidCondition.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WFLite.AspNetCore.Bases;

namespace WFLite.AspNetCore.Conditions
{
    public class ModelStateValidCondition : ControllerCondition<ControllerBase>
    {
        public ModelStateValidCondition(ControllerBase controller)
            : base(controller)
        {
        }

        protected override bool check(ControllerBase controller)
        {
            return controller.ModelState.IsValid;
        }
    }
}
