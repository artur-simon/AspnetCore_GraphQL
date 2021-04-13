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
        private readonly IService.ISearchService _searchService = null;
        public Mutation(IService.IOperationService numbersService, ISearchService searchService)
        {
            _operationService = numbersService;
            _searchService = searchService;
        }

        public int[] GetCombination(CreateOperationInput input)
        {
            return _operationService.Create(input);
        }
        public int[] GetLogs(CreateSearchInput input)
        {
            return _searchService.Search(input);
        }
    }
}
