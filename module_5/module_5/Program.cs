using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                l1:
                Console.WriteLine("--HOTEL MENU--");
                Console.WriteLine("1. South Indian");
                Console.WriteLine("2. Punjabi");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter Your Choice : ");

                int ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1: // first error is for break in case one break is compalsary
                        {
                            while(true)
                            {
                                Console.WriteLine("South Indian choice : ");
                                Console.WriteLine("Enter Your choice : ");
                                Console.WriteLine("1. Menduvada     Rs : 60");
                                Console.WriteLine("2. Idli Sambhad  Rs : 70");
                                Console.WriteLine("Continue Before Menu : ");
                                int ch1 = Convert.ToInt16(Console.ReadLine());
                                switch (ch1)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Select Menduvada");
                                            Console.WriteLine("Enter Number of plate");
                                            int mq = Convert.ToInt16(Console.ReadLine());
                                            int total = 60 * mq;
                                            Console.WriteLine("Your {0} plate Total = {1}",mq,total);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Selecte Idli Sambhad");
                                            Console.WriteLine("Enter Number of plate");
                                            int Is = Convert.ToInt16(Console.ReadLine());
                                            int total = 70 * Is;
                                            Console.WriteLine("Your {0} plate Total = {1}", Is, total);
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
                            while (true)
                            {
                                Console.WriteLine("Punjabi choice : ");
                                Console.WriteLine("Enter Your choice : ");
                                Console.WriteLine("1. Panir-Chilli     Rs : 100");
                                Console.WriteLine("2. Panir Butter Masala  Rs : 120");
                                Console.WriteLine("Continue Before Menu : ");
                                int ch1 = Convert.ToInt16(Console.ReadLine());
                                switch (ch1)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Select Panir-chilli");
                                            Console.WriteLine("Enter Number of plate");
                                            int pc = Convert.ToInt16(Console.ReadLine());
                                            int total = 100 * pc;
                                            Console.WriteLine("Your {0} plate Total = {1}", pc, total);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Selecte Panir Butter Masala");
                                            Console.WriteLine("Enter Number of plate");
                                            int pcm = Convert.ToInt16(Console.ReadLine());
                                            int total = 120 * pcm;
                                            Console.WriteLine("Your {0} plate Total = {1}", pcm, total);
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
                    case 3: // for exit cmd
                        {

                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter Your Choice : ");
                            break;
                        }
                }
            }
            //Console.ReadLine();
        }
    }
}
