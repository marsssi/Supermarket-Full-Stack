using Supermarket.Data.Models;
using Supermarket.Data.ViewModels;
using System.Collections.Generic;

namespace Supermarket.Data.Services
{
    public interface ISectorsService
    {

      //Definig methods 
        Sector AddSector(SectorVM sector);
        List<Sector> GetAllSectors();
        Sector GetSectorById(int id);
        Sector UpdateSector(int id, SectorVM newValue);
        void DeleteSector(int id);
    }
}
