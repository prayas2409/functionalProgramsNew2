using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 1;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter question number of program to execute it and Enter 0 to close");
                int number = Utility.IsInteger(Console.ReadLine());
                Console.WriteLine("num : {0}", number);
                switch (number)
                {
                    case 0:
                        return;
                    case 1:
                        Utility.Anagram("hum","muh");
                        break;
                    case 2:
                        PrimeNumbers pn = new PrimeNumbers();
                        pn.PrimeNumbersDemo();
                        break;
                    case 3:
                        AnagramPalindromeInt api = new AnagramPalindromeInt();
                        api.AnagramPalindromeIntDemo();
                        break;
                    case 4:
                        StopwatchForAlgos sa = new StopwatchForAlgos();
                        sa.ElapsedTimeForAlgos();
                        break;
                    case 5:
                        GuessGame gg = new GuessGame();
                        gg.GuessGameDemo(8);
                        break;
                    case 6:
                        BinarySearchFile bsf = new BinarySearchFile();
                        bsf.BinarySearchFileDemo();
                        break;
                    case 7:
                        InsertionSortLine isl = new InsertionSortLine();
                        isl.InsertionSortLineDemo();
                        break;
                    default:
                        Console.WriteLine("Not yet created");
                        Console.ReadLine();
                        flag = 0;
                        break;
                }
            } while (flag == 1);

        }

    }
}