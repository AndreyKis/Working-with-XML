using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace TransactionDatabase
{
    class Sax : IXml
    {
        private string filePath = null;
        

        public void LoadFile(string filePath)
        {
            if (filePath == null || filePath == "")
                throw new ArgumentException("Відкрийте спочатку хмл файл");
            this.filePath = filePath;
        }
        Transaction currentTransaction= new Transaction();
        private Transaction GetNextTransaction(XmlTextReader xmlReader)
        {
            
            while (xmlReader.Read())
            {

                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.Name == "transaction")
                    {
                        
                        if (xmlReader.MoveToAttribute("id"))
                        {
                            currentTransaction.id = Int32.Parse(xmlReader.Value);
                        }
                        
                        if (xmlReader.MoveToAttribute("date"))
                        {
                            currentTransaction.date = xmlReader.Value;
                        }
                        if (xmlReader.MoveToAttribute("type"))
                        {
                            currentTransaction.type = xmlReader.Value;
                        }
                        if (xmlReader.MoveToAttribute("categoryId"))
                        {
                            currentTransaction.categoryId = Int32.Parse(xmlReader.Value);
                        }
                        
                    }
                }
                else if (xmlReader.NodeType == XmlNodeType.Text)// && xmlReader.Name == "transaction")
                {
                    string q = xmlReader.Value;
                    if (!Double.TryParse(q, out currentTransaction.cost))
                    {
                        currentTransaction.cost = 0.0;
                    }
                    
                }
                else if (xmlReader.NodeType == XmlNodeType.EndElement)
                {
                    if (xmlReader.Name == "transaction")
                    {
                        return new Transaction(currentTransaction);
                    }
                }
            }
            return null;
        }
        public List<Transaction> SearchById(int id)
        {

            if (filePath == null)
                throw new ArgumentException("Невірний XML-файл");
            var result = new List<Transaction>();
            using (var xmlReader = new XmlTextReader(filePath))
            {

                while (true)
                {
                    Transaction transaction = GetNextTransaction(xmlReader);
                    if (transaction == null)
                        break;
                    if (transaction.id == id)
                    {
                        result.Add(transaction);
                    }
                }
            }
            return result;
        }
        public List<Transaction> GetAllTransactions()
        {

            if (filePath == null)
                throw new ArgumentException("Невірний XML-файл");
            var result = new List<Transaction>();
            using (var xmlReader = new XmlTextReader(filePath))
            {

                while (true)
                {
                    Transaction transaction = GetNextTransaction(xmlReader);
                    if (transaction == null)
                        break;
                    result.Add(transaction);
                }
            }
            return result;
        }
        public List<Transaction> SearchByDate(string startDate, string endDate)
        {

            if (filePath == null)
                throw new ArgumentException("Невірний XML-файл");
            var result = new List<Transaction>();
            using (var xmlReader = new XmlTextReader(filePath))
            {
                while (true)
                {
                    Transaction transaction = GetNextTransaction(xmlReader);
                    if (transaction == null)
                        break;
                    if ((transaction.date.CompareTo(startDate)>=0) &&
                       (transaction.date.CompareTo(endDate) <=0))
                    {
                        result.Add(transaction);
                    }
                }
            }
            return result;
        }

        public List<Transaction> SearchByCategoryId(int categoryId)
        {

            if (filePath == null)
                throw new ArgumentException("Невірний XML-файл");
            var result = new List<Transaction>();
            using (var xmlReader = new XmlTextReader(filePath))
            {

                while (true)
                {
                    Transaction transaction = GetNextTransaction(xmlReader);
                    if (transaction == null)
                        break;
                    if (transaction.categoryId == categoryId)
                    {
                        result.Add(transaction);
                    }
                }
            }
            return result;
        }
        

    }


}
