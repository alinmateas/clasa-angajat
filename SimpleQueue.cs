using System;

namespace Clasa_Angajat
{
    public class SimpleQueue<T>
    {
        T[] data;
        int count;

        public SimpleQueue()
        {
            data = new T[10];
            int count = 0;
        }

        public SimpleQueue(int length)
        {
            data = new T[length];
            count = 0;
        }

        public int Count { get => count;}

        public void Add(T elem)
        {
            if (count == data.Length)
            {
                Array.Resize(ref data, data.Length * 2);
                data[count] = elem;
                count++;
            }
            else
            {
                data[count] = elem;
                count++;
            }
        } 
        
        public void Remove(int index)
        {
            if (index > count) throw new IndexOutOfRangeException();
            data[index] = default;
        }

        public void Sort<T>() where T:IAngajat
        {
            Array.Sort(data);
        }
    }
}