using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompanyName.AbpZeroTemplate.HiddenFunction.Dto
{
    public class ProductInHFuncListDto: CreationAuditedEntityDto
    {
        public ProductName productName { get; set; }
        public string Version { get; set; }
    }
}
