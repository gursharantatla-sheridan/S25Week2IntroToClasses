using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S25Week2IntroToClasses
{
    public class Account
    {
		private double _balance;

		public double Balance
		{
			get { return _balance; }
			private set { _balance = value; }
		}

		public Account(double initialBalance)
		{
			Balance = initialBalance;
		}

		public void Deposit(double amount)
		{
			Balance += amount;
		}

		public void Withdraw(double amount)
		{
			if (amount > Balance)
				throw new Exception("Insufficient funds.");

			Balance -= amount;
		}
	}
}
