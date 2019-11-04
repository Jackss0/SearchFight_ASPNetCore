using Microsoft.Extensions.Configuration;
using SearchFight.Models.Google;

namespace SearchFight.Controllers.Google
{
    public interface IGoogleServices
    {
        GoogleSearch GoogleWebResult(string req, IConfiguration configuration);
    }
}
