namespace Algorithms.API.Utils
{
    public static class AlgorithmsCalculator
    {
        public static void BubbleSortAlgorithm(List<int> Values)
        {

            for (int write = 0; write < Values.Count; write++)
            {
                for (int sort = 0; sort < Values.Count - 1; sort++)
                {
                    if (Values[sort] > Values[sort + 1])
                    {
                        int temp = Values[sort + 1];
                        Values[sort + 1] = Values[sort];
                        Values[sort] = temp;
                    }
                }
            }
        }

        public static void InsertionSortAlgorithm(List<int> Values)
        {
            for (int i = 1; i < Values.Count; i++)
            {
                var key = Values[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < Values[j])
                    {
                        Values[j + 1] = Values[j];
                        j--;
                        Values[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
        }

        public static void MergeSortAlgorithm(List<int> values)
        {
            MergeSort(values, 0, values.Count - 1);
        }

        public static void MergeSort(List<int> values, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergeSort(values, left, middle);
                MergeSort(values, middle + 1, right);
                MergeArrayAlgorithm(values, left, middle, right);
            }
        }

        public static void MergeArrayAlgorithm(List<int> values, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = values[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = values[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    values[k++] = leftTempArray[i++];
                }
                else
                {
                    values[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                values[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                values[k++] = rightTempArray[j++];
            }
        }

        public static void QuickSortAlgorithm(List<int> Values)
        {
            QuickSort(Values, 0, Values.Count - 1);
        }

        public static void QuickSort(List<int> Values, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = Values[leftIndex];
            while (i <= j)
            {
                while (Values[i] < pivot)
                {
                    i++;
                }

                while (Values[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = Values[i];
                    Values[i] = Values[j];
                    Values[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSort(Values, leftIndex, j);
            if (i < rightIndex)
                QuickSort(Values, i, rightIndex);
        }
    }
}
