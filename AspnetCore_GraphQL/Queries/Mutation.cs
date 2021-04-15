using AspnetCore_GraphQL.IService;
using AspnetCore_GraphQL.Models;
using AspnetCore_GraphQL.Services;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Queries
{
    public class Mutation
    {
        private readonly IService.IOperationService _operationService = null;
        public Mutation(IService.IOperationService numbersService)
        {
            _operationService = numbersService;
        }

        public int[] GetCombination(CreateOperationInput input)
        {
            return _operationService.CalculateCoins(input);
        }
        public IQueryable<Operation> GetLogs(CreateSearchInput input)
        {
            return _operationService.Search(input);
        }
    }
}
