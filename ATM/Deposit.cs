﻿namespace ATM
{
    public class Deposit
    {
        public static void DepositMoney(User user)
        {
            Console.WriteLine("Enter the amount to deposit:");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a valid amount to deposit:");
            }

            // Update user's balance
            user.Balance += amount;
            Console.WriteLine($"Successfully deposited ${amount}. New balance: ${user.Balance}");

            // Update balance in file
            UpdateBalance.UpdateBalanceInFile(user);
        }
    }
}
