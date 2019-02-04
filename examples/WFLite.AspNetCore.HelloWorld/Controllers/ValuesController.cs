using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WFLite.Activities;
using WFLite.AspNetCore.Variables;
using WFLite.Conditions;
using WFLite.Variables;

namespace WFLite.AspNetCore.HelloWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery(Name = "condition")]bool condition = true)  // false: Not Found
        {
            var actionResult = new AnyVariable<IActionResult>();

            var activity = new IfActivity()
            {
                Condition = new TrueCondition() { Value = new AnyVariable<bool>() { Value = condition } },
                Then = new AssignActivity()
                {
                    To = actionResult,
                    Value = new OkObjectResultVariable()
                    {
                        Value = new AnyVariable() { Value = "Hello World!" }
                    }
                },
                Else = new AssignActivity()
                {
                    To = actionResult,
                    Value = new NotFoundResultVariable()
                }
            };

            await activity.Start();

            return actionResult.GetValue();
        }
    }
}
