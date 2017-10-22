using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql
{
    [Export("Sql", typeof(ILogger))]
    public class SqlLogger:ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("sql log...");
        }
    }
}
