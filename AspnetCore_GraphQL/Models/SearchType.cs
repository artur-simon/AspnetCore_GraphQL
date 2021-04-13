using AspnetCore_GraphQL.IService;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Models
{
    public class SearchType : ObjectType<Search>
    {
        protected override void Configure(IObjectTypeDescriptor<Search> descriptor)
        {
            descriptor.Field(x => x.StartDate).Type<DateTimeType>();
            descriptor.Field(x => x.EndDate).Type<DateTimeType>();
        }
    }

    public class SearchResolver
    {
        private readonly ISearchService _searchService;
        public SearchResolver([Service] IOperationService numberService)
        {
            _searchService = numberService;
        }

        public IEnumerable<Operation> GetNumbers()
        {
            return null;
        }
    }
}
