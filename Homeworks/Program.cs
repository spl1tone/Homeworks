namespace Homeworks
{

    public enum SortAlgorithmType
    {
        Selection,
        Bubble,
        Insertion
    }

    public enum OrderBy
    {
        Asc,
        Desc
    }

    internal class Program
    {
        // Homework lesson-7

        static void Main (string[] args)
        {
            int[] array = { 10, 50, 40, 70, 60, 30, 20};
            Sort(array, SortAlgorithmType.Bubble, OrderBy.Asc);
            foreach(var arr in array) {
                Console.WriteLine(arr); // 10, 20, 30, 40, 50, 60, 70
            }
        }


        public static void Sort (int[] array, SortAlgorithmType algType, OrderBy orderBy)
        {
            switch (algType) {
                case SortAlgorithmType.Selection:
                    Selection_Sort(array, orderBy);
                    break;
                case SortAlgorithmType.Bubble:
                    Bubble_Sort(array, orderBy);
                    break;
                case SortAlgorithmType.Insertion:
                    Insertion_Sort(array, orderBy);
                    break;
            }
        }

        public static void Selection_Sort (int[] array, OrderBy orderBy)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++) {
                int minIndex = i;

                for (int j = i + 1; j < n; j++) {
                    if (IsSwap(array[j], array[minIndex], orderBy)) {
                        minIndex = j;
                    }
                }

                SwapNum(array, i, minIndex);
            }
        }

        public static void Bubble_Sort (int[] array, OrderBy orderBy)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++) {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++) {
                    if (IsSwap(array[j], array[j + 1], orderBy)) {
                        SwapNum(array, j, j + 1);
                        swapped = true;
                    }
                }

                if (!swapped) break;
            }
        }

        public static void Insertion_Sort (int[] array, OrderBy orderBy)
        {
            int n = array.Length;

            for (int i = 1; i < n; i++) {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && IsSwap(array[j], key, orderBy)) {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }

        public static bool IsSwap (int a, int b, OrderBy orderBy)
        {
            return orderBy == OrderBy.Asc ? a > b : a < b;
        }

        public static void SwapNum (int[] array, int i, int j)
        {
        /*    int temp = array[i];
            array[i] = array[j];
            array[j] = temp; */
            (array[i], array[j]) = (array[j], array[i]);

        }


    }

   

}
