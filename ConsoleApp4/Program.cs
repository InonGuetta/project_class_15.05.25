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

            // 
            // there is a problem here that is missing real validate 


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

            void show_array()
            {
                List<int> numbers = create_val_int();
                foreach (var item in numbers)
                {
                    Console.WriteLine(item + " ");
                }
                
            }
            ;

            // 03 
            void show_reverse_array()
            {
                List<int> numbers = create_val_int();
                for (int i = numbers.Count-1; i>0;i--)
                {
                    Console.WriteLine(numbers[i] + " ");
                }
            }
            ;

            // 04 
            List<int> sorted_array()
            {
                List<int> numbers_sort = new List<int>();
                List<int> numbers = create_val_int();
                for(int i = 0; i < numbers.Count; i++)
                {
                    for (int j = 0; i <numbers.Count ;j++)
                    {
                        if (numbers[j] > numbers[j+1])
                        {
                            int temp = numbers[j];
                            numbers[j] = numbers[j+1];
                            numbers[j+1] = temp;
                        }
                    }
                }

                return numbers_sort;


            }
            ;

            // 05
            void show_max_num()
            {
                List<int> numbers = sorted_array();
                Console.WriteLine(numbers[numbers.Count-1]);

            }
            ;

            // 06
            void show_min_num()
            {
                List<int> numbers = sorted_array();
                Console.WriteLine(numbers[0]);

            }
            ;

            // 07
            int avarge()
            {
                List<int> numbers = create_val_int();
                int avaragee;
                int sum = summ();
                int number_of_elemts = number_of_elemt();

                avaragee = sum / number_of_elemts;

                return avaragee;

            }
            ;

            // 08
            int number_of_elemt()
            {
                List<int> numbers = create_val_int();
                int number_elements = numbers.Count;
                return number_elements;
            }
            ;

            // 09
            int summ()
            {
                List<int> numbers = create_val_int();
                int sum = 0;
                foreach (var item in numbers)
                {
                    sum += item;
                }
                return sum; 
            }
            ;



            void runMenu(){ 
            }

            Console.WriteLine("please enter here you choice: ");
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("insert array TO create array. show array TO show array. show revers TO show revers" +
                    "sort array TO sort the array. show max TO show max value. show min TO show min value" +
                    "avarge TO show avarge of array. count element TO show the count of element" +
                    "sum TO sum of array. stop TO stop program");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "insert array":
                        create_val_int();
                        break;
                    case "show array":
                        show_array();
                        break;
                    case "show reverse":
                        show_reverse_array();
                        break;
                    case "sort array":
                        sorted_array();
                        break;
                    case "show max":
                        show_max_num();
                        break;
                    case "show min":
                        show_min_num();
                        break;
                    case "avarge":
                        show_array();
                        break;
                    case "count element":
                        number_of_elemt();
                        break;
                    case "sum":
                        summ();
                        break;

                    case "stop":
                        stop = true;
                        break;
                }
            }
        }

    }
}



    

