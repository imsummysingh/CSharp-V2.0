using System;

namespace P000_BankPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************BANK***************");
            Console.WriteLine("::Login Page::");

            string userName = null;
            string password = null;

            Console.Write("Username: ");
            userName = Console.ReadLine();

            if (userName != "")
            {
                Console.Write("Password:");
                password = Console.ReadLine();
            }

            if(userName=="system" && password == "manager")
            {
                int mainMenuChoice = -1;
                do
                {                  
                    Console.WriteLine("\n :::Main Menu:::");
                    Console.WriteLine("1. Customers");
                    Console.WriteLine("2. Accounts");
                    Console.WriteLine("3. Fund Transfer");
                    Console.WriteLine("4. Fund Transfer Statements");
                    Console.WriteLine("5. Account Statement");
                    Console.WriteLine("0. Exit");

                    Console.Write("Enter Choice: ");
                    mainMenuChoice = int.Parse(Console.ReadLine());

                    switch (mainMenuChoice)
                    {
                        case 1:
                            CustomerMenu();
                            break;
                        case 2:
                            AccountMenu();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }
                } while (mainMenuChoice!=0);
                
            }
            else
            {
                Console.WriteLine("Invalid Username & Password");
            }

            Console.WriteLine("Thank You! Visit Again");
            Console.ReadKey();
        }
        static void CustomerMenu()
        {
            int customerMenuChoice = -1;
            do
            {
                Console.WriteLine("\n ::Customer Menu::");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Delete Customer");
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. View Customer");
                Console.WriteLine("5. Back to Main Menu");

                Console.Write("Enter Choice");
                customerMenuChoice = Convert.ToInt32(Console.ReadLine());
            } while (customerMenuChoice != 0);
        }

        static void AccountMenu()
        {
            int accountMenuChoice = -1;
            do
            {
                Console.WriteLine("\n ::Account Menu::");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Delete Account");
                Console.WriteLine("3. Update Account");
                Console.WriteLine("4. View Account");
                Console.WriteLine("5. Back to Main Menu");

                Console.Write("Enter Choice");
                accountMenuChoice = Convert.ToInt32(Console.ReadLine());
            } while (accountMenuChoice != 0);
        }
    }    
}
