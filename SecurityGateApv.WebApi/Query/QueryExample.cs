using HotChocolate.Authorization;
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

        //[Authorize(Roles = new[] { "Admin" })]
        [UseOffsetPaging(MaxPageSize = int.MaxValue, IncludeTotalCount = true)]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<GetVisitorSessionRes>> GetVisitorSession([Service] IVisitorSessionService _visitorSessionService, [Service] IHttpContextAccessor httpContextAccessor)
        {
            var token = httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var result = await _visitorSessionService.GetAllVisitorSession(1, int.MaxValue, token);

            if (result.IsFailure)
            {
                throw new Exception(result.Error.Message);
            }
            return result.Value;
        }
    }
}
