﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace CoreApp.Api.Filters
{
    public class SwaggerAssignOAuth2SecurityFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var authorizeAttributes = context
                .MethodInfo
                .DeclaringType
                .GetCustomAttributes(true)
                .Union(context.MethodInfo.GetCustomAttributes(true))
                .OfType<AuthorizeAttribute>();

            //if (authorizeAttributes.Any())
            //    operation.Security = new List<IDictionary<string, IEnumerable<string>>>()
            //    {
            //        new Dictionary<string, IEnumerable<string>>()
            //        {
            //            { "oauth2", Enumerable.Empty<string>() }
            //        }
            //    };
        }
    }
}
