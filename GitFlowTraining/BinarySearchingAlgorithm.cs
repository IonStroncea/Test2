using System;

namespace GitFlowTraining
{
    public class BinarySearchingAlgorithm : ISearchingAlgorithm
    {

        /**
         * arr must be sorted ASC
         * */
        private uint iterations;
        public T findElement<T>(T[] arr, T element) where T : IComparable<T>
        {
            iterations = 0;
            return BinarySearch(arr, 0, arr.Length - 1, element);             
        }

        public uint IterationCountForLastExecution()
        {
            return iterations;
        }

        private T BinarySearch<T>(T[] arr, int l, int r, T e) where T : IComparable<T>
        {
            //https://www.geeksforgeeks.org/binary-search-in-java/
            iterations++;
            if (r >= l)
            {
                int middle = (r + l) / 2;

                if (arr[middle].Equals(e))
                    return arr[middle];

                T result;

                if (arr[middle].GetHashCode() > e.GetHashCode())
                {
                    return BinarySearch(arr, l, middle - 1, e);
                }
                else 
                {
                    return BinarySearch(arr, middle +1, r, e);
                }
                
            }
            return default;

        }
    }
}
