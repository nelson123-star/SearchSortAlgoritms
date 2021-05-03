using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSortAlgoritms.SortAlgoritms
{
    class SortAlgoritms
    {
        public static void SortSelection(int[] array) //Сортировка простым выбором
        {
            int length = array.Length;
            int min = 0, iMin = 0, i;
            
            for (i = 0; i < length - 1; i++)
            {
                min = array[i];
                iMin = i;
                for(int j = i + 1; j< length; j++)
                {
                    if(array[j] < min) min = array[j]; iMin = j;
                }
                if (i != iMin) array[min] = array[i]; array[i] = min;
            }
        }

        public static void SortInsertion(int [] array) //Сортировка простыми включениями
        {
            int tmp = 0;
            int length = array.Length;
            for (int i = 1; i<length; i++)
            {
                int j = i - 1;
                while (j >= 0 && tmp < array[i]) array[j + 1] = array[j--]; //сдвинуть элемент
                //поставить элемент на свое место
                array[j + 1] = tmp;
            }
        }

        public static void SortBinaryInsert(int[]array) //метод сортировки с бинарными включениями
        {
            int length = array.Length;
            for (int i =1; i<=length; i++)
            {
                int tmp = array[i], left = 1, rigth = i - 1;
                while (left<=rigth)
                {
                    int m = (left + rigth) / 2;
                    if (tmp < array[m]) rigth = m - 1; //сдвиг правой или
                    else left = m + 1; //левой границы 
                }
                for (int j = i - 1; j >= left; j--) array[j + 1] = array[j]; //сдвиг элементов и размещение его
                array[left] = tmp;                                           //в нужном месте
            }
        }

        public static void SortBul(int [] array) //Сортировка пузырьком
        {
            int length = array.Length;
            for(int i = 1; i < length; i++)
            {
                for(int j = length-1; j >= i; j--)
                {
                    if(array[j-1] > array[j])
                    {
                        int t = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = t;
                    }
                }
            }
        }

        public static void SortShaker(int [] array) //Шейкер-сортировка
        {
            int left = 1, rigth = array.Length - 1, last = rigth;
            do
            {
                for (int j = rigth; j >= left; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int t = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = j;
                    }
                }
                left = last;
                for (int j = left; j <= rigth; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        int t = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = t;
                        last = j;
                    }
                }
                rigth = last - 1;
            }
            while (left < rigth);
        }
    }
}
