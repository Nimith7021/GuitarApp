using GuitarAppOOAD.Models;
namespace GuitarAppOOAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            GuitarSpec guitarSpec1 = new GuitarSpec(Builder.FENDER, "Stratacaster", 
                TypeOfGuitar.ELECTRIC, Wood.MAPLE, Wood.ALDER,6);
            inventory.AddGuitar("100",23000,guitarSpec1);
            GuitarSpec guitarSpec2 = new GuitarSpec(Builder.FENDER, "Stratacaster", 
                TypeOfGuitar.ELECTRIC, Wood.MAPLE , Wood.ALDER,6);
            inventory.AddGuitar("110",45000,guitarSpec2);
            GuitarSpec guitarSpec3 = new GuitarSpec(Builder.COLLINGS, "BasePlay", 
                TypeOfGuitar.ACOUSTIC, Wood.MAPLE, Wood.ALDER,7);
            inventory.AddGuitar("110", 45000, guitarSpec3);
            GuitarSpec guitarSpec4 = new GuitarSpec(Builder.GIBSON, "Stratacaster", 
                TypeOfGuitar.ELECTRIC,Wood.BRAZILIAN_ROSEWOOD, Wood.SITKA, 12);
            inventory.AddGuitar("110", 45000, guitarSpec4);
            GuitarSpec requiredGuitar = new GuitarSpec(Builder.FENDER, "Stratacaster",
                TypeOfGuitar.ELECTRIC,Wood.MAPLE,Wood.ALDER,6);
            PrintGuitars(inventory, requiredGuitar);
            
        }

        static void PrintGuitars(Inventory inventory , GuitarSpec requiredGuitar)
        {
            List<Guitar> guitarList = inventory.SearchGuitar(requiredGuitar);
            if (guitarList.Count != 0)
            {
                Console.WriteLine("You may like these models");
                foreach (Guitar guitar in guitarList)
                {
                    Console.WriteLine(guitar);
                }
            }
            else
            {
                Console.WriteLine("Sorry , we don't have what you are looking for ");
            }
        }
    }
}
