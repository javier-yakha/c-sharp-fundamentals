﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Basic
{
    static class SavingsAccount
    {
        public static float InterestRate(decimal balance)
        {
            if (balance < 0) return 3.213f;
            if (balance < 1000) return 0.5f;
            if (balance < 5000) return 1.621f;
            return 2.475f;
        }
        public static decimal Interest(decimal balance) => balance * (decimal)InterestRate(balance) * 0.01m;
        public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);
        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int years = 0;
            while (balance < targetBalance)
            {
                balance = AnnualBalanceUpdate(balance);
                years += 1;
            }
            return years;
        }
    }

}
