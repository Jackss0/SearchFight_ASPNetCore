using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SearchFight.Controllers.Google;
using SearchFight.Models.Google;
using SearchFight.Services;

namespace SearchFight.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleController
    {
        private readonly IConfiguration _configuration;
        private readonly IGoogleServices _googleServices;
        public GoogleController(IConfiguration configuration, IGoogleServices googleServices)
        {
            _googleServices = googleServices;
            _configuration = configuration;
        }

        [HttpGet("{req}")]
        public GoogleSearch Get(string req)
        {
            var key = _configuration.GetSection("GoogleAPI:key1").Value;
            return _googleServices.GoogleWebResult(req, _configuration);
        }
    }
}