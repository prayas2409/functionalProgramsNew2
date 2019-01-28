using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Utility
    {
        public static int IsInteger(String input)
        {
            int num;
            if (Int32.TryParse(input, out num)) return Convert.ToInt32(input);
            else
            {
                while (Int32.TryParse(input, out num) == false)
                {
                    Console.WriteLine("You have not entered an integer number please try again");
                    input = Console.ReadLine();
                }
                return Convert.ToInt32(input);
            }
        }
        public static double IsDouble(String input)
        {
            double num;
            if (Double.TryParse(input, out num)) return num;
            else
            {
                while (Double.TryParse(input, out num) == false)
                {
                    Console.WriteLine("You have not entered a number please try again");
                    input = Console.ReadLine();
                }
                return num;
            }
        }
        /// <summary>
        /// Determines whether the specified input is string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// <c>true</c> if the specified input is not having a number and any spaces; otherwise, <c>false</c>.
        /// </returns>
        public static string IsString(String input)
        {
            int flag = 1;
            do
            {
                int i = 0;
                if (input.Contains(" "))
                {
                    flag = 1;
                    Console.WriteLine("You have entered space it should not be, please try again");
                    input = Console.ReadLine();
                }
                // it checks it the string has spaces
                for (i = 0; i < 10; i++)
                {
                    if (input.Contains(i.ToString()))
                    {
                        flag = 1;
                        Console.WriteLine("You have entered number in string it should not be please try again");
                        input = Console.ReadLine();
                        break;
                    }
                    else flag = 0;
                }
            } while (flag == 1);
            return input;
        }
        /// <summary>Determines whether the specified input is boolean.</summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is boolean; otherwise, <c>false</c>.</returns>

        public static bool IsBoolean(String input)
        {
            input.ToLower();
            ////this check the value of input if its true or false
            while (String.Equals(input, "true") != true && String.Equals(input, "false") != true)
            {
                input.ToLower();
                Console.WriteLine("You have not entered a boolean value please try again");
                input = Console.ReadLine();
            }
            return input.Equals("true") ? true : false;
        }
        public static void Print2DArray<Template>(Template[,] array)
        {
            int rows = 0, cols = 0;
            for (rows = 0; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write("{0} ", array[rows, cols]);

                }
                Console.WriteLine();
            }
        }
        public static double RandomDoubleGenerator()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }
        public static int RandomIntGenerator(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }

        static char[] SortChar(char[] a)
        {
            int i, j;
            char temp;
            for (i = 0; i < a.Length; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;

        }

        public static void Anagram(String string1,String string2)
        {
            int i, flag = 0;

            if (string1.Length != string2.Length)
            {
                //System.out.println("Strings are not anagrams");
                return;
            }
            char[] aS1 = new char[string1.Length];
            char[] aS2 = new char[string2.Length];

            for (i = 0; i < string1.Length; i++)
            {
                aS1[i] = string1[i];
            }
            for (i = 0; i < string2.Length; i++)
            {
                aS2[i] = string2[i];
            }
            aS1 = SortChar(aS1);
            aS2 = SortChar(aS2);
            //System.out.println(aS1);
            //System.out.println(aS2);

            for (i = 0; i < string1.Length; i++)
            {
                if (aS1[i] != aS2[i])
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0) Console.WriteLine(string1 + " and " + string2 + " are anagrams ");

            //else System.out.println("Strings are not anagrams");

        }

        public static bool CheckPrime(int num)
        {
            int j;
            bool flag = true;
            for (j = 2; j <= num / 2; j++)
            {
                if (num % j == 0)
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }

        public static int[] SwipeInt(int[] array, int index, int till)
        {
            int j;
            for (j = index; j >= 1; j--)
            {
                array[j] = array[j - 1];
            }
            return array;
        }

        public static String[] SwipeString(String[] array, int index, int till)
        {
            int j;
            for (j = index; j >= till + 1; j--)
            {
                array[j] = array[j - 1];
            }
            return array;
        }

        public static int[] InsertionSortInt(int[] array, int length)
        {
            int i, j, temp, index;

            for (j = 0; j < length; j++)
            {
                //System.out.println("In j= "+j);
                for (i = j + 1; i < length; i++)
                {
                    if (array[j] > array[i])
                    {
                        temp = array[i];
                        index = i;
                        array = SwipeInt(array, index, i);
                        array[j] = temp;
                        //	System.out.println("Array after swipe ");
                        //for(int c=0;c<length;c++)System.out.print(" "+array[c]);
                        //	System.out.println();						
                    }
                }
            }
            //System.out.println("The sorted array is");
            //for(i=0;i<length;i++) System.out.print(" "+array[i]);
            return array;
        }

        public static String[] InsertionSortString(String[] array, int length)
        {
            int i, j, index;
            String temp;

            for (j = 0; j < length-1; j++)
            {
                //System.out.println("In j= "+j);
                for (i = j + 1; i < length; i++)
                {
                    if (string.Compare(array[j],(array[i])) > 1)
                    {
                        temp = array[i];
                        index = i;
                        array = SwipeString(array, index, i);
                        array[j] = temp;
                        //System.out.println("Array after swipe ");
                        //	for(int c=0;c<length;c++)System.out.print(" "+array[c]);
                        //	System.out.println();						
                    }
                }
            }
            //	System.out.println("The sorted array is");
            //for(i=0;i<length;i++) System.out.print(" "+array[i]);
            return array;
        }

        public static int[] BubbleSortInt(int[] array, int length)
        {

            int i, j, temp;
            for (i = 0; i < length; i++)
            {
                for (j = 0; j < length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public static String[] BubbleSortString(String[] array, int length)
        {

            int i, j;
            String temp;

            for (i = 0; i < length; i++)
            {
                for (j = 0; j < length - 1; j++)
                {
                    if (string.Compare(array[j],(array[j + 1])) > 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
           
            return array;
        }

        public static void BinarySearchInt(int[] array, int num)
        {
            int i, length, low, high, mid;
            array = BubbleSortInt(array,array.Length);
            length = array.Length;

            low = 0;
            high = length - 1;


            for (i = 0; i < length / 2 + 1; i++)
            {
                mid = (low + high) / 2;
                if (num == array[mid])
                {
                    Console.WriteLine("Number found at position " + (mid + 1));
                    return;
                }
                if (num < array[mid])
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            Console.WriteLine("Number not found");

        }

        public static void BinarySearchString(String[] array, String num)
        {
            int i, length, low, high, mid;
            length = array.Length;
            low = 0;
            high = length - 1;
            for (i = 0; i < length; i++)
            {
                mid = (low + high) / 2;                
                if (string.Compare(num, array[mid])==0)
                {
                    Console.WriteLine("string found at position " + (mid + 1));
                    return;
                }
                               
                if (string.Compare(num,array[mid])<0)
                {
                    Console.Write("in num<amid and amid= {0}  ",array[mid]);
                    high = mid;
                }
                else
                {
                    Console.Write("in num>amid  and amid= {0}  ", array[mid]);
                    low = mid + 1;
                }
            }
            Console.WriteLine("String not found");
        }

        public static int IsPowerOfTwo(int num)
        {
            int power=0, temp;
            temp = num;
            while (temp > 0 && temp%2==0)
            {
                if (temp % 2 == 0 && temp / 2 == 1) return ++power;
                temp = temp / 2;
                power++;
            }
            return 0;
        }
    }
}


