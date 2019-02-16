﻿using Microsoft.AspNetCore.Http;

namespace JobHunter.Presentation.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
        }
    }
}