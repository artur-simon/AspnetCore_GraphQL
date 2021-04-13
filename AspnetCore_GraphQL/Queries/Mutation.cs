using AspnetCore_GraphQL.IService;
using AspnetCore_GraphQL.Models;
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
            return _operationService.Create(input);
        }
    }
}
