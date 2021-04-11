using AspnetCore_GraphQL.Models;
using AspnetCore_GraphQL.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.IService
{
    public interface INumbersService
    {
        IQueryable<Numbers> GetAll();
        int[] Create(CreateNumbersInput numbersInput);
    }
}
