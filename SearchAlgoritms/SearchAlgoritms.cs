using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSortAlgoritms.FindAlgoritms
{
    static class SearchAlgoritms
    {
        public static int SearchSimple(int[] array, int x) //Простой поиск
        {
            int length = array.Length;
            int i = 0;

            while(i < length && array[i] != x) ++i;
            if (i < length) return i;
            else return -1;
        }

        public static int SearchBarrier(int[] array, int x) //Поиск с барьером
        {
            int length = array.Length;
            array[length - 1] = x; //Установка барьера
            int i = 0;
            //Без проверки выхода за границу массива
            while (array[i] != x) i++;
            if (i < length - 1) return i;
            else return -1;
        }

        public static int BinarySearch(int[] array, int x)   //Поиск элемента в упорядоченном массиве(Бинарный поиск)
        {
            int m, left = 0, rigth = array.Length - 1;

            do
            {
                m = (left + rigth) / 2;
                if (x > array[m]) left = m + 1;
                else rigth = m - 1;
            }
            while ((array[m] != x) && (left <= rigth));
            if (array[m] == x) return m;
            else return -1;
        }
    }
}
