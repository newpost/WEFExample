using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Compose();
            p.OracleLogger1.WriteLog();
            p.SqlLogger1.WriteLog();
        }
        [Import("Oracle", typeof(ILogger))]
        public ILogger OracleLogger1 { get;set; }

        [Import("Sql", typeof(ILogger))]
        public ILogger SqlLogger1 { set; get; }

        public void Compose()
        {
            DirectoryCatalog dc = new DirectoryCatalog("impl");
            var ct = new CompositionContainer(dc);
            ct.ComposeParts(this);
        }

    }
}
