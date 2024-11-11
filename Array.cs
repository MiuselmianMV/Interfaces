using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interfaces
{
    public class Array : IOutput, IMath, ISort
    {

        private int[] ints { get; set; }

        public Array(int[] ints)
        {
            this.ints = ints;
        }
        
        public int Get(int index)
        {
            return ints[index];  
        }
        
        public void Set(int index, int val)
        {
            ints[index] = val;
        }

        public void Add(int val, int index)
        {
            int[] temp = new int[ints.Length + 1];
            for (int i = 0; i < ints.Length+1; i++)
            {
                if (i < index)
                    temp[i] = ints[i];

                else if (i == index)
                    temp[i] = val;

                else
                    temp[i] = ints[i - 1];
            }
            ints = temp;
        }

        public void Push(int val)
        {
            int[] temp = new int[ints.Length + 1];
            for (int i = 0; i < ints.Length; i++)
            {
                temp[i] = ints[i];
            }
            temp[ints.Length] = val;
            ints = temp;
        }

        public int Delete(int index)
        {
            int[] temp = new int[ints.Length-1];
            int counter = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (i != index)
                {
                    temp[counter] = ints[i];
                    counter++;
                }

            }
            int val = ints[index];
            ints = temp;
            return val;
        }

        public void Show()
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] +" ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine(info);
            Console.WriteLine();
        }

        public int Max()
        {
            int max = ints[0];
            for (int i = 0;i < ints.Length; i++)
            {
                if (ints[i] > max) 
                    max = ints[i];
            }
            return max;
        }
        
        public int Min()
        {
            int min = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < min)
                    min = ints[i];
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            for (int i = 0; i<ints.Length; i++)
            {
                sum += ints[i];
            }
            float avg = (float)sum / ints.Length;
            return avg;
        }

        public bool Search(int valueToSearch)
        {
            for (int i = 0; i<ints.Length;i++)
            {
                if (ints[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
        public void SortAsc()
        {
            var len = ints.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        Swap(ref ints[j], ref ints[j + 1]);
                    }
                }
            }
        }
        public void SortDesc()
        {
            var len = ints.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (ints[j] < ints[j + 1])
                    {
                        Swap(ref ints[j], ref ints[j + 1]);
                    }
                }
            }
        }

        public void Swap(ref int elem1, ref int elem2)
        {
            var temp = elem1; 
            elem1 = elem2; 
            elem2 = temp;
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                this.SortAsc();
            else
                this.SortDesc();
        }
    }
}
