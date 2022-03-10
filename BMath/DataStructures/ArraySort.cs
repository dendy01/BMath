using System;

namespace DataStructures
{
    public class ArraySort
    {
        double[] _array;

        public ArraySort(params double[] array) 
        {
            _array = array;
        }

        public void SortArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[i] < _array[j])
                    {
                        double tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }

        public ArraySort GetPositiveNumbers()
        {
            int indexMin = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if(_array[i] < 0)
                {
                    indexMin = i;
                    break;
                }
            }

            double[] array = new double[indexMin];

            for (int i = 0; i < indexMin; i++)
            {
                array[i] = _array[i];
            }

            return new ArraySort(array);
        }

        public void PrintInfo()
        {
            for(int i = 0; i < _array.Length; i++)
            {
                Console.Write("\t" + _array[i]);
            }
        }

    }
}
