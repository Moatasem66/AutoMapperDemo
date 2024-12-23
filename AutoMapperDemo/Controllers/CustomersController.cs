using AutoMapperDemo.Contracts;
using AutoMapperDemo.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerService;
    public CustomersController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet("getcustomerbyid/{Id}")]
    public IActionResult GetCustomerById(int Id)
    {
        return Ok();
    }
    [HttpPost("creatcustomer")]
    public IActionResult CreateCustomer (CustomerRequestDTO  CustomerRequest)
    {
        var response  = _customerService.CreateCustomer(CustomerRequest);
        return response == null ? BadRequest() : Ok(response);  
    }
    
   
}
