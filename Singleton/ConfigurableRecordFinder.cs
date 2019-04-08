using System.Collections.Generic;

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
            var result = 0;
            foreach (var name in names)
                result += database.GetPopulation(name);
            return result;
        }
    }
}