using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Oracle
{
    [Export("Oracle", typeof(ILogger))]
    public class OracleLogger:ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("oracle log...");
        }
    }
}
