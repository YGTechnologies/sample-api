using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResidentialUnitApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResidentialUnitController : ControllerBase
    {
        private readonly Context _context;

        public ResidentialUnitController(Context context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Models.ResidentialUnit> Get()
        {
            return _context.ResidentialUnits;
        }
    }
}
