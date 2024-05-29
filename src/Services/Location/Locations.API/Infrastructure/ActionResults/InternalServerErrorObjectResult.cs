using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BolaRoja.Services.Locations.API.Infrastructure.ActionResults
{
    public class InternalServerErrorObjectResult : ObjectResult
    {
        public InternalServerErrorObjectResult(object error)
            : base(error)
        {
            StatusCode = StatusCodes.Status500InternalServerError;
        }
    }
}
