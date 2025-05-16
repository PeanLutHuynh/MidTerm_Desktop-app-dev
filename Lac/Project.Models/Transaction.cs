using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;
using System.Numerics;

namespace Models
{
    public class Transaction
    {
        [Key]
        [Required]
        public Guid Trans_ID { get; set; }

        [Required]
        [MaxLength(20)]
        public long Account_ID { get; set; }

        [Required]
        public DateTime Happened_Time { get; set; }

        [Required]
        [MaxLength(50)]
        public string Action_Desc { get; set; }

        [MaxLength(50)]
        public string Note { get; set; }

        [ForeignKey("Account_ID")]
        public virtual BankAccount BankAccount { get; set; }

    }
}
