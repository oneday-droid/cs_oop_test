using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApplication
{

    public class MyList<T> : IList<T>, ICollection<T>, IEnumerable<T>, ICloneable
    {
        const int START_CAPACITY = 10; 
        int count = 0;
        T[] array; 

        public MyList()
        {
            array = new T[START_CAPACITY];
        }

        public MyList(int size)
        {
            array = new T[size];
        }

        public MyList(List<T> list)
        {
            int size = list.Capacity;
            array = new T[size];
            for (int k = 0; k < size; k++)
            {
                array[k] = list[k];
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }

        public int IndexOf(T item)
        {
            int index = -1;
            for (int k = 0; k < count; k++)
            {
                if (array[k].Equals(item))
                {
                    index = k;
                    break;
                }
            }

            return index;
        }

        public void Insert(int index, T item)
        {
            if ((index >= 0) && (index <= count))
            {
                T[] tempArray = array;
                count++;
                array = new T[count];
                for (int k = 0; k < count; k++)
                {
                    if (k < index)
                        array[k] = tempArray[k];
                    else if (k > index)
                        array[k] = tempArray[k-1];
                    else
                        array[k] = item;
                }    
            }
            else
                throw new IndexOutOfRangeException();
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < count))
            {
                T[] tempArray = array; 
                count--;               
                array = new T[count];
                for (int k = 0; k < count; k++)
                {
                    if (k < index)
                        array[k] = tempArray[k];
                    else if (k >= index)
                        array[k] = tempArray[k + 1];
                }                
            }
            else
                throw new IndexOutOfRangeException();
        }

        public void Add(T item)
        {
            T[] tempArray = array;
            count++;
            array = new T[count];
            for (int k = 0; k < count - 1; k++)
            {
                array[k] = tempArray[k];
            }

            array[count - 1] = item;
        }

        public void Clear()
        {
            array = new T[START_CAPACITY];
            count = 0;
        }

        public bool Contains(T item)
        {
            bool result = false;

            for (int k = 0; k < count - 1; k++)
            {
                if (array[k].Equals(item))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void CopyTo(T[] inputArray, int arrayIndex)
        {
            if (inputArray == null)
                throw new ArgumentNullException();

            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException();

            if ((inputArray.Length - arrayIndex) < count)
                throw new ArgumentException();

            for (int k = 0; k < count; k++)
                inputArray[arrayIndex + k] = array[k];
        }

        public bool Remove(T item)
        {
            int index = this.IndexOf(item);
            if (index != -1)
            {
                this.RemoveAt(index);
            }

            return (index != -1);
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        public object Clone()
        {
            return array.Clone();
        }

        override public string ToString()
        {
            string resultString = "";

            for (int k = 0; k < count; k++)
                resultString += array[k].ToString() + "; ";

            return resultString;
        }
    }
}
