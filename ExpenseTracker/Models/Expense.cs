using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the expense amount.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Please choose a category from the list.")]
        public Category Category { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
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