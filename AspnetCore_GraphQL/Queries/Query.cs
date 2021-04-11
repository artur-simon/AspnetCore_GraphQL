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
        private readonly IService.INumbersService _numbersService;
        public Query(IService.INumbersService numbersService)
        {
            _numbersService = numbersService;
        }
        
        public IQueryable<Numbers> ListNumbersRequest => _numbersService.GetAll();
    }
}
