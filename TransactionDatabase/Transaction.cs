using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionDatabase
{
    public class Transaction
    {
        public int id;

        public int categoryId;
        public double cost;
        public string type = "income";
        public string date = "0000-00-00";
        public Transaction(Transaction t)
        {
            id = t.id;
            categoryId = t.categoryId;
            cost = t.cost;
            type = t.type;
            date = t.date;
        }
        public Transaction()
        {

        }
    }

}
