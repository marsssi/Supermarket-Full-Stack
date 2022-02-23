using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Supermarket.Data.Models
{

    //Creating Product Model
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime DateCreated { get; set; }



        //Relational data
        [ForeignKey("Sector")]
        public int SectorId { get; set; }
        public Sector Sector { get; set; }


    }
}
