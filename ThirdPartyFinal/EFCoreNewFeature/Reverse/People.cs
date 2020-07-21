using System;
using System.Collections.Generic;

namespace Reverse
{
    public partial class People
    {
        public People()
        {
            Addresses = new HashSet<Addresses>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}
