using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;


namespace SecurityGateApv.WebApi.Query
{
    public class QueryExample
    {
        [UseOffsetPaging(MaxPageSize = int.MaxValue, IncludeTotalCount = true)]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<GetVisitNoDetailRes>> GetVisit([Service] IVisitService _visitService)
        {            
            return (await _visitService.GetAllVisit(int.MaxValue,1)).Value;
        }
        public async Task<GetVisitRes> GetVisitById([Service] IVisitService _visitService, int visitId)
        {
            return (await _visitService.GetVisitDetailByVisitId(visitId)).Value;
        }



        [UseOffsetPaging(MaxPageSize = int.MaxValue, IncludeTotalCount = true)]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<GetVisitorSessionRes>> GetVisitorSession([Service] IVisitorSessionService _visitorSessionService)
        {
            return (await _visitorSessionService.GetAllVisitorSession(1, int.MaxValue)).Value;
        }
    }
}
