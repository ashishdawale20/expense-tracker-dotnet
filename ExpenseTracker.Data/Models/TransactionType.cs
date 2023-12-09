using System;
using System.Collections.Generic;

namespace ExpenseTracker.Data.Models
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            TransactionHistories = new HashSet<TransactionHistory>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
    }
}
