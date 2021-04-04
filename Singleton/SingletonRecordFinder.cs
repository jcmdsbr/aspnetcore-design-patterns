using System.Collections.Generic;
using System.Linq;

namespace Singleton
{
    public class SingletonRecordFinder
    {
        public static int TotalPopulation(IEnumerable<string> names)
        {
            return names.Sum(name => SingletonDatabase.Instance.GetPopulation(name));
        }
    }
}