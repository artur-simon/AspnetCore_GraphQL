using AspnetCore_GraphQL.IService;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Models
{
    public class NumbersType : ObjectType<Numbers>
    {
        protected override void Configure(IObjectTypeDescriptor<Numbers> descriptor)
        {
            descriptor.Field(x => x.Target).Type<IntType>();
            descriptor.Field(x => x.Range).Type<ListType<IntType>>();
        }
    }

    public class NumbersResolver
    {
        private readonly INumbersService _numberService;
        public NumbersResolver([Service] INumbersService numberService)
        {
            _numberService = numberService;
        }

        public IEnumerable<Numbers> GetNumbers()
        {
            return null;
        }
    }
}
