using System.Collections.Generic;
using System.Linq;

namespace Singleton
{
    public class ConfigurableRecordFinder
    {
        private readonly IDatabase database;

        public ConfigurableRecordFinder(IDatabase database)
        {
            this.database = database;
        }

        public int GetTotalPopulation(IEnumerable<string> names)
        {
            return names.Sum(name => database.GetPopulation(name));
        }
    }
}