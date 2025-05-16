using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace Models
{
    public class BankAccount
    {
        [Key]
        [Required]
        [MaxLength(20)]
        public long Account_ID { get; set; }

        [Required]
        [MaxLength(150)]
        public string Owner_Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Owner_Address{ get; set; }

        [Required]
        [MaxLength(13)]
        public string Owner_Phone { get; set; }

        [Required]
        public double Balance { get; set; }

        [Required]
        [MaxLength(50)]
        public string Account_Type { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
