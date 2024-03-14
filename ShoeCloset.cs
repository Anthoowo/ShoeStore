using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore
{
    internal class ShoeCloset
    {
        public List<Shoe> shoes =   new List<Shoe>();

        public void PrintShoes()
        {
            if(shoes.Count == 0) {
                Console.WriteLine("\n The Shoe closet is empty");
            }
            else
            {
                Console.WriteLine("\n The shoe closet contains: ");
                int i = 1;
                foreach(Shoe shoe in shoes)
                {
                    Console.Write($"shoe #{i++} : {shoe.Description}"); 
                }
            }

        }

       public void AddShoe()
        {
            Console.WriteLine("\n Add a shoe");

            for(int i = 0; i < shoes.Count; i++)
            {
                Console.WriteLine($"Press {i} to add a  {(Style)i}");
            }
            Console.WriteLine("Enter a style: ");
            if(int.TryParse(Console.ReadKey().KeyChar.ToString(), out int result)) {
                Console.WriteLine("Enter the Color: ");
                string color = Console.ReadLine();
                Shoe shoe = new Shoe((Style)result, color);
                shoes.Add(shoe);


            }
        }



    }
}
