using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompanyName.AbpZeroTemplate.HiddenFunction
{
    public interface IHFuncAppService: IApplicationService
    {
        ListResultDto<HFuncListDto> GetHFunc(GetHFuncInput input);
    }
}
