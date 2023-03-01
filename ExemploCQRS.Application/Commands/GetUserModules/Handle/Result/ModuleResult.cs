using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCQRS.Application.Commands.GetUserModules.Handle.Result
{
    public class ModuleResult
    {
        public string Cod { get; }
        public string Name { get; }
        public string Url { get; }

        public ModuleResult(string cod, string name, string url)
        {
            Cod = cod;
            Name = name;
            Url = url;
        }
    }
}
