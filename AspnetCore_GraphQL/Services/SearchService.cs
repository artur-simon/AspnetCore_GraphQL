using AspnetCore_GraphQL.IService;
using AspnetCore_GraphQL.Models;
using AspnetCore_GraphQL.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Services
{
    public class SearchService : IService.IOperationService
    {
        private IList<Operation> _search;
        public SearchService() { _search = new List<Operation>(); }

        public int[] Create(CreateOperationInput operationInput)
        {
            Operation operation = new Operation
            {
                Target = 0,
                Range = { },
                Date = DateTime.Now,
                Type = "Consulta"

            };
            _search.Add(operation);
            return NumbersCalc.Calculate(operation.Range, operation.Target);
        }

        public IQueryable<Operation> GetAll()
        {
            return _search?.AsQueryable();
        }

    }
}
