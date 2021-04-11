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
        private readonly IService.INumbersService _numbersService = null;
        public Mutation(IService.INumbersService numbersService)
        {
            _numbersService = numbersService;
        }

        public Numbers CreateNumbers(CreateNumbersInput numbersInput)
        {
            return _numbersService.Create(numbersInput);
        }
    }
}
