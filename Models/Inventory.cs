using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppOOAD.Models
{
    internal class Inventory
    {
        public List<Guitar> guitars {  get; set; } = new List<Guitar>();
        
        public void AddGuitar(string serialNumber, double price,GuitarSpec guitarSpec)
        {
            Guitar guitar = new Guitar(serialNumber,price,guitarSpec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber) { 
        
            Guitar findGuitar = null;
            foreach(Guitar guitar in guitars)
            {
                if(guitar.SerialNumber==serialNumber)
                    findGuitar = guitar;
            }
            return findGuitar!;
        }

        public List<Guitar> SearchGuitar(GuitarSpec searchGuitar)
        {
            List<Guitar> userList = new List<Guitar>();
            foreach(Guitar guitar in guitars)
            {
                
                if (guitar.guitarspec.IsGuitarMatching(searchGuitar))
                {
                    
                    userList.Add(guitar);
                }
            }

            return userList;
           
        }
    }
}
