using System;
using System.Collections.Generic;

namespace Supermarket.Data.Models
{

    //Creating Sector Model
    public class Sector
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime DateCreated { get; set; }



        //Navigation properties
        public List<Product> Products { get; set; }
    }
}


   