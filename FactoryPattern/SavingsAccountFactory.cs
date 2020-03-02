﻿using System;
using AbstractClasses;
using Interfaces;

namespace FactoryPattern
{
    // Concrete Creator
    public class SavingsAcctFactory : ICreditUnionFactory
    {
        public SavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI")) { return new CitiSavingsAcct(); }
            else
            if (acctNo.Contains("NATIONAL")) { return new NationalSavingsAcct(); }
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }
}
