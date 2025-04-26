using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_5
{
    class CodeFile3
    {
        static void Main(string[] args)
        {
            while (true)
            {
                l1:
                l2:
                Console.WriteLine("---Hotel Menu---");
                Console.WriteLine("1.South Indian");
                Console.WriteLine("2.Panjabi");
                Console.WriteLine("3.Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choice");


                int ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            while (true)
                            {
                                l3:
                                Console.WriteLine();

                                Console.WriteLine("south Indian");
                                Console.WriteLine("Enter your choice");
                                Console.WriteLine("1. Menduvada   Rs 60");
                                Console.WriteLine("2.Idli Samdhad Rs 70");
                                Console.WriteLine("3.Continue Before Menu");
                                Console.WriteLine("Enter  your choice");
                                int ch1 = Convert.ToInt16(Console.ReadLine());
                                switch (ch1)
                                {
                                    case 1:
                                        {

                                            Console.WriteLine("Menduvada   Rs 60");
                                            Console.WriteLine("Enter Number of plate");
                                            int val = Convert.ToInt16(Console.ReadLine());
                                            int total = 60 * val;
                                            Console.WriteLine("your {0} plate,total={1} ",val,total);



                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Idli Samdhad Rs 70");
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Continue Before Menu");
                                            goto l2;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("wrong choice..Re_Enter your choice..");
                                            goto l3;
                                            break;
                                        }
                                }
                            }
                                break;
                            
                        }
                    case 2:
                        {
                            Console.WriteLine("Panjabi");
                            break;
                        }
                    case 3:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wronge Choice..Plz Re_Enter Your Choice");
                            goto l1;
                            break;
                        }
                }
            }
            //Console.ReadLine();
        }
    }
}