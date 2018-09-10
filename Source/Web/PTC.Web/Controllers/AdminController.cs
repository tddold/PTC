using PTC.Web.Infrastructure.Filters;
using System.Web.Http;

namespace PTC.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    [Log]
    public abstract class AdminController : BaseController
    {

    }
}