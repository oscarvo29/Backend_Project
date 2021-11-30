using ChristiansOeBackend.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ChristiansOeBackend.Controllers
{
    [ApiController]
    [Route("api/marker/[action]")]
    public class MarkersController : ControllerBase
    {
        private MarkersService _markersService = new MarkersService();

        [HttpGet]
        public JsonResult Index()
        {
            return new JsonResult(_markersService.GetMarkers());
        }

    }
}