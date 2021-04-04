﻿using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new(ba, BankAccountCommand.Action.Deposit, 100),
                new(ba, BankAccountCommand.Action.Withdraw, 1000)
            };

            WriteLine(ba);

            foreach (var c in commands)
                c.Call();

            WriteLine(ba);

            foreach (var c in Enumerable.Reverse(commands))
                c.Undo();

            WriteLine(ba);
        }
    }
}