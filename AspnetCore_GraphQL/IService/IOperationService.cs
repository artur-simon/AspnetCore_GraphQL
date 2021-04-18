using AspnetCore_GraphQL.Models;
using AspnetCore_GraphQL.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.IService
{
    public interface IOperationService
    {
        int[] CalculateCoins(OperationInput input);
        IQueryable<Operation> Search(SearchInput input);
    }
}
