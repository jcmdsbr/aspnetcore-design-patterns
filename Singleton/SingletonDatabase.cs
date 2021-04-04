using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MoreLinq;
using static System.Console;

namespace Singleton
{
    public interface IDatabase
    {
        int GetPopulation(string name);
    }

    public class SingletonDatabase : IDatabase
    {
        // laziness + thread safety
        private static readonly Lazy<SingletonDatabase> instance = new(() =>
        {
            Count++;
            return new SingletonDatabase();
        });

        private readonly Dictionary<string, int> capitals;

        private SingletonDatabase()
        {
            WriteLine("Initializing database");

            capitals = File.ReadAllLines(
                    Path.Combine(
                        new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName ?? string.Empty, "capitals.txt")
                )
                .Batch(2)
                .ToDictionary(
                    list => list.ElementAt(0).Trim(),
                    list => int.Parse(list.ElementAt(1)));
        }

        public static int Count { get; private set; }

        public static IDatabase Instance => instance.Value;

        public int GetPopulation(string name)
        {
            return capitals[name];
        }
    }
}