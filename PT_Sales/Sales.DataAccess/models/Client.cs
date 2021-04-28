using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.DataAccess.models
{
    public partial class Client
    {
        public Client()
        {
            Sales = new HashSet<Sale>();
        }

        public int IdClient { get; set; }
        public string FirstNameClient { get; set; }
        public string LastNameClient { get; set; }
        public string IdentificationClient { get; set; }
        public DateTime DateBirth { get; set; }
        public string NumberPhone { get; set; }
        public string EmailAddress { get; set; }
        public DateTime LastModifiet { get; set; }
        public bool DeleteClient { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
