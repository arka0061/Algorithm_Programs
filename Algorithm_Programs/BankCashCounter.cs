using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    public class BankCashCounter
    {
        Queue<string> list = new Queue<string>();
        public void Driver()
        {
            Console.WriteLine("Enter the number of People in Queue :");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[number];
            Console.WriteLine("Enter the maximum amount in bank :");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter names of people");
            for (int i = 0; i < number; i++)
            {
                names[i] = Console.ReadLine();
                list.Enqueue(names[i]);
            }
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j] + " Enter 'withdraw' to withdraw money and enter 'deposit' to deposit money");
                string check = Console.ReadLine().ToLower();
                switch (check)
                {
                    case "withdraw":
                        Console.WriteLine("Enter the amount you want to withdraw");
                        int amountToWithdraw = Convert.ToInt32(Console.ReadLine());
                        if (amountToWithdraw <= amount && amount > 0)
                        {
                            Console.WriteLine("Amount Withdrawn : " + amountToWithdraw);
                            amount = amount - amountToWithdraw;
                            Console.WriteLine("Bank balance : " + amount);
                            list.Dequeue(names[j]);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient fund in Bank..Please come again Later!");
                            break;
                        }
                        break;                       

                    case "deposit":
                        Console.WriteLine("Enter the amount you want to deposit");
                        int amountToDeposit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Amount Deposited :" + amountToDeposit);
                        amount = amount + amountToDeposit;
                        Console.WriteLine("Bank balance : " + amount);
                        list.Dequeue(names[j]);
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
            list.IsEmpty();
        }
    }
}


