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

            //string[] toyArray = { "action figure", "doll", "Legos" };
            //List<string> toyList = new List<string>() { "action figure", "stuffed animal", "Legos" };

            //toyList.Add("Barbie");
            //toyList.Add("remote control car");
            //toyList.Add("yoyo");


            //foreach (string toy in toyList)
            //{
            //    Console.WriteLine(toy);

            //}

            ////same as:
            ////for(int i = 0; i < toyList.Count; i++)
            ////{
            ////  Console.WriteLine(toyList[i]);
            ////}

            ////most common properties and methods used on lists:
            ////.Count
            ////.Insert()
            ////.Add()
            ////.Remove()

            //Console.WriteLine(toyList.Count);

            //toyList.Remove("Barbie");

            //Console.WriteLine(toyList.Count);

            ////insert allowes us to put a new element in the list
            ////AND
            ////sepcify which index we want for that element
            //toyList.Insert(0, "Kite");//whatever is in index 0 gets bumped to 1
            //toyList.Insert(2, "baby doll");
            //toyList.Insert(1, "Plastic Dinosaur");//this moves baby doll to index 3

            //foreach (string toy in toyList)
            //{
            //    Console.WriteLine(toy);

            //}


            ////another method that is useful is .Contains()
            ////It returns a boolean value

            //if (toyList.Contains("Plastic Dinosaur"))
            //{
            //    Console.WriteLine("Daniel would never buy dino.");
            //}
            //else
            //{
            //    Console.WriteLine("Daniel might buy any of these toys.");
            //}


            //List<bool> shelfStatus = new List<bool>() { true, false, true, true, false };
            //for (int i = 0; i < shelfStatus.Count; i++)
            //{
            //    if (shelfStatus[i] == true)
            //    {
            //        Console.WriteLine("There are toys on this shelf.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("There are not toys on this shelf.");
            //    }
            //}

            ////to remove a certain index: .RemoveAt(int index)

            ////create a list.  add 5 stuffed animals.  print each stuffed animal.
            //List<string> stuffedAnimals = new List<string>() { "teddy bear", "shark", "Simba", "tiger", "dog" };
            //for (int i = 0; i < stuffedAnimals.Count; i++)
            //{
            //    Console.WriteLine(stuffedAnimals[i]);
            //}


            //practice problem:
            List<int> numberList = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5, };
            //checking if certain numbers are there:

            //if (numberList.Contains(23))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //bool contain77;
            //if (numberList.Contains(77))
            //{
            //    contain77 = true;
            //}
            //else
            //{
            //    contain77 = false;
            //}
            //Console.WriteLine(contain77);

            //if (numberList.Contains(15))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //} 

            //checking if a number is in list via method:
            ContainsNumber(numberList, 23);
            ContainsNumber(numberList, 77);
            ContainsNumber(numberList, 15);

            //removing numbers:
            numberList.Remove(27);
            numberList.Remove(922);
            numberList.Remove(32);
            numberList.Remove(6);
            numberList.Remove(77);

            //rechecking numbers:
            Console.WriteLine("rechecking numbers after removing 77");
            ContainsNumber(numberList, 23);
            ContainsNumber(numberList, 77);
            ContainsNumber(numberList, 15);
        }

        static void ContainsNumber(List<int> ourList, int numberChecked)
        {
            bool checkNumber = ourList.Contains(numberChecked);
            if(checkNumber == true)
            {
                Console.WriteLine("Nnumber {0} is in the list", numberChecked);
            }
            else
            {
                Console.WriteLine("Number {0} is not in the list", numberChecked);
            }
        }
    }
}
