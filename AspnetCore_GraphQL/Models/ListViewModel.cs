using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL.Language.AST;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Models
{
    public static class ListViewModel
    {
        public static async Task<string> ExecuteOperation(int[] range, int target)
        {
            string returnString;
            try
            {
                var client = new GraphQLHttpClient(new GraphQLHttpClientOptions
                {
                    EndPoint = new Uri(Constants.BackendConstants.GraphQLApiUrl)
                }, new NewtonsoftJsonSerializer());
                var requestString = "mutation ($input : CreateOperationInput!) {combination(input : $input)  { }}";
                var request = new GraphQLHttpRequest
                {
                    Query = requestString,
                    Variables = new Queries.CreateOperationInput { Target = target, Range = range },
                    //variavel nao passa pra input
                };
                var response = await client.SendMutationAsync<string>(request);
                returnString = response.ToString();
            }
            catch (Exception)
            {
                returnString = "Erro.";
            }
            return returnString;
        }
    }
}