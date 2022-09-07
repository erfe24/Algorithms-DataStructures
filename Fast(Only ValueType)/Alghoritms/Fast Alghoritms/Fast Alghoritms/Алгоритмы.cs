namespace AlgorithmsLib
{
    unsafe static class Algorithms
    {
        public static int BinarSearch<T>(T*[] array, T neededElement) where T : struct, IComparable<T>
        {
            int startOfSubarray = 0;
            int endOfSubarray = array.Length;
            int centerOfSubarray;

            while (startOfSubarray <= endOfSubarray && startOfSubarray < array.Length)
            {
                centerOfSubarray = (int)Math.Floor((double)(endOfSubarray + startOfSubarray) / 2);
                if ((*array[centerOfSubarray]).CompareTo(neededElement) == 0)
                    return centerOfSubarray;

                if ((*array[centerOfSubarray]).CompareTo(neededElement) > 0)
                    endOfSubarray = centerOfSubarray - 1;

                if ((*array[centerOfSubarray]).CompareTo(neededElement) < 0)
                    startOfSubarray = centerOfSubarray + 1;
            }
            return -1;
        }

        public static void QuickSort<T>(T[] array) where T : IComparable<T>
        {
            int startOfSubarray = 0;
            int endOfSubarray = array.Length - 1;

            if (startOfSubarray >= endOfSubarray)
            {
                return;
            }

            int supportElement = DivideSubArray(array, startOfSubarray, endOfSubarray);

            QuickSort(array, startOfSubarray, supportElement - 1);
            QuickSort(array, supportElement + 1, endOfSubarray);
        }

        public static void QuickSort<T>(T[] array, int startOfSubarray, int endOfSubarray) where T : IComparable<T>
        {

            if (startOfSubarray >= endOfSubarray)
            {
                return;
            }

            int supportElement = DivideSubArray(array, startOfSubarray, endOfSubarray);

            QuickSort(array, startOfSubarray, supportElement - 1);
            QuickSort(array, supportElement + 1, endOfSubarray);
        }

        private static int DivideSubArray<T>(T[] array, int startOfSubarray, int endOfSubarray) where T : IComparable<T>
        {
            int supportElement = startOfSubarray;
            for (int i = startOfSubarray; i < endOfSubarray; i++)
            {
                if (array[i].CompareTo(array[endOfSubarray]) <= 0)
                {
                    (array[supportElement], array[i]) = (array[i], array[supportElement]);
                    supportElement++;
                }
            }
            (array[supportElement], array[endOfSubarray]) = (array[endOfSubarray], array[supportElement]);
            return supportElement;
        }
    }
}