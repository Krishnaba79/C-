using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            int sch;
            Class1 c1 = new Class1();
           while(true)
            {
                l1:
                l2:
                Console.WriteLine("---Hotel Menu---");
                Console.WriteLine("1.South Indian");
                Console.WriteLine("2.Panjabi");
                Console.WriteLine("3.Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {

                            Console.WriteLine("south indian choice");
                            l3:
                            while (true)
                            {
                               Console.WriteLine();

                                Console.WriteLine("Enter your choice");
                                Console.WriteLine("1. Menduvada   Rs 60");
                                Console.WriteLine("2.Idli Samdhad Rs 70");
                                Console.WriteLine("3.Continue Before Menu");
                                sch = Convert.ToInt32(Console.ReadLine());
                                switch (sch)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Select Menduvada");
                                            Console.WriteLine("Enter Number of Plate");
                                            int mq = Convert.ToInt16(Console.ReadLine());
                                            c1.Total_payment(mq, 60);
                                            
                                            Console.WriteLine("---Thank You----");

                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("select idli");
                                         
                                            Console.WriteLine("Enter Number of Plate");
                                            int mq = Convert.ToInt16(Console.ReadLine());
                                            c1.Total_payment(mq,70);

                                            Console.WriteLine("---Thank You----");
                                            break;
                                        }
                                    case 3:
                                        {
                                            goto l2;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Enter Wrong choice");
                                            goto l3;
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Panjabi choice");
                            break;
                        }
                    case 3:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                           
                            Console.WriteLine("Enter the right choice");
                            goto l1;
                            break;
                        }
                }
            }
          
        }
    }
}