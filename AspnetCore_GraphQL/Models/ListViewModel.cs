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
                var client = new GraphQLHttpClient(new GraphQLHttpClientOptions {
                    EndPoint = new Uri(Constants.BackendConstants.GraphQLApiUrl)
                }, new NewtonsoftJsonSerializer()); 
                var requestString = "mutation ($input:OperationInput!){combination(input:$input) { }}";
                var operationInput = new 
                { input = new { 
                    target = target,
                    range = range
                }};
                var request = new GraphQLHttpRequest
                {
                    Query = requestString,
                    Variables = operationInput
                };
                var response = await client.SendMutationAsync<Dictionary<string,int[]>>(request);
                var resultString = response.Data;

                returnString = String.Join(",", resultString["combination"]);
            }
            catch (Exception)
            {
                returnString = "Erro.";
            }
            return returnString;
        }
    }
}