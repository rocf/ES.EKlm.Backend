using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.HiddenFunction
{
    [Table("HfFuncs")]
    public class HiddenFunc : FullAuditedEntity
    {
        [Required]
        [MaxLength(HFuncConsts.MaxHFuncIdLenght)]
        public virtual string HFuncId { get; set; }             //编码

        [Required]
        public virtual HFuncStatus HFuncStatus { get; set; }    //功能状态
        [Required]
        public virtual string HFuncName { get; set; }           //名称
        [Required]
        public virtual HFuncType HFuncType { get; set; }        //类型
        [Required]
        public virtual string TypeParameter { get; set; }       //类型参数
        [Required]
        public virtual string DefaultValue { get; set; }        //默认值
        [Required]
        public virtual string Description { get; set; }         //功能描述
        public virtual string RiskStatement { get; set; }       //风险说明
        [Required]
        public virtual string OpenSQL { get; set; }             //开启SQL脚本
        [Required]
        public virtual string CloseSQL { get; set; }            //关闭SQL脚本
        [Required]
        public virtual ICollection<Product> Products { get; set;}
    }
}
