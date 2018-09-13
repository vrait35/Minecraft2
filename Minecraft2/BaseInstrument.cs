using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft2
{
    public abstract class BaseInstrument
    {
        public string Name { get; set; }
        public string[] Array { get; set; }
        public int Count { get; set; }
        public BaseInstrument()
        {
            Name = null;
            Array = null;
            Count = 0;
        }
    }
}
