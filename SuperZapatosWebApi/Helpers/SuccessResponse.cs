using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperZapatosWebApi.Helpers
{
    public class SuccessResponse : ObjectResult
    {
        public SuccessResponse(object value) : base(value)
        {

        }
        public override Task ExecuteResultAsync(ActionContext context)
        {
            var obj = new ObjectResult(this.Value)
            {

            };
            return base.ExecuteResultAsync(context);
        }
    }
}
