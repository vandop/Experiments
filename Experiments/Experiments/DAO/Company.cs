using System.Collections.Generic;

namespace Experiments.DAO
{
    class Company
    {
        public int Id { get; set; }
        public IEnumerable<Person> Employees { get; set; }
    }
}
