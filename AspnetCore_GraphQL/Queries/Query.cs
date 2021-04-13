using AspnetCore_GraphQL.IService;
using AspnetCore_GraphQL.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Queries
{
    public class Query
    {
        private readonly IService.IOperationService _operationService;
        public Query(IService.IOperationService numbersService)
        {
            _operationService = numbersService;
        }
        
        public IQueryable<Operation> GetLog => _operationService.GetAll();
    }
}
