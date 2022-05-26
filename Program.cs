using System;

namespace Lesson4HomeWork_1_3_
{
    class Program
    {







        static void Main(string[] args)
        {





            static void Work1()
            {

                Console.WriteLine(GetFullName("Vladimir", "Alexsandrovich", "Gerasimov"));
                Console.WriteLine(GetFullName("Alex", "Mensio", ""));
                Console.WriteLine(GetFullName("Ksandr", "Drolin", ""));
            }


            static string GetFullName(string lastName, string firstName, string patronymic)
            {
                return $"{lastName} {firstName} {patronymic}";
            }


            static void Work2()
            {
                string s;
                int sum = 0;
                Console.WriteLine("Введите последовательность чисел через пробел: ");
                s = Console.ReadLine();
                var chars = s.ToCharArray();
                for (int i = 0; i < s.Length; i++)
                {
                    if (chars[i] != ' ') sum += Convert.ToInt32(chars[i]) - 48;
                }
                Console.WriteLine(sum);
                Console.ReadKey();

            }








            static void Menu()
            {
                while (true)
                {
                    Console.WriteLine("\n1.Задание 1\n2.задание 2\n3.Return Menu\n4. Задание 3");
                    Console.Write("Ведите команду: ");

                    string com = Console.ReadLine();

                    switch (com)
                    {
                        case "1":
                            Work1();
                            break;

                        case "2":
                            Work2();
                            break;
                        case "3":
                            return;
                        case "4":
                            Work3();
                            break;
                        default:
                            Console.WriteLine("Не верная команда. Попробуйте еще раз.\n");
                            break;
                    }
                }
            }



            {

                Menu();

                
                

                
            
                

            }




            static void Work3()
            {

                static season OfMonth(int n)
                {
                    try
                    {
                        if (n <= 0 || n > 12)
                            throw new Exception("Ошибка: введите число от 1 до 12");
                        switch ((n % 12) / 3)
                        {
                            case 0:
                                return season.Winter;
                            case 1:
                                return season.Spring;
                            case 2:
                                return season.Summer;
                            default: return season.Autumn;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return season.NaN;
                    }
                }
                static string Season(season s)
                {
                    switch (s)
                    {
                        case season.Winter:
                            return "Зима";
                        case season.Spring:
                            return "Весна";
                        case season.Summer:
                            return "Лето";
                        case season.Autumn:
                            return "Осень";
                        default: return "";
                    }
                }
                
                
                    do
                    {
                        Console.WriteLine("Введите номер месяца: ");
                        Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
                    }
                    while (true);




                


            }
        }
   
   
    
    
    }



    enum season
    {
        NaN,
        Winter,
        Spring,
        Summer,
        Autumn





    }





}


           
            
            
            
           
            
            
            
            
            
            
            
            
                       

            
            
            
            
            
            
             
       
        
        
        
        
        
        
        
        
        
        






























