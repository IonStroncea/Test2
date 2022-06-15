using System;

namespace GitFlowTraining
{
    public class LinearSearchingAlgorithm : ISearchingAlgorithm
    {
        uint iterations;
        public T findElement<T>(T[] arr, T element) where T : IComparable<T>
        {
            iterations = 0;
            T t = default;
            foreach (var item in arr)
            {
                iterations++;
                if (element.Equals(item))
                { 
                    t = item;
                    break;
                }
            }
            return t;
        }

        public uint IterationCountForLastExecution()
        {
            return iterations;
        }
    }
}
