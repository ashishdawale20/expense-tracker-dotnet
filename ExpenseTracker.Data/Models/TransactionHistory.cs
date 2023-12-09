using System;
using System.Collections.Generic;

namespace ExpenseTracker.Data.Models
{
    public partial class TransactionHistory
    {
        public int Id { get; set; }
        public int? TransactionType { get; set; }
        public string? Place { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public string? Currency { get; set; }
        public decimal? Amount { get; set; }
        public string? Note { get; set; }
        public string? Tags { get; set; }

        public virtual Category? Category { get; set; }
        public virtual TransactionType? TransactionTypeNavigation { get; set; }
    }
}
