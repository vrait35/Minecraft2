using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft2
{
    public class BaseMaterial
    {
        public string Name { get; set; }
        public BaseMaterial() { Name = null; }
        public string Number { get; set; }
        public string NameOn { get; set; }

        public static BaseMaterial operator +(BaseMaterial first, BaseMaterial second)
        {
            string s1="";
            string s2 ="";            
            Console.WriteLine("first.name= "+first.Name);           
            for (int i = 0; /*first.Name[i] <= '9'*/; i++)
            {
                if (first.Name[i] > 57) { break; }
                s1 +=first.Name[i];
            }
            for (int i = 0; /*second.Name[i] <= '9'*/; i++)
            {
                if (second.Name[i] > 57) break;
                s2 +=second.Name[i];
            }

           



            // Console.WriteLine("s1="+s1);
            int i1=0;int i2=0;
            if (s1.Length > 0)
            {
                i1 = int.Parse(s1);
            }
            if (s2.Length > 0)
            {
                i2 = int.Parse(s2);
            }
            //Console.ReadLine();
            string res;

            //string bufi = (i1 + i2).ToString();
            int ii = i1 + i2;
            Console.WriteLine("i1+i2= "+ii);                     
            if (ii > 0)
            {
                res = ii.ToString() + first.NameOn;
            }
            else
            {
                res = first.NameOn;
            }
            //Console.WriteLine("Name= "+ res + first.Number + second.Number);
            return new BaseMaterial() { Name = res + first.Number + second.Number };
            
           
            
        }

        public static BaseMaterial operator-(BaseMaterial first, BaseMaterial second)
        {
            string res = first.Name + "," + second.Name;
            return new BaseMaterial() { Name = res };
        }

    }
}