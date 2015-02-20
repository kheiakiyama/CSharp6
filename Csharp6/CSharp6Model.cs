using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp6
{
    public class CSharp6Model
    {
        public string Name { get; set; } = "DefaultName";
        public string GetOnlyName { get; } = "DefaultName";

        public void Dump() => Console.WriteLine(Name);

        public int NameLength() {
            return Name?.Length ?? 0;
        }
    }
}
