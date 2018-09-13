using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 9;
            int[] arrayPosBuf = new int[size];
            int[] arrayTypeBuf = new int[size];
            bool isTrue = false;
            for(int i = 0; i < size; i++)
            {
                while (!isTrue)
                {
                    Console.WriteLine("введите номер ячейки: ");
                    isTrue = IsNumber(Console.ReadLine(), ref arrayPosBuf[i]);
                }
                isTrue = false;
                if (arrayPosBuf[i] < 0) break;
                while (!isTrue)
                {
                    Console.WriteLine("введите номер предмета: ");
                    isTrue = IsNumber(Console.ReadLine(),ref arrayTypeBuf[i]);
                }
                isTrue = false;
            }
            int sum = 0;
            for(int i = 0; i < size; i++)
            {
                if (arrayPosBuf[i] < 0) break;
                sum++;
            }
            size = sum;
            int[] arrayPos = new int[size];
            int[] arrayType = new int[size];
            for(int i = 0; i < size; i++)
            {
                arrayPos[i] = arrayPosBuf[i];
                arrayType[i] = arrayTypeBuf[i];
            }

            int buf = 0;
            int buf1 = 0;
            for (int i = 0; i < size - 1; i++)
            {
                for(int j = size - 1; j > i; j--)
                {
                    if (arrayPos[j] < arrayPos[j - 1])
                    {
                        buf = arrayPos[j];
                        arrayPos[j] = arrayPos[j - 1];
                        arrayPos[j - 1] = buf;

                        buf1 = arrayType[j];
                        arrayType[j] = arrayType[j - 1];
                        arrayType[j - 1] = buf1;
                    }
                }
            }

            BaseMaterial[] arrayMaterial = new BaseMaterial[size];
            for(int i = 0; i < size; i++)
            {
                switch (arrayType[i])
                {
                    case 1: arrayMaterial[i] = new Stick() {Number=arrayPos[i].ToString() };break;
                    case 2: arrayMaterial[i] = new Tree() { Number = arrayPos[i].ToString() }; break;
                    case 3: arrayMaterial[i] = new Iron() { Number = arrayPos[i].ToString() }; break;
                    case 4: arrayMaterial[i] = new Diamond() { Number = arrayPos[i].ToString() }; break;
                    case 5: arrayMaterial[i] = new Gold() { Number = arrayPos[i].ToString() }; break;
                    case 6: arrayMaterial[i] = new Stone() { Number = arrayPos[i].ToString() }; break;
                    case 7: arrayMaterial[i] = new CobbleStone() { Number = arrayPos[i].ToString() }; break;
                }
            }
            BaseMaterial[] arrayMaterialOper = new BaseMaterial[size];
            int iOper = 0;
            for (int i = 0; i < size-1; i++)
            {
                for(int j = i+1; j < size; j++)
                {
                    if(arrayMaterial[i].GetType().Name== arrayMaterial[j].GetType().Name)
                    {
                        arrayMaterialOper[iOper] = arrayMaterial[i] + arrayMaterial[j];
                        iOper++;
                        //arrayMaterial[i].Name = "d";
                        //arrayMaterial[j].Name = "d";
                    }
                }
            }
            for (int i = 0; i < iOper; i++)
            {
                Console.WriteLine("arrayMaterialOper 0= " + arrayMaterialOper[i].Name);
            }
            BaseMaterial res=null;
           //Pick pick = null;
            for(int i = 0; i < iOper-1; i++)
            {
                res = arrayMaterialOper[i] - arrayMaterialOper[i + 1];
            }
            Console.WriteLine("res.Name="+res.Name);
            switch (res.Name)
            {
                case "3дерево123,2палка": Console.WriteLine("это кирка!");break;
                case "3железо123,2палка": Console.WriteLine("это кирка!"); break;
                case "3алмаз123,2палка": Console.WriteLine("это кирка!"); break;
                case "3золото123,2палка": Console.WriteLine("это кирка!"); break;
                case "3булыжник123,2палка": Console.WriteLine("это кирка!"); break;
                default: Console.WriteLine("нету!");break;
            }
        }//void main



        public static bool IsNumber(string numberAsString, ref int number)
        {
            try
            {
                number = int.Parse(numberAsString);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
