﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Assignment12._1.Filters
{
    public class SimpleActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("action is executed" + context.Controller.ToString());
        }
    }
}
