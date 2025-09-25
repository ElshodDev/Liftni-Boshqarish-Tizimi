//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Liftni_Boshqarish_Tizimi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
           Ok("how's is going elevatorsystem work");
    }
}
