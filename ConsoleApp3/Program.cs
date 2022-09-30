using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Sort
{
    public class Program
    {

        static void PrintArray(int[] array)
        {
            int n = array.Count();
            for (int i = 0; i < n; i++)
                Console.Write(array[i] + " ");
        }
        public int[] Sorting(int[] a)
        {
            int size = a.Count();
            int step = (int)size / 2;
            while (step > 0)
            {
                for (int i = 0; i < (size - step); i++)
                {
                    int j = i;
                    while (j >= 0 && a[j] > a[j + step])
                    {
                        int temp = a[j];
                        a[j] = a[j + step];
                        a[j + step] = temp;
                        j--;
                    }
                }
                step = step / 2;
            }
            return a;
        }
        static int[] ShellSort(int[] a)
        {
            int size = a.Count();
            int step = (int)size / 2;
            while (step > 0)
            {
                for (int i = 0; i < (size - step); i++)
                {
                    int j = i;
                    while (j >= 0 && a[j] > a[j + step])
                    {
                        int temp = a[j];
                        a[j] = a[j + step];
                        a[j + step] = temp;
                        j--;
                    }
                }
                step = step / 2;
            }
            return a;
        }
        static int binsearch(int val, int[] array)
        {
            for (int i = 0; i < array.Count(); i++)
                if (array[i] == val) return i;
            return -1;
        }
        public string ReadNumOfElems(string elem)
        {
            return elem;
        }

        public Int16[] ReadElems(string elem)
        {
            Int16[] arr = new Int16[Convert.ToInt16(elem)];
            for (int i = 0; i<=Convert.ToInt16(elem)-1; i++)
            {
                string a = System.Console.ReadLine();
                arr[i]=Convert.ToInt16(a);
            }
            return arr;
        }
        public static void Main(string[] args)
        {
            static string ReadNumOfElems()
            {
                string elem = System.Console.ReadLine();
                return elem;
            }

            static int[] ReadElems(int elem)
            {
                int[] arr = new int[Convert.ToInt16(elem)];
                for (int i = 0; i<=Convert.ToInt16(elem)-1; i++)
                {
                    string a = System.Console.ReadLine();
                    arr[i]=Convert.ToInt16(a);
                }
                return arr;
            }
            Console.Write("\nВведите количества элементов массива: ");
            string elem = ReadNumOfElems();
            int[] arr = new int[Convert.ToInt16(elem)];
            Console.Write("\nВведите элементы массива: ");
            arr=ReadElems(Convert.ToInt16(elem));
            Console.Write("Дан массив: ");
            PrintArray(arr);
            Console.Write("\nСортировка Шелла: ");
            PrintArray(ShellSort(arr));

        }
    }
}