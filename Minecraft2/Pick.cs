using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft2
{
    public class Pick:BaseInstrument
    {
        public Pick():base() {
            Name = "Кирка";
            Count = 5;
            Array = new string[Count];
            Array[0] = "3дерево123,2палка58";
            Array[1] = "3железо123,2палка58";
            Array[2] = "3алмаз123,2палка58";
            Array[3] = "3золото123,2палка58";
            Array[4] = "3булыжник123,2палка58";
        }
    }
}
