using System;
using System.Collections.Generic;

namespace Reverse
{
    public partial class Addresses
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public int PersonId { get; set; }

        public virtual People Person { get; set; }
    }
}
