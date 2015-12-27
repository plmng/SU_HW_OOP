namespace Problem3and4.GenericListandVersionAttribute
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [Version(2,3)]
    public class GenericList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private const int DefaltCapacity = 16;
        private int _capacity;
        private int _count;
        private T[] _arr;


        public GenericList(int size)
        {
            this.Capacity = size;
            this._arr = new T[size];
        }

        public GenericList()
        {
            this.Capacity = DefaltCapacity;
            this._arr = new T[DefaltCapacity];
        }

        public int Count
        {
            get
            {
                return this._count;
            }
            private set
            {
                this._count = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this._capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("the capacity has to be positive number");
                }
                this._capacity = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if ((uint)index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException("index is positive integer number less then count");
                }
                else
                {
                    return this._arr[index];
                }
            }
            set
            {
                if ((uint)index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException("index is positive integer number less then count");
                }
                else
                {
                    this._arr[index] = value;
                }
            }
        }

        public void Add(T item)
        {
            this.CheckCapacity(this.Count + 1);
            this._arr[this.Count] = item;
            this.Count++;

        }
        
        public void Remove(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            T[] tempArr = new T[this.Capacity];
            Array.Copy(this._arr, tempArr, index); 
            Array.Copy(this._arr, index+1, tempArr, index, this.Count - index-1);
            this.Count--;
            this._arr = tempArr;
        }

        public void Insert(T item, int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            this.CheckCapacity(this.Count + 1);

            T[] tempArr = new T[this.Capacity];
            Array.Copy(this._arr, tempArr, index);
            tempArr[index] = item;
            Array.Copy(this._arr, index, tempArr, index+1, this.Count - index);
            this.Count++;
            this._arr = tempArr;
        }

        public void Clear()
        {
            this._arr = new T[this.Capacity];
        }

        public int Find(T value)
        {
            for (var i = 0; i < this.Count; i++)
            {
                if ( this._arr[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

       

        public bool Contain(T value)
        {
            return this.Find(value) != -1;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this[i];
            }
        }

        public T Max()
        {
            T max = this._arr[0];
            for (int i = 0; i <this.Count ; i++)
            {
                if (max.CompareTo(this._arr[i])<0)
                {
                    max = _arr[i];
                }
            }
            return max;
        }

        public T Min()
        {
            T min = this._arr[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (min.CompareTo(this._arr[i]) > 0)
                {
                    min = _arr[i];
                }
            }
            return min;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

      

        public override string ToString()
        {
            var str = new StringBuilder();
            for (int i = 0; i < this.Count(); i++)
            {
                str.Append(string.Format("[{0}] = {1}\n", i, _arr[i]));
            }
            return str.ToString();
        }

        private void CheckCapacity(int newsize)
        {
            if (newsize > this.Capacity)
            {
                this.Capacity *= 2;
                T[] tempArr = new T[this.Capacity];
                this._arr.CopyTo(tempArr, 0);
                this._arr = tempArr;
            }
        }
    }
}
