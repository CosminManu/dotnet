using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    public class Operation
    {
        public string LeftSide { get; set; }
        public string RightSide { get; set; }

        public OperationType OperationType { get; set; }
        public OperationType InnerOperation { get; set; }       // de vazut

        public Operation()
        {
            this.LeftSide = "";
            this.RightSide = "";
        }
    }
}
