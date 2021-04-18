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

        public int[] CalculateCoins(OperationInput operationInput)
        {
            Operation operation = new Operation { Target = operationInput.Target, Range = operationInput.Range, Date = DateTime.Now, Type = "Operação" };
            _operation.Add(operation);
            return CoinCalculation.Calculate(operation.Range, operation.Target);
        }

        public IQueryable<Operation> Search(SearchInput operationInput)
        {
            IList<Operation> returnLogs = new List<Operation>();
            foreach (Operation op in _operation)
                if (op.Date >= operationInput.StartDate.ToLocalTime() && op.Date <= operationInput.EndDate.ToLocalTime())
                    returnLogs.Add(op);
            _operation.Add(new Operation { Date = DateTime.Now, Type = "Consulta" });
            return returnLogs.AsQueryable();
        }

    }
}
