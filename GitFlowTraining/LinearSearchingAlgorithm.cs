using System;

namespace GitFlowTraining
{
    public class LinearSearchingAlgorithm : ISearchingAlgorithm
    {

        public T findElement<T>(T[] arr, T element) where T : IComparable<T>
        {
            T t = default;
            foreach (var item in arr)
            {
                if (element.Equals(item))
                { 
                    t = item;
                }
            }
            return t;
        }

    }
}
