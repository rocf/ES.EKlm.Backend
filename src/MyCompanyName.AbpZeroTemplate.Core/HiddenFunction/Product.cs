using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompanyName.AbpZeroTemplate.HiddenFunction
{
    [Table("HfProducts")]
    public class Product : Entity
    {
        [Required]
        public virtual ProductName ProductName { get; set; }
        [Required]
        public virtual string Version { get; set; }

        [ForeignKey("HFuncId")]
        public virtual HiddenFunc HiddenFunc { get; set; }
        public virtual int HFuncId { get; set; }

    }
}
