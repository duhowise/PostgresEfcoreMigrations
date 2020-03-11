using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostgresApi.Models
{
    public class User
    {
        public int Id { get; set; }
      [MaxLength(50)]  public string Name { get; set; }
      [MaxLength(250)] public string Email { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
    
    public class Account
    {
        public int Id { get; set; }
        [MaxLength(50)] public string Number { get; set; }
        [MaxLength(500)] public string Description { get; set; }
        public DateTime DateOpened { get; set; }
        public Money Balance { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }

    public class Money
    {
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
    }
}