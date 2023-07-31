using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class CustomDbInitializer : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            //IList<RollGroups> defaultStandards = new List<RollGroups>();

            //defaultStandards.Add(new RollGroups() { GroupRollName = "Admins" });
            //defaultStandards.Add(new RollGroups() { GroupRollName = "Sales" });
            //defaultStandards.Add(new RollGroups() { GroupRollName = "Pos" });
            //defaultStandards.Add(new RollGroups() { GroupRollName = "Purchase" });
            //defaultStandards.Add(new RollGroups() { GroupRollName = "Stock" });

            //context.RollGroup.AddRange(defaultStandards);

            base.Seed(context);
        }
    }
}
