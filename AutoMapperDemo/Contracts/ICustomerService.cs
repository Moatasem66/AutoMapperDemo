using AutoMapperDemo.DTOs;

namespace AutoMapperDemo.Contracts;
/// <summary>
/// Contract To Crud Service to Customer 
/// </summary>
public interface ICustomerService
{
    /// <summary>
    /// method to Get Customer by id using Mapper to return in CustomerResponseDto 
    /// </summary>
    /// <param name="id">Id</param>
    /// <returns name= "CustomerResponseDTO">CustomerResponseDTO</returns>
    CustomerResponseDTO GetCustomerById(int id);
    /// <summary>
    /// method to Get List of Customer  
    /// </summary>
    /// <returns name= "CustomerResponseDTO" >List of CustomerResponseDTO</returns>
    List<CustomerResponseDTO> GetAllCustomers();
    /// <summary>
    /// Method To Create new Customer in DBContext 
    /// </summary>
    /// <param name="customer">CutomerRequestDTO</param>
    /// <returns>CustomerResponseDTO</returns>
    CustomerResponseDTO CreateCustomer(CustomerRequestDTO customer);
    /// <summary>
    /// Method To update exist Customer in DBContext if not exist return false
    /// </summary>
    /// <param name="Id">Id</param>
    /// <param name="customer">CutomerRequestDTO</param>
    /// <returns>bool</returns>
    bool UpdateCustomer(int Id , CustomerRequestDTO customer);
    /// <summary>
    /// Method To delete exist Customer in DBContext if not exist return false
    /// </summary>
    /// <param name="Id">Id</param>
    /// <returns>bool</returns>
    bool DeleteCustomer(int Id );
}
