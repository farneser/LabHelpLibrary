using System;
using System.Linq;

namespace HelpLibrary
{
    /// <summary>
    /// Класс, который хранит в себе перегруженный метод Print для удобного
    /// вывода любых типов данных и матриц, размерностью не больше двух
    /// </summary>
    public static class OutputHelper
    {
        public static void Print(Array[][] array, params object[] prms)
        {
            throw new Exception("Размерность массива больше двух");
        }
        
        public static void Print(bool[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(char[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(double[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(decimal[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(float[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(int[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(uint[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(long[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(ulong[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(object[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(string[][] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            if (array[0] != null)
            {
                foreach (var value in array)
                    Print(value, start, end, sep);
            }
            else
                Print("Array is null");
        }

        public static void Print(bool[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(char[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(double[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(decimal[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(float[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(int[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(uint[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(long[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(ulong[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(object[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(string[] array, string start = "[", string end = "]\n", string sep = ", ")
        {
            Console.Write($"{start}{string.Join(sep, array)}{end}");
        }

        public static void Print(bool str, string start = "", string end = "\n")
        {
            Console.Write($"{start}{str.ToString()}{end}");
        }

        public static void Print(char str, string start = "", string end = "\n")
        {
            Console.Write($"{start}{str.ToString()}{end}");
        }

        public static void Print(double str, string start = "", string end = "\n")
        {
            Console.Write($"{start}{str.ToString()}{end}");
        }

        public static void Print(decimal str, string start = "", string end = "\n")
        {
            Console.Write($"{start}{str.ToString()}{end}");
        }

        public static void Print(float str, string start = "", string end = "\n")
        {
            Console.Write($"{start}{str.ToString()}{end}");
        }

        public static void Print(int str, string start = "", string end = "\n")
        {
            Console.Write($"{start}{str.ToString()}{end}");
        }

        public static void Print(uint str, string start = "", string end = "\n")
        {
            Console.Write($"{start}{str.ToString()}{end}");
        }

        public static void Print(long str, string start = "", string end = "\n")
        {
            Console.Write($"{start}{str.ToString()}{end}");
        }

        public static void Print(ulong str, string start = "", string end = "\n")
        {
            Console.Write($"{start}{str.ToString()}{end}");
        }

        public static void Print(object str, string start = "", string end = "\n")
        {
            Console.Write($"{start}{str.ToString()}{end}");
        }

        public static void Print(string str = "", string start = "", string end = "\n")
        {
            Console.Write($"{start}{str}{end}");
        }
    }


    /// <summary>
    /// Класс, который содержит в себе методы, позволяющие легко работать с массивами
    /// </summary>
    public static class ArraysHelper
    {
        private static Random _random = new Random();

        /// <summary>
        /// Данный метод позволяет создать прямоугольную матрицу
        /// размерности MxN, заполненную случайными значениями от minValue до maxValue
        /// </summary>
        /// <param name="m">Ширина матрицы</param>
        /// <param name="n">Высота матрицы</param>
        /// <param name="minValue">Минимальное значение случайного числа</param>
        /// <param name="maxValue">Максимальное значение случайного числа</param>
        /// <returns>Матрицу размерности MxN, заполненную случайными значениями</returns>
        public static int[][] CreateRandomMatrix(int m, int n, int minValue = 0, int maxValue = 100)
        {
            var matrix = new int[m][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = CreateRandomMatrix(n, minValue, maxValue);
            }
            return matrix;
        }

        /// <summary>
        /// Данный метод позволяет создать одномерную матрицу длинной
        /// length, заполненную случайными значениями от minValue до maxValue
        /// </summary>
        /// <param name="length">Длинна матрицы</param>
        /// <param name="minValue">Минимальное значение случайного числа</param>
        /// <param name="maxValue">Максимальное значение случайного числа</param>
        /// <returns>Одномерную матрицу длинной length</returns>
        public static int[] CreateRandomMatrix(int length, int minValue = 0, int maxValue = 100)
        {
            var matrix = new int[length];

            for (var j = 0; j < length; j++)
            {
                matrix[j] = _random.Next(minValue, maxValue);
                
            }
            return matrix;
        }

        public static T[] ConnectArrays<T>(params T[][] array)
        {
            var countOfElements = array.Sum(arrayLevel => arrayLevel.Count());

            var newArray = new T[countOfElements];

            countOfElements = 0;
            foreach (var arrayLevel in array)
            {
                foreach (var element in arrayLevel)
                {
                    newArray[countOfElements] = element;
                    countOfElements++;
                }
            }

            return newArray;
        }

        public static T[] Copy<T>(T[] array)
        {
            var arr = new T[array.Length];
            Array.Copy(array, arr, array.Length);
            return arr;
        }
    }

    /// <summary>
    /// Класс, которых реализует в себе несколько видов сортировки
    /// </summary>
    class Sort
    {
        /// <summary>
        /// Сортировка пузыриком
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] BubbleSort(int[] array)
        {
            return BubbleSortR(ArraysHelper.Copy(array));
        }
        
        /// <summary>
        /// Сортировка выбором
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] SelectSort(int[] array)
        {
            return SelectSortR(ArraysHelper.Copy(array));
        }

        /// <summary>
        /// Сортировка слиянием
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] MergeSort(int[] array)
        {
            return SortArray(ArraysHelper.Copy(array), 0, array.Length - 1);
        }

        /// <summary>
        /// Стандартна сортировка языка
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] CsDefaultSort(int[] array)
        {
            var newArr = ArraysHelper.Copy(array);
            Array.Sort(newArr);
            return newArr;
        }
        
        /// <summary>
        /// Проверка отсортирован ли массив
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns>Отсортирован ли массив</returns>
        public static bool IsSorted(int[] array)
        {
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static int[] BubbleSortR(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }

            return array;
        }

        private static int[] SelectSortR(int[] array)
        {
            int n = array.Length;
            int temp, smallest;

            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }

                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }

            return array;
        }

        private static void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

        private static int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }

            return array;
        }
    }

    public static class Helper
    {
        public static string Input(string str = "")
        {
            Console.Write(str);
            return Console.ReadLine();
        }

        public static int ToInt(object str)
        {
            int newN;
            try
            {
                newN = Convert.ToInt32(str);
            }
            catch
            {
                return 0;
            }

            return newN;
        }
        public static double ToDouble(object str)
        {
            double newN;
            try
            {
                newN = Convert.ToDouble(str);
            }
            catch
            {
                return 0;
            }

            return newN;
        }

        public static double Abs(double num)
        {
            return Math.Abs(num);
        }
    }
}