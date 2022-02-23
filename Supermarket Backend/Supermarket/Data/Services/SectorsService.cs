using Supermarket.Data.Models;
using Supermarket.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket.Data.Services
{
    public class SectorsService:ISectorsService
    {
        //Inject AppDbContext file
        private AppDbContext _context;


        //The Constructor
        public SectorsService(AppDbContext context)
        {
            _context = context;
        }


        // ------------------  CREATING  METHODS --------------------------------------------------------------------------------
        
        //Creating a method to add sectors
        public Sector AddSector(SectorVM sector)
        {
            var _sector = new Sector()
            {
                Name = sector.Name,
                Code = sector.Code,
                DateCreated = System.DateTime.Now,
            };

            _context.Sectors.Add(_sector);
            _context.SaveChanges();

            return _sector;
        }



        //Creating a method to list all sectors
        public List<Sector> GetAllSectors()=> _context.Sectors.ToList();
            
      

        //Creating a method to list a sector by ID
        public Sector GetSectorById(int id)=> _context.Sectors.FirstOrDefault(n => n.Id == id);
           


        //Creating a method to update a sector by ID
        public Sector UpdateSector(int id, SectorVM newValue)
        {
            var dbSector = _context.Sectors.FirstOrDefault(x => x.Id == id);
            if (dbSector != null)
            {
                dbSector.Name = newValue.Name;
                dbSector.Code = newValue.Code;

                _context.SaveChanges();
            }
            return dbSector;
        }



        //Creating a method to delete a sector by ID
        public void DeleteSector(int id)
        {
            var dbSector = _context.Sectors.FirstOrDefault(x => x.Id == id);
            if (dbSector != null)
            {
                _context.Sectors.Remove(dbSector);
                _context.SaveChanges();
            }
        }
    }
}
