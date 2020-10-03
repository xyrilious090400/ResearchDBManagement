using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xyrille.ResearchDatabaseManagement.Windows.Models
{
   public class User
    {
        public Guid? UserID { get; set; }

        public string Username { get; set; }

        public string UserEmail { get; set; }

        public string Address { get; set; }

        public string Password { get; set; }

    }
}

