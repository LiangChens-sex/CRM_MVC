using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_MVC.Common
{
    public static class ErrorPage
    {

        public static async Task ResponseAsync(HttpResponse response, int statusCode)
        {
            if (statusCode == 404)
            {
                await response.WriteAsync(Page404);
            }
            else if (statusCode == 500)
            {
                // await response.WriteAsync(Page404);
                await response.WriteAsync(Page500);
            }
        }
        private static string Page404 => $"<script>location.href='/404.html'</script>";

        private static string Page500 => $"<script>location.href='/500.html'</script>";
    }
}
