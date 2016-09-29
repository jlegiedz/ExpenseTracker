using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public Category Category { get; set; }
        public DateTime Date { get; set; }
    }

    public enum Category
    {
        Food,
        Car,
        Children,
        Health,
        Beauty,
        House,
        Cloths,
        Entertiment

    }

    public class ExpenseDBContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
    }
}