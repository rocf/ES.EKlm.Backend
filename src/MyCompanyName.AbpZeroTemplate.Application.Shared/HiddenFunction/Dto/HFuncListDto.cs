using Abp.Application.Services.Dto;
using MyCompanyName.AbpZeroTemplate.HiddenFunction.Dto;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCompanyName.AbpZeroTemplate.HiddenFunction
{
    public class HFuncListDto: FullAuditedEntityDto
    {

        public string HFuncId { get; set; }             //编码
        public HFuncStatus HFuncStatus { get; set; }    //功能状态
        public string HFuncName { get; set; }           //名称
        public HFuncType HFuncType { get; set; }        //类型
        public string TypeParameter { get; set; }       //类型参数
        public string DefaultValue { get; set; }        //默认值
        public string Description { get; set; }         //功能描述
        public string RiskStatement { get; set; }       //风险说明
        public string OpenSQL { get; set; }             //开启SQL脚本
        public string CloseSQL { get; set; }            //关闭SQL脚本
        public ICollection<ProductInHFuncListDto> Products { get; set; }
    }
}