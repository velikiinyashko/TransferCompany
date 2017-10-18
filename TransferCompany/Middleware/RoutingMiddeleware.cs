using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TransferCompany
{
    public class RoutingMiddeleware
    {
        private readonly RequestDelegate _next;
        public RoutingMiddeleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();
            if(path == "/index")
            {
                await context.Response.WriteAsync("Home Page");
            }

        }
    }
}
