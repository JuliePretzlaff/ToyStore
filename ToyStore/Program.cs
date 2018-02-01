using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] toyArray = { "action figure", "doll", "Legos" };
            List<string> toyList = new List<string>() { "action figure", "stuffed animal", "Legos"};

            toyList.Add("Barbie");
            toyList.Add("remote control car");
            toyList.Add("yoyo");


            foreach(string toy in toyList)
            {
                Console.WriteLine(toy);

            }

            //same as:
            //for(int i = 0; i < toyList.Count; i++)
            //{
            //  Console.WriteLine(toyList[i]);
            //}

            //most common properties and methods used on lists:
            //.Count
            //.Insert()
            //.Add()
            //.Remove()

            Console.WriteLine(toyList.Count);

            toyList.Remove("Barbie");

            Console.WriteLine(toyList.Count);

            //insert allowes us to put a new element in the list
            //AND
            //sepcify which index we want for that element
            toyList.Insert(0, "Kite");//whatever is in index 0 gets bumped to 1
            toyList.Insert(2, "baby doll");
            toyList.Insert(1, "Plastic Dinosaur");//this moves baby doll to index 3

            foreach (string toy in toyList)
            {
                Console.WriteLine(toy);

            }

            List<string> employeeNames = new List<string>();

        }
    }
}
