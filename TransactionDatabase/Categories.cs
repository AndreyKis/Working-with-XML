using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace TransactionDatabase
{
    class Categories
    {
        List<KeyValuePair<int, string>> categories;
        public void Load(string xmlPath)
        {
            var xmlDocument = XDocument.Load(xmlPath);
            
            categories = (from item in xmlDocument.Descendants("category")
                             select new KeyValuePair<int, string>(Int32.Parse(item.Attribute("id").Value), item.Value)).ToList();

        }
        public string GetName(int id)
        {
            if (categories == null)
                return null;
            foreach (var category in categories)
            {
                if (category.Key == id)
                {
                    return category.Value;
                }
            }
            return null;
        }
        public int GetId(string name)
        {
            if (categories == null)
                return -1;
            foreach (var category in categories)
            {
                if (category.Value == name)
                {
                    return category.Key;
                }
            }
            return -1;
        }


    }
}
