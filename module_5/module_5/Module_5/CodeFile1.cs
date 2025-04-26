using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_5
{
    class CodeFile1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                l1:
                Console.WriteLine("---Hotel Menu---");
                Console.WriteLine("1.South Indian");
                Console.WriteLine("2.Panjabi");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            while (true)
                            {
                                Console.WriteLine("South Indian choice");
                                Console.WriteLine("Enter your choice");
                                Console.WriteLine("1. Menduvada   Rs 60");
                                Console.WriteLine("2.Idli Samdhad Rs 70");
                                Console.WriteLine("3.Continue Before Menu");
                                int ch1 = Convert.ToInt16(Console.ReadLine());
                                switch (ch1)
                                {
                                    case 1:
                                        {
                                           
                                            Console.WriteLine("Select Menduvada");
                                            Console.WriteLine("Enter Number of Plate");
                                            int mq = Convert.ToInt16(Console.ReadLine());
                                            int total = 60 * mq;
                                            Console.WriteLine("Your {0} Plate Total={1} ", mq, total);

                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Idli Samdhad");
                                            break;
                                        }
                                    case 3:
                                        {
                                            goto l1;
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("panjabi choice");

                            break;
                        }
                    case 3:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("your Wrong choice..plz Enter your Right choice ");
                            break;
                        }
                }
            }
            //Console.ReadLine();
        }
    }
}