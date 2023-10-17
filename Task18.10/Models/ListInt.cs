using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18._10.Models
{
    internal class ListInt
    {
        private int[] array;
        public ListInt(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get 
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public void Add(int num)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = num;
        }
        public void AddRange(params int[] num)
        {
            int Length = array.Length;
            Array.Resize(ref array, Length + num.Length);
            Array.Copy(num, 0, array, Length, num.Length);
        } 
        public bool Contains(int num) 
        { 
            return array.Contains(num);
        }
        public int Sum()
        {
            return array.Sum();
        }
        public void Remove(int num)
        {
            if (array.Contains(num))
            {
                int[] Array1 = new int[array.Length - 1];
                int Index1 = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != num)
                    {
                        Array1[Index1] = array[i];
                        Index1++;
                    }
                }
                array = Array1;
            }
        }
        public void RemoveRange(params int[] nums)
        {
            foreach (int num in nums)
            {
                if (array.Contains(num))
                {
                    int[] Array2 = new int[array.Length - 1];
                    int Index2 = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] != num)
                        {
                            Array2[Index2] = array[i];
                            Index2++;
                        }
                    }
                    array = Array2;
                }
            }
        }
        public override string ToString()
        {
            return string.Join(", ", array);
        }
    }
}
