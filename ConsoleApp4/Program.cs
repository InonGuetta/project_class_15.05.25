using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 00 
            bool validate_array(List<int> array)
            {
                bool check = false;
                int counter = 0;
                foreach(var item in array)
                {
                    if (item >= 0)
                    {
                    counter += 1;
                    }
                }
                if (counter >= 3)
                {
                    check = true;
                    return check;
                }
                return check;
            }

            // 01
            List<int> create_val_int()
            {
                List<int> numbers = new List<int>();
                Console.WriteLine("what the length of the array: ");
                int lenth = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < lenth; i++)
                {
                    Console.WriteLine("please enter here you number to array on index: "+ i);
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }
                return numbers;

            };


            // 02
            void show_array(List<int> numbers)
            {

                foreach (var item in numbers)
                {
                    Console.WriteLine(item + " ");
                }
                
            }
            ;

            // 03 
            void show_reverse_array(List<int> numbers)
            {

                for (int i = numbers.Count-1; i >= 0;i--)
                {
                    Console.WriteLine(numbers[i] + " ");
                }
            }
            

            List<int> sorted_array(List<int> numbers)
            {

                List<int> numbers_sort = new List<int>();

                for (int i = 0; i < numbers.Count-1; i++)
                {
                    for (int j = 0; j < numbers.Count-1; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            int temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                        }
                    }
                }
                for (int i = 0;i<numbers.Count ;i++)
                {
                    numbers_sort.Add(numbers[i]);
                }
                return numbers_sort;
            }

            // 04 
            void show_sorted_list(List<int> numbers)
            {
                List<int> numbers_sort = sorted_array(numbers);
                foreach (var item in numbers_sort)
                {
                    Console.WriteLine(item);
                }
            }

            // 05
            void show_max_num(List<int> numbers)
            {
                List<int> numberssort = sorted_array(numbers);
                Console.WriteLine(numbers[numbers.Count - 1]);

            }


            // 06
            void show_min_num(List<int> numbers)
            {
                List<int> numberssort = sorted_array(numbers);
                Console.WriteLine(numberssort[0]);

            }


            // 07
            void avarge(List<int> numbers)
            {
                // כשל שיוצר לולאה אין סופית
                //List<int> numbers = create_val_int();
                double avaragee;
                int sum = summ(numbers);
                int number_of_elemts = numbers.Count;

                avaragee = (double)sum / number_of_elemts;

                Console.WriteLine(avaragee);

            }
            //;

            // 08
            void number_of_elemt(List<int> numbers)
            {

                int number_elements = numbers.Count;
                Console.WriteLine(number_elements);
            }
            ;

            int summ(List<int> numbers)
            {
                int sum = 0;
                foreach (var item in numbers)
                {
                    sum += item;
                }

                return sum; 
            }

            // 09
            void summ_print(List<int> numbers)
            {
                int sum = summ(numbers);
                Console.WriteLine(sum);
            }




            void runMenu()
            {

                List<int> numbers = new List<int>{ 1,2,-3};
                while (!validate_array(numbers))
                {
                    numbers = create_val_int();
                }




                Console.WriteLine("please enter here you choice: ");
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("insert array TO create array.\n" +
                    "show array TO show array. \n" +
                    "show reverse TO show revers \n" +
                    "sort array TO sort the array. \n" +
                    "show max TO show max value. \n" +
                    "show min TO show min value. \n" +
                    "avarge TO show avarge of array. \n" +
                    "count element TO show the count of element. \n" +
                    "sum TO sum of array. stop TO stop program \n");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "insert array":
                        create_val_int();


                        break;
                    case "show array":
                        show_array(numbers);
                        break;
                    case "show reverse":
                        show_reverse_array(numbers);
                        break;
                    case "sort array":
                        show_sorted_list(numbers);
                        break;
                    case "show max":
                        show_max_num(numbers);
                        break;
                    case "show min":
                        show_min_num(numbers);
                        break;
                    case "avarge":
                        avarge(numbers);
                        break;
                    case "count element":
                        number_of_elemt(numbers);
                        break;
                    case "sum":
                        summ_print(numbers);
                        break;

                    case "stop":
                        stop = true;
                        break;
                }
            }
            }
            runMenu();
        }

    }
}



    

