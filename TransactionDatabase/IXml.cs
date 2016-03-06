using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionDatabase
{
    interface IXml
    {
        void LoadFile(string filePath);
        List<Transaction> SearchById(int id);
        List<Transaction> SearchByDate(string startDate, string endDate);
        List<Transaction> SearchByCategoryId(int category);
        List<Transaction> GetAllTransactions();
    }
}
