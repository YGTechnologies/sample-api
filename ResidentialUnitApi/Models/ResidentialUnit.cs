using System;

namespace ResidentialUnitApi.Models
{
    public class ResidentialUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public string LayoutType { get; set; }
        public Project Project { get; set; }
    }
}
