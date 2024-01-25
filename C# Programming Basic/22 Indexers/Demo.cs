using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Indexers
{
    internal class Demo
    {
        public void Run()
        {
            //indexers
            //NameList names = new NameList();
            //names[0] = "sina";
            //Console.WriteLine("name : " + names[10]);

            //index class | object
            CategoryList categories = new CategoryList();
            categories[0] = new Category(1, "Drink");
            categories[1] = new Category(2, "Bakery");
            categories[2] = new Category(3, "Noodle");
            //categories[0].Show();

            //indexer overloading
            Category category = categories["aa"];
            if(category != null)
            {
                //category.Show();
            }
            else
            {
                //Console.WriteLine("category not found.");
            }

            //indexer multidimensional
            BoxList boxList = new BoxList();
            boxList[0, 0] = 100;
            Console.WriteLine(boxList[0,0]);
        }
    }
}
