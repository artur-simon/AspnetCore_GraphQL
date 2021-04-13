using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_GraphQL.Models
{
    public enum CallType {Operação, Consulta}
    public class Operation
    {
        public int Target { get; set; }
        public int[] Range { get; set; }
        public DateTime Date { get; set; }
        public CallType Type { get; set; }
    }
}
