using AspnetCore_GraphQL.IService;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Models
{
    public class OperationType : ObjectType<Operation>
    {
        protected override void Configure(IObjectTypeDescriptor<Operation> descriptor)
        {
            descriptor.Field(x => x.Target).Type<IntType>();
            descriptor.Field(x => x.Range).Type<ListType<IntType>>();
            descriptor.Field(x => x.Date).Type<DateTimeType>();
            descriptor.Field(x => x.Type).Type<EnumType>();
        }
    }

    public class NumbersResolver
    {
        private readonly IOperationService _numberService;
        public NumbersResolver([Service] IOperationService numberService)
        {
            _numberService = numberService;
        }

        public IEnumerable<Operation> GetNumbers()
        {
            return null;
        }
    }
}
