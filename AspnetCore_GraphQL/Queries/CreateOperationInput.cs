﻿using System;

namespace AspnetCore_GraphQL.Queries
{
    public class CreateOperationInput
    {
        public int Target { get; set; }
        public int[] Range { get; set; }

    }
}