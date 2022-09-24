using System;
using System.Collections;
using System.Collections.Generic;
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

        public static void DeleteElementById<T>(ref T[] array, int index)
        {
            for (var i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array = array.Take(array.Length - 1).ToArray();
        }

        public static void DeleteFirstElement<T>(ref T[] array)
        {
            DeleteElementById(ref array, 0);
        }

        public static void DeleteLastElement<T>(ref T[] array)
        {
            DeleteElementById(ref array, array.Length - 1);
        }

        public static void AddElementById<T>(ref T[] array, T element, int id)
        {
            var newArray = new T[((id >= array.Length) ? id + 1 : array.Length)];
            for (var i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[id] = element;
            array = newArray;
        }

        public static void AddFirstElement<T>(ref T[] array, T element)
        {
            AddElementById(ref array, element, 0);
        }

        public static void AddLastElement<T>(ref T[] array, T element)
        {
            AddElementById(ref array, element, array.Length - 1);
        }
    }

    class Stringhelper
    {
        public static string Reverse(string str)
        {
            var strRet = str.ToCharArray();
            Array.Reverse(strRet);
            return new String(strRet);
        }

        public static int CountOfStingsInString(string firstString, string secondString)
        {
            var count = 0;
            var len = secondString.Length;
            var upperBound = firstString.Length - len;
            
            for (var i = 0; i <= upperBound; i++)
            {
                if (secondString == firstString.Substring(i, len))
                {
                    ++count;
                }
            }

            return count;
        }
        
        public static char ConvertIntToAscii(int num)
        {
            return Convert.ToChar(num);
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
    /// <summary>
    /// Множество.
    /// </summary>
    /// <typeparam name="T"> Тип данных, хранимых во множестве. </typeparam>
    public class Set<T> : IEnumerable<T>
    {
        /// <summary>
        /// Коллекция хранимых данных.
        /// </summary>
        private List<T> _items = new List<T>();

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count => _items.Count;

        /// <summary>
        /// Добавить данные во множество.
        /// </summary>
        /// <param name="item"> Добавляемые данные. </param>
        public void Add(T item)
        {
            // Проверяем входные данные на пустоту.
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            // Множество может содержать только уникальные элементы,
            // поэтому если множество уже содержит такой элемент данных, то не добавляем его.
            if (!_items.Contains(item))
            {
                _items.Add(item);
            }
        }

        /// <summary>
        /// Удалить элемент из множества.
        /// </summary>
        /// <param name="item"> Удаляемый элемент данных. </param>
        public void Remove(T item)
        {
            // Проверяем входные данные на пустоту.
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            // Если коллекция не содержит данный элемент, то мы не можем его удалить.
            if (!_items.Contains(item))
            {
                throw new KeyNotFoundException($"Элемент {item} не найден в множестве.");
            }

            // Удаляем элемент из коллекции.
            _items.Remove(item);
        }

        /// <summary>
        /// Объединение множеств.
        /// </summary>
        /// <param name="set1"> Первое множество. </param>
        /// <param name="set2"> Второе множество. </param>
        /// <returns> Новое множество, содержащее все уникальные элементы полученных множеств. </returns>
        public static Set<T> Union(Set<T> set1, Set<T> set2)
        {
            // Проверяем входные данные на пустоту.
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            // Результирующее множество.
            var resultSet = new Set<T>();

            // Элементы данных результирующего множества.
            var items = new List<T>();

            // Если первое входное множество содержит элементы данных,
            // то добавляем их в результирующее множество.
            if (set1._items != null && set1._items.Count > 0)
            {
                // т.к. список является ссылочным типом, 
                // то необходимо не просто передавать данные, а создавать их дубликаты.
                items.AddRange(new List<T>(set1._items));
            }

            // Если второе входное множество содержит элементы данных, 
            // то добавляем из в результирующее множество.
            if (set2._items != null && set2._items.Count > 0)
            {
                // т.к. список является ссылочным типом, 
                // то необходимо не просто передавать данные, а создавать их дубликаты.
                items.AddRange(new List<T>(set2._items));
            }

            // Удаляем все дубликаты из результирующего множества элементов данных.
            resultSet._items = items.Distinct().ToList();

            // Возвращаем результирующее множество.
            return resultSet;
        }

        /// <summary>
        /// Пересечение множеств.
        /// </summary>
        /// <param name="set1"> Первое множество. </param>
        /// <param name="set2"> Второе множество. </param>
        /// <returns> Новое множество, содержащее совпадающие элементы данных из полученных множеств. </returns>
        public static Set<T> Intersection(Set<T> set1, Set<T> set2)
        {
            // Проверяем входные данные на пустоту.
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            // Результирующее множество.
            var resultSet = new Set<T>();

            // Выбираем множество содержащее наименьшее количество элементов.
            if (set1.Count < set2.Count)
            {
                // Первое множество меньше.
                // Проверяем все элементы выбранного множества.
                foreach (var item in set1._items)
                {
                    // Если элемент из первого множества содержится во втором множестве,
                    // то добавляем его в результирующее множество.
                    if (set2._items.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }
            else
            {
                // Второе множество меньше или множества равны.
                // Проверяем все элементы выбранного множества.
                foreach (var item in set2._items)
                {
                    // Если элемент из второго множества содержится в первом множестве,
                    // то добавляем его в результирующее множество.
                    if (set1._items.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }

            // Возвращаем результирующее множество.
            return resultSet;
        }

        /// <summary>
        /// Разность множеств.
        /// </summary>
        /// <param name="set1"> Первое множество. </param>
        /// <param name="set2"> Второе множество. </param>
        /// <returns> Новое множество, содержащее не совпадающие элементы данных между полученными множествами. </returns>
        public static Set<T> Difference(Set<T> set1, Set<T> set2)
        {
            // Проверяем входные данные на пустоту.
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            // Результирующее множество.
            var resultSet = new Set<T>();

            // Проходим по всем элементам первого множества.
            foreach (var item in set1._items)
            {
                // Если элемент из первого множества не содержится во втором множестве,
                // то добавляем его в результирующее множество.
                if (!set2._items.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            // Проходим по всем элементам второго множества.
            foreach (var item in set2._items)
            {
                // Если элемент из второго множества не содержится в первом множестве,
                // то добавляем его в результирующее множество.
                if (!set1._items.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            // Удаляем все дубликаты из результирующего множества элементов данных.
            resultSet._items = resultSet._items.Distinct().ToList();

            // Возвращаем результирующее множество.
            return resultSet;
        }

        /// <summary>
        /// Подмножество.
        /// </summary>
        /// <param name="set1"> Множество, проверяемое на вхождение в другое множество. </param>
        /// <param name="set2"> Множество в которое проверяется вхождение другого множества. </param>
        /// <returns> Является ли первое множество подмножеством второго. true - является, false - не является. </returns>
        public static bool Subset(Set<T> set1, Set<T> set2)
        {
            // Проверяем входные данные на пустоту.
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            // Перебираем элементы первого множества.
            // Если все элементы первого множества содержатся во втором,
            // то это подмножество. Возвращаем истину, иначе ложь.
            var result = set1._items.All(s => set2._items.Contains(s));
            return result;
        }

        /// <summary>
        /// Вернуть перечислитель, выполняющий перебор всех элементов множества.
        /// </summary>
        /// <returns> Перечислитель, который можно использовать для итерации по коллекции. </returns>
        public IEnumerator<T> GetEnumerator()
        {
            // Используем перечислитель списка элементов данных множества.
            return _items.GetEnumerator();
        }

        /// <summary>
        /// Вернуть перечислитель, который осуществляет итерационный переход по множеству.
        /// </summary>
        /// <returns> Объект IEnumerator, который используется для прохода по коллекции. </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Используем перечислитель списка элементов данных множества.
            return _items.GetEnumerator();
        }
    }
}