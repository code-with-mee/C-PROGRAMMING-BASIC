using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Indexers
{
    internal class CategoryList
    {
        private Category[] categories = new Category[5];
        //indexer
        public Category this[int index]
        {
            get 
            {
                if (index < 0 || index >= categories.Length - 1)
                    throw new ArgumentOutOfRangeException("index");
                return categories[index]; 
            }
            set 
            {
                if (index < 0 || index >= categories.Length - 1)
                    throw new ArgumentOutOfRangeException("index");
                categories[index] = value; 
            }
        }

        public Category this[string name]
        {
            get
            {
                for(int i = 0; i < categories.Length; i++)
                {
                    Category category = categories[i];
                    if (category != null && category.Name == name)
                        return categories[i];
                }
                return null;
            }
        }
    }
}
