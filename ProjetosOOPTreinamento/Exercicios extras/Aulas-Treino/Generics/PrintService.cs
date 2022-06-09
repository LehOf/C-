using System;
using System.Diagnostics.CodeAnalysis;

namespace Generics

{
    class PrintService<T> : IComparable<T>
    {

        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public int CompareTo(T obj)
        {
            if (!(obj is T))
            {
                throw new Exception("COMPARER ERROR");
            }
            PrintService<T> other = obj as PrintService<T>;
            return other.CompareTo(_values[_count]);
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");


        }

     
    }
}