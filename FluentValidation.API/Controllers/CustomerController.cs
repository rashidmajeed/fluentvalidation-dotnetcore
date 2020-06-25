using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsValidation.Library;
using FluentValidation.Results;
using FluentValidation.API.Models;
using FluentValidation.API.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            return Ok();
        }
        
    }
}