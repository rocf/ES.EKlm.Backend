using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;

namespace MyCompanyName.AbpZeroTemplate.HiddenFunction
{
    public class HFuncAppService : AbpZeroTemplateAppServiceBase, IHFuncAppService
    {
        private readonly IRepository<HiddenFunc> _hiddenFuncRepository;

        public HFuncAppService(IRepository<HiddenFunc> hiddenFuncRepository)
        {
            _hiddenFuncRepository = hiddenFuncRepository;
        }
        public ListResultDto<HFuncListDto> GetHFunc(GetHFuncInput input)
        {
            var hfunc = _hiddenFuncRepository
                .GetAll()
                .WhereIf(!input.Filter.IsNullOrEmpty(),
                h => h.HFuncId.Contains(input.Filter) ||
                    h.HFuncName.Contains(input.Filter) ||
                    h.Description.Contains(input.Filter)
                    )
                .OrderBy(h => h.HFuncId)
                .ToList();

            return new ListResultDto<HFuncListDto>(ObjectMapper.Map<List<HFuncListDto>>(hfunc));
                                            
        }
    }
}
