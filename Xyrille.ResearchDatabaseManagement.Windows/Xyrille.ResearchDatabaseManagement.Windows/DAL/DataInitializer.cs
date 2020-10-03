using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xyrille.ResearchDatabaseManagement.Windows.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<RDBManagementDBContext>
    {
        protected override void Seed(RDBManagementDBContext context)
        {
            context.Authors.Add(new Models.Author()
            { AuthorID = Guid.Parse("713d6cc4-44d9-4981-94c0-f0be9adef8a0"),
             FirstName = "Xyrille",
             LastName = "Mamalateo",
             URL = "123456789.com"}
                );
        }
    }
}
