using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> PlakaSehir = new Dictionary<int, string>();

            PlakaSehir.Add(1, "Adana");
            PlakaSehir.Add(23, "Elazığ");
            PlakaSehir.Add(62, "Tunceli");
            PlakaSehir.Add(35, "İzmir");

            foreach (var PlakaOku in PlakaSehir)
            {
                Console.WriteLine(PlakaOku);
            }


        }
    }

    class MyDictionary<T>
    {
        T[] _array;
        T[] _temparray;
        public MyDictionary()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _temparray = _array;

            _array = new T[_array.Length + 1];

            for (int i = 0; i < _temparray.Length; i++)
            {
                _array[i] = _temparray[i];
            }

            _array[_array.Length - 1] = item;
        }

    }
}
