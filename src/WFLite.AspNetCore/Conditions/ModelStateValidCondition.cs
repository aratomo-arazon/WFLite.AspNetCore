/*
 * ModelStateValidCondition.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using WFLite.AspNetCore.Bases;

namespace WFLite.AspNetCore.Conditions
{
    public class ModelStateValidCondition : ControllerCondition
    {
        public ModelStateValidCondition(Controller controller)
            : base(controller)
        {
        }

        protected override bool check(Controller controller)
        {
            return controller.ModelState.IsValid;
        }
    }
}
