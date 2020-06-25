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
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            ProductValidator validator = new ProductValidator();
            List<string> ValidationMessages = new List<string>();
            var product = new Product
            {
                Name = "",
                Brand = "Nike",
                price = "200$"
            };
            var validationResult = validator.Validate(product);
            var response = new ResponseModel();
            if (!validationResult.IsValid)
            {
                response.IsValid = false;
                foreach (ValidationFailure failure in validationResult.Errors)
                {
                    ValidationMessages.Add(failure.ErrorMessage);
                }
                response.ValidationMessages = ValidationMessages;
            }
            return Ok(response);
        }
    }
}