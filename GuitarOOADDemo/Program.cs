using GuitarOOADDemo.Models;
using GuitarSpecOOADDemo.Models;
using static GuitarOOADDemo.Models.Enums;

namespace GuitarOOADDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GuitarSpec spec1 = new GuitarSpec(GuiterBuilder.Martin, "RG", 7, GuiterType.Electric, Wood.Maple, Wood.Walnut);
            GuitarSpec spec2 = new GuitarSpec(GuiterBuilder.Fender, "Stratocaster", 6, GuiterType.Electric, Wood.Alder, Wood.Alder);
            GuitarSpec spec3 = new GuitarSpec(GuiterBuilder.Fender, "Stratocaster", 5, GuiterType.Electric, Wood.Alder, Wood.Alder);

            Guitar guitar1 = new Guitar("SNo1", 12000, spec1);
            Guitar guitar2 = new Guitar("SNo2", 30000, spec2);
            Guitar guitar3 = new Guitar("SNo3", 36700, spec3);

            //GuitarSpec whatErinLikes = new GuitarSpec(GuiterBuilder.Fender, "Stratocaster", 6, GuiterType.Electric, Wood.Alder, Wood.Alder);
            //since this is not present in list it will show else part and we dont have naything similar to show
            GuitarSpec whatErinLikes = new GuitarSpec(GuiterBuilder.Ibanez, "RG", 9, GuiterType.Bass, Wood.Cedar, Wood.Alder);


            Inventory inventory = new Inventory();
            inventory.guitars.Add(guitar1);
            inventory.guitars.Add(guitar2);
            inventory.guitars.Add(guitar3);

            LinkedList<Guitar> foundGuitars = inventory.Search(whatErinLikes);
            if (foundGuitars.Count > 0)
            {
                Console.WriteLine("Searching guitars according to customer preferences\n");
                foreach (var foundGuitar in foundGuitars)
                {
                    Console.WriteLine($"Erin, you might like this:\n" +
                        $"We have a {foundGuitar.Specification.Builder},\n" +
                        $"{foundGuitar.Specification.Model},\n" +
                        $"{foundGuitar.Specification.NumStrings}-String,\n" +
                        $"{foundGuitar.Specification.Type},\n" +
                        $"{foundGuitar.Specification.Backwood}back and sides,\n" +
                        $"{foundGuitar.Specification.Topwood} top\n" +
                        $"You can have it for only Rs.{foundGuitar.Price}!");
                    Console.WriteLine("--------------------------");
                }
            }
            else
            {
                Console.WriteLine("Sorry Erin, We have nothing for you");
            }

        }
    }
}
