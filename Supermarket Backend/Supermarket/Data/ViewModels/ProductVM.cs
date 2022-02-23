using System;

namespace Supermarket.Data.ViewModels
{
    public class ProductVM
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime ExpDate { get; set; }

        //Relational data
        public int SectorId { get; set; }
    }
}
