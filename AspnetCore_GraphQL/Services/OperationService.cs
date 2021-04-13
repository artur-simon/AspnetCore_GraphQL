using AspnetCore_GraphQL.IService;
using AspnetCore_GraphQL.Models;
using AspnetCore_GraphQL.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Services
{
    public class OperationService : IService.IOperationService
    {
        private IList<Operation> _operation;
        public OperationService() { _operation = new List<Operation>(); }

        public int[] Create(CreateOperationInput operationInput)
        {
            Operation operation = new Operation
            {
                Target = operationInput.Target,
                Range = operationInput.Range,
                Date = DateTime.Now
                Type = CallType.Operação

            };
            _operation.Add(operation);
            return NumbersCalc.Calculate(operation.Range, operation.Target);
        }

        public IQueryable<Operation> GetAll()
        {
            return _operation?.AsQueryable();
        }

    }
}
