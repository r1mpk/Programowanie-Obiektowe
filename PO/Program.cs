using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace main
{
    class main
    {
        static void Main(string[] args)
        {
            int selector = 0;
            while(selector != -1)
            {
                try
                {
                    Sup.emptyLine();
                    Sup.emptyLine();
                    Console.WriteLine("Select program to start:");
                    Console.WriteLine("1. Fahrenheit/Celcius");
                    Console.WriteLine("2. Delta");
                    Console.WriteLine("3. BMI");
                    Console.WriteLine("4. ++x*2");
                    Console.WriteLine("5. x *= y * 2");
                    Console.WriteLine("6. x = (y -= 2)");
                    Console.WriteLine("7. Console.WriteLine(\"++y\")");
                    Console.WriteLine("8. Logic Gates");
                    Console.WriteLine("9. Multisample task");
                    Console.WriteLine("10. Population density");
                    Console.WriteLine("Write any other symbol to close the program.");
                    Sup.emptyLine();
                    selector = Convert.ToInt32(Console.ReadLine());
                    Sup.emptyLine();
                    Sup.emptyLine();

                    switch (selector)
                    {
                        case 1:
                            {
                                Tasks.task1();
                                break;
                            }
                        case 2:
                            {
                                Tasks.task2();
                                break;
                            }
                        case 3:
                            {
                                Tasks.task3();
                                break;
                            }
                        case 4:
                            {
                                Tasks.task4();
                                break;
                            }
                        case 5:
                            {
                                Tasks.task5();
                                break;
                            }
                        case 6:
                            {
                                Tasks.task6();
                                break;
                            }
                        case 7:
                            {
                                Tasks.task7();
                                break;
                            }
                        case 8:
                            {
                                Tasks.task8();
                                break;
                            }
                        case 9:
                            {
                                Tasks.task9();
                                break;

                            }
                        case 10:
                            {
                                Tasks.task10();
                                break;
                            }
                        default:
                            {
                                selector = -1;
                                break;
                            }
                    }
                } catch(Exception ex)
                {
                    selector = -1;
                }
                
            }
            
        }
    }
    class Tasks
    {
        public static void task1()
        {
            Console.WriteLine("What is the numerical value of the temperature in Celcius you want to convert?");
            Sup.emptyLine();
            double task1IniValue = -270;
            while (task1IniValue == -270)
            {
                try
                {
                    task1IniValue = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Try again.");
                }
            }            
            double task1FinalValue = 32 + (9 / 5) * task1IniValue;
            Console.WriteLine("The {0} Celcius is {1} in Fahrenheit.", task1IniValue, task1FinalValue);
            return;
        }
        public static void task2()
        {
            int[] values = { int.MinValue, int.MinValue, int.MinValue };
            Console.WriteLine("What are the A, B, and C variables of the quadratic function that you want to calculate the delta of?");
            Console.WriteLine("Write them down one by one in order provided above.");
            for(int i = 0; i < values.Length; i++)
            {
                while (values[i] == int.MinValue)
                {
                    try
                    {
                        values[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Wrong value! Write this one again.");
                    }
                }
            }
            int delta = (values[1] * values[1]) - (4 * values[0] * values[2] );
            Console.WriteLine("The delta of quadratic function {0}x^2+{1}x+{2} is equal to {3}.", values[0], values[1], values[2], delta);
            return;
        }
        public static void task3()
        {
            float weight = 0;
            float height = 0;
            Console.WriteLine("Please write down your weight in kilograms and height in meters in that order.");
            Sup.emptyLine();
            while(weight == 0)
            {
                try
                {
                    weight = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Write it again.");
                }
            }                        
            Sup.emptyLine();
            while(height == 0)
            {
                try
                {
                    height = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Write it again.");
                }
            }
            Sup.emptyLine();
            float bmi = weight / (height * height);
            Console.WriteLine("Your BMI is {0}", bmi);
            return;
        }
        public static void task4()
        {
            // ans a) - first is the incrementation placed before the x variable, then multipication
            int x = 100;
            Console.WriteLine(++x * 2);
        }
        public static void task5()
        {
            //x = 12, answer d; x*=y*2 is equal to x*(y*2)
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x);
        }
        public static void task6()
        {
            //x=3; x=(y-=2) is equal to 2, then it's equal to 2 again,
            //since ++ after variable acts afterwards, same with --, which ends up at x = 3
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(x);   
        }
        public static void task7()
        {
            // the last command will display 7, as it goes y = 5, ++y = 6, y++ = 7, y-- = 6, ++y = 7;
            // x variable will be equal to 7, since -- appears after assignment
            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
        }
        public static void task8()
        { 
            //x = true since y == 1 is true, z++ == 1 (as above, increment acts after comparation, and true && true is true
            // y is equal to 1 since it has no other operations than comparation, and z is equal to 2 since it's incremented
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine("x = {0}; y = {1}; z = {2}", x, y, z);
        }
        public static void task9()
        {
            {   // x incremented so its 2, y is still 4 and z is still 2 since && skips the rest of the checks
                // if one of the statements make whole statement true or false automaticly;
                // wynik is false since x++ >1 is false due to order of operations
                int x = 1, y = 4, z = 2;
                bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
                Console.WriteLine("a)wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
            {   // & doesn't skip the rest of the statements, thus x = 2, y = 5 and z still equals to 2. wynik is the same
                int x = 1, y = 4, z = 2;
                bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
                Console.WriteLine("b)wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
            {   // same rules as above - x = 2, y = 5, z = 1; wynik is false
                int x = 1, y = 4, z = 2;
                bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
                Console.WriteLine("c)wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
            {   //x is still 1, || is OR statement, so true in first check skips the other ones, thus y = 3 and z = 4
                int x = 1, y = 3, z = 4;
                bool wynik = (x == 1 || y++ > 2 || ++z > 0);
                Console.WriteLine("d)wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
            {   // same as above, but | doesn't skip checks. x= 1, y = 4, z = 4, wynik = true.
                int x = 1, y = 3, z = 4;
                bool wynik = (x == 1 | y++ > 2 || ++z > 0);
                Console.WriteLine("e)wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
            {   //same rules as above, x=1, y=4, z=5, wynik = true
                int x = 1, y = 3, z = 4;
                bool wynik = (x == 1 | y++ > 2 | ++z > 0);
                Console.WriteLine("f)wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
        }
        public static void task10()
        {
            //integer operations will first produce the result, then transfer it to the double variable.
            //If we want the result to be a double-precision number,
            //we must cast values to double before performing operations on them
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / (double)powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
        }
    }
    class Sup
    {
        public static void emptyLine()
        {
            Console.WriteLine(" ");
        }
        public static void answerInCodeComment()
        {
            Console.WriteLine("Answer to the question is inside the code.");
        }
    }
}
