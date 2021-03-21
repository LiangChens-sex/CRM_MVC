using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Common
{
    public class CustomErrorPagesMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public CustomErrorPagesMiddleware(
            RequestDelegate next,
            ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<CustomErrorPagesMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                //(1) 跟踪Trace = 0
                //(2) 调试Debug = 1
                //(3) 信息 Information = 2
                //(4) 警告 Warning = 3
                //(5) 错误 Error = 4
                //(6) 严重 Critical = 5

                _logger.LogError(0, ex, $"{DateTime.Now},执行{context.Request.Method}发生异常！");

                if (context.Response.HasStarted)
                {
                    _logger.LogWarning("发生警告");
                    throw;
                }
                try
                {
                    context.Response.Clear();
                    context.Response.StatusCode = 500;
                    return;
                }
                catch (Exception ex2)
                {
                    _logger.LogError(0, ex2, "An exception was thrown attempting to display the error page.");
                }
                throw;
            }
            finally
            {
                var statusCode = context.Response.StatusCode;
                if (statusCode == 404 || statusCode == 500)
                {
                    await ErrorPage.ResponseAsync(context.Response, statusCode);
                }
            }
        }
    }
}
