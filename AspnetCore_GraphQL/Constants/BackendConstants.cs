using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Constants
{
    public static class BackendConstants
    {
#if DEBUG
        public static string GraphQLApiUrl { get; } = "https://localhost:44362/api";
#else
        public static string GraphQLApiUrl { get; } =  "https://audaces-backend-test.herokuapp.com/api";
#error Missing GraphQL Api Url
        public static string GraphQLApiUrl { get; } = "";
#endif
    }
}
