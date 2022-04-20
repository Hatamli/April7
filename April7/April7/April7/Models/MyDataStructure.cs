using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April7.Models
{
    public class MyDataStructure<T>
    {
        T[] array = null;

        public T[] GetArray { get { return array; } }
        public int Length { get { return array.Length; } }
        public MyDataStructure()
        {
            array = new T[1];

        }
        public void Add(T item)
        {
            array[array.Length - 1] = item;
            myInitialize(ref array, array.Length + 1);
        }
        private void myInitialize(ref T[] array, int newLength)
        {
            if (array == null)
            {
                array = new T[newLength];
            }
            else
            {
                T[] tempArr = new T[newLength];

                for (int i = 0; i < newLength; i++)
                    if (i < array.Length)
                    {
                        tempArr[i] = array[i];
                    }
                    else
                    {
                        tempArr[i] = default(T);
                    }
                array = new T[newLength];

                for (int i = 0; i < newLength; i++)
                {
                    array[i] = tempArr[i];
                }
            }
        }
    }
}
