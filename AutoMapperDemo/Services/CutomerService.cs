using AutoMapper;
using AutoMapperDemo.Contracts;
using AutoMapperDemo.Data;
using AutoMapperDemo.DTOs;
using AutoMapperDemo.Entities;

namespace AutoMapperDemo.Services;

public class CustomerService(AppDBContext context , IMapper mapper) : ICustomerService
{
    private readonly AppDBContext _context = context;
    private readonly IMapper _mapper = mapper;

    /// <inheritdoc/>
    public CustomerResponseDTO GetCustomerById(int Id)
    {
        var result = _context.Customers.Find(Id);
        var CustomerResponse = _mapper.Map<CustomerResponseDTO>(result);
        return CustomerResponse;
    }
    /// <inheritdoc/>
    public List<CustomerResponseDTO> GetAllCustomers()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public CustomerResponseDTO CreateCustomer(CustomerRequestDTO CustomerRequest)
    {
        var Customer = _mapper.Map<Customer>(CustomerRequest);
        _context.Customers.Add(Customer);
        _context.SaveChanges();
        var response = _mapper.Map<CustomerResponseDTO>(Customer);
        return response;
    }

    public bool DeleteCustomer(int Id)
    {
        throw new NotImplementedException();
    }

 
  
    public bool UpdateCustomer(int Id, CustomerRequestDTO customer)
    {
        throw new NotImplementedException();
    }

   
}
