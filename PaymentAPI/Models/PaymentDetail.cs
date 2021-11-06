using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        //hdhjhfdjhfksjd
        public int PaymentDetailId { get; set; }
        //gddusisjusj
        public string CardOwnerName { get; set; }
        //gddusisjusj
        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }
        //gddusisjusj
        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; }

        //gddusisjusj
        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; }
    }
}