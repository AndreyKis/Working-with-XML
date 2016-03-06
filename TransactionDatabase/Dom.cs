using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.Windows.Forms;
namespace TransactionDatabase
{
    class Dom : IXml
    {
        XmlDocument xmlDocument = new XmlDocument();
        private string filePath;
        public void LoadFile(string filePath)
        {
            if (filePath == null || filePath == "")
                throw new ArgumentException("Bad XML");
            this.filePath = filePath;
            xmlDocument.Load(filePath);
        }

        private Transaction ParseTransaction(XmlNode node)
        {
            Transaction transaction = new Transaction();
            transaction.id = Int32.Parse(node.Attributes.GetNamedItem("id").Value.ToString());
            transaction.date = node.Attributes.GetNamedItem("date").Value.ToString();
            transaction.type = node.Attributes.GetNamedItem("type").Value.ToString();
            transaction.cost = Double.Parse(node.FirstChild.Value.ToString());
            transaction.categoryId = Int32.Parse(node.Attributes.GetNamedItem("categoryId").Value.ToString());
            return transaction;
        }
        
        private List<Transaction> GetTransactions(XmlNodeList nodes)
        {
            var result = new List<Transaction>();
            foreach (XmlNode node in nodes)
            {
                result.Add(ParseTransaction(node));
            }
            return result;
        }

        public List<Transaction> GetAllTransatcions()
        {
            if (xmlDocument == null)
                throw new ArgumentException("Bad XML");
            var nodes = xmlDocument.SelectNodes("//transaction");
            var result = GetTransactions(nodes);
            return result;
        }

        public List<Transaction> SearchByCategoryId(int id)
        {
            if (xmlDocument == null)
                throw new ArgumentException("Bad XML");
            var nodes = xmlDocument.SelectNodes(@"//transaction[@categoryId=  """ + id.ToString() + @"""]");
            var result = GetTransactions(nodes);
            return result;
        }
        public List<Transaction> GetAllTransactions()
        {
            if (xmlDocument == null)
                throw new ArgumentException("Bad XML");
            var nodes = xmlDocument.SelectNodes(@"//transaction");
            var result = GetTransactions(nodes);
            return result;
        }

        public List<Transaction> SearchById(int id)
        {
            if (xmlDocument == null)
                throw new ArgumentException("Bad XML");
            var nodes = xmlDocument.SelectNodes(@"//transaction[@id=  """ + id.ToString() + @"""]");
            var result = GetTransactions(nodes);
            return result;
        }
        public List<Transaction> SearchByDate(string startDate, string endDate)
        {
            if (xmlDocument == null)
                throw new ArgumentException("Bad XML");
            string xpath = @"//transaction";
            XmlNodeList nodes = xmlDocument.SelectNodes(xpath);
            var result = new List<Transaction>();
            foreach (XmlNode node in nodes)
            {
                string date = node.Attributes.GetNamedItem("date").Value;
                if ((date.CompareTo(startDate) >= 0) && (date.CompareTo(endDate) <= 0))
                {
                    result.Add(ParseTransaction(node));
                }

            }
            return result;
        }      
    }
}
