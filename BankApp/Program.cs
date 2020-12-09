
using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac01 = new Account("efudd", 345.00M,"efudd1","Elmer Fudd");
            Account ac02 = new Account("bbunny", 1722.12M, "bbunny1", "Bugs Bunny");
            Account ac03 = new Account("tbird", 45.44M, "tbird1", "Tweety Bird");
            Bank bank = new Bank();
            bank.Add(ac01);
            bank.Add(ac02);
            bank.Add(ac03);
            string userInput = "";
            bool loopFlag = true;

            

            while (loopFlag)
            {
                Console.Clear();
                System.Console.WriteLine("Welcome to WB Bank");
                System.Console.WriteLine("(L)ogin (Q)uit");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "q")
                {
                    System.Console.WriteLine("Have a nice day, Goodbye!");
                    loopFlag = false;
                }
                else if (userInput == "l")
                {
                    System.Console.WriteLine("Please enter your username");
                    string username = Console.ReadLine();
                    System.Console.WriteLine("Please enter your password");
                    string password = Console.ReadLine();
                    
                    if (bank.Login(username, password)) {
                        bool loggedIn = true;
                        string userSelection = "";
                        decimal userMoney = 0.00M;
                        decimal accChange = 00.00M;
                        //String receipt = String.Format("Total change to your account  ${0}\n" +
                        // "Your current Account balance is ${1}", accChange, bank.activeUser.Balance);
                        String receipt = String.Format("Total change to your account  ${0}\n" +
                            "Your current " + bank, accChange);

                        while (loggedIn)
                        {
                            Console.Clear();
                            System.Console.WriteLine("Welcome. Please select from the following.");
                            System.Console.WriteLine("(W)ithdraw - (D)eposit - (B)alance - (L)ogout");
                            userSelection = Console.ReadLine().ToLower();
                            

                            if (userSelection == "l")
                            {
                                loggedIn = false;
                                System.Console.WriteLine("Session ended. Here is your Transaction history for this session\n\n" + receipt + "\n\nPress any key to return to main menu.");
                                Console.ReadKey();
                            }
                            
                            else if (userSelection == "b")
                            {
                                
                                System.Console.WriteLine(bank);
                                Console.ReadKey();
                            }

                            else if (userSelection == "d")
                            {
                                System.Console.WriteLine("Enter deposit amount");
                                userMoney = Decimal.Parse(Console.ReadLine());
                                bank.activeUser.Balance += userMoney;
                                System.Console.WriteLine("Deposited $" + userMoney + "\nPress any key to continue");
                                receipt += String.Format("\nDeposit:\t${0}", userMoney);
                                Console.ReadKey();
                            }

                            else if (userSelection == "w")
                            {
                                System.Console.WriteLine("Enter withdrawl amount");
                                userMoney = Decimal.Parse(Console.ReadLine());
                                bank.activeUser.Balance -= userMoney;
                                System.Console.WriteLine("Withdrew $" + userMoney + "\nPress any key to continue");
                                receipt += String.Format("\nWithdrawl:\t${0}", userMoney);
                                Console.ReadKey();
                            }

                            else
                            {
                                System.Console.WriteLine("Sorry, input not recognized. \nPress any key to continue.");
                            }
                        }
                    }

                    else
                    {
                        System.Console.WriteLine("Sorry, account doesn't exist or information is incorect");
                        Console.ReadKey();
                    }

                   
                }
                else
                {
                    System.Console.WriteLine("Sorry, I didn't recognize that input \n Press any key to continue.");
                    Console.ReadKey();
                }
                
            }
        }
    }
}
