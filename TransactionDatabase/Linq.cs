using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace TransactionDatabase
{
    class Linq : IXml
    {
        XDocument xmlDocument = null;

        public void LoadFile(string filePath)
        {
            if (filePath == null || filePath == "")
                throw new ArgumentException("Wrong XML file");
            xmlDocument = XDocument.Load(filePath);
        }
        public List<Transaction> GetAllTransactions()
        {
            if (xmlDocument == null)
                throw new ArgumentException("Bad XML");
            var result = (from item in xmlDocument.Descendants("transaction")
                          select GetTransactionFromXElement(item)).ToList();
            return result;
        }
        public List<Transaction> SearchByDate(string startDate, string endDate)
        {
            if (xmlDocument == null)
                throw new ArgumentException("Bad XML");
            var result = (from item in xmlDocument.Descendants("transaction")
                          where ((item.Attribute("date").Value.CompareTo(startDate) >= 0) &&
                                 (item.Attribute("date").Value.CompareTo(endDate) <= 0))
                          select GetTransactionFromXElement(item)).ToList();
            return result;
        }
        public List<Transaction> SearchById(int id)
        {
            if (xmlDocument == null)
                throw new ArgumentException("Bad XML");
            var result = (from item in xmlDocument.Descendants("transaction")
                          where (item.Attribute("id").Value == id.ToString())
                          select GetTransactionFromXElement(item)).ToList();
            return result;
        }
        public List<Transaction> SearchByCategoryId(int categoryId)
        {
            if (xmlDocument == null)
                throw new ArgumentException("Bad XML");
            var result = (from item in xmlDocument.Descendants("transaction")
                          where (item.Attribute("categoryId").Value == categoryId.ToString())
                          select GetTransactionFromXElement(item)).ToList();
            return result;
        }

        private Transaction GetTransactionFromXElement(XElement element)
        {
            Transaction result = new Transaction();
            result.id = (int)element.Attribute("id");
            result.cost = Double.Parse(element.Value);
            result.date = element.Attribute("date").Value;
            result.categoryId = (int)element.Attribute("categoryId");
            result.type = (string)element.Attribute("type");
            return result;
        }


        
        
    }
}
