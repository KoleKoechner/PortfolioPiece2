using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfoiloPiece5
{
    class ATM
    {
        static void Main(string[] args)
        {
            Boolean Flag = true;
            string acctNum = "1234567", acctPIN = "1234";
            string userAcct, userPIN, userOpt, userIn;
            Console.Title = ("ATM Machine");
            while (true)
            {
                Console.WriteLine("Please enter your account number: \n");
                userAcct = Console.ReadLine();
                if (userAcct == acctNum)
                {
                    Console.WriteLine("Welcome Stranger!");
                    do
                    {
                        Console.WriteLine("Please enter your PIN");
                        userPIN = Console.ReadLine();
                    } while (userPIN != acctPIN);
                    do
                    {
                        Console.WriteLine("Would you like to:\n");
                        Console.WriteLine("1. Deposit");
                        Console.WriteLine("2. Withdraw");
                        Console.WriteLine("3. Exit");
                        userOpt = Console.ReadLine();
                        switch (userOpt)
                        {
                            case "1":
                                Console.WriteLine("How much would you like to deposit");
                                userIn = Console.ReadLine();
                                Console.WriteLine("${0} has been deposited from account {1}", userIn, acctNum);
                                break;
                            case "2":
                                Console.WriteLine("How much would you like to withdraw?");
                                userIn = Console.ReadLine();
                                Console.WriteLine("${0} has been withdrawn from account {1}", userIn, acctNum);
                                break;
                            default:
                                Console.WriteLine("Thank you for using the ATM. Toodles!");
                                Flag = false;
                                break;
                        }
                    } while (Flag);

                    break;
                }
                else
                {
                    Console.WriteLine("Wrong account number!");
                }
            }
        }
    }
}
    
