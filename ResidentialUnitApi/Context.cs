using Microsoft.EntityFrameworkCore;
using ResidentialUnitApi.Models;

namespace ResidentialUnitApi
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
          : base(options)
        {
            GenerateData();
        }

        public DbSet<ResidentialUnit> ResidentialUnits { get; set; }


        private void GenerateData()
        {
            var project = new Project
            {
                Name = "BekkehusGaten 2",
                Description = "",
            };



            var unit1 = new ResidentialUnit
            {
                Floor = "1",
                Name = "Unit-1",
                Project = project,
                LayoutType = "C"
            };

            ResidentialUnits.Add(unit1);

            var unit2 = new ResidentialUnit
            {
                Floor = "2",
                Name = "Unit-2",
                Project = project,
                LayoutType = "B"
            };

            ResidentialUnits.Add(unit2);

            this.SaveChanges();

        }
    }
}
