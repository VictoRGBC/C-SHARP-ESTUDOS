﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class BusinessAcount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAcount()
        {
        }

        public BusinessAcount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
    }
}
