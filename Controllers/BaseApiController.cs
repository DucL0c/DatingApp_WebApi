﻿using api.Helper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : Controller
    {
    }
}
