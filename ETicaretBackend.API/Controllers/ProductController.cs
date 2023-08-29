using ETicaretBackend.Application.Repositories;
using ETicaretBackend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretBackend.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    readonly private IProductWriteRepository _productWriteRepository;
    readonly private IProductReadRepository _productReadRepository;

    readonly private IOrderReadRepository _orderReadRepository;
    readonly private IOrderWriteRepository _orderWriteRepository;

    readonly private ICustomerWriteRepository _customerWriteRepository;

    public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, 
        IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository, ICustomerWriteRepository customerWriteRepository)
    {
        _productReadRepository = productReadRepository;
        _productWriteRepository = productWriteRepository;
        _orderWriteRepository = orderWriteRepository;
        _orderReadRepository = orderReadRepository;
        _customerWriteRepository = customerWriteRepository;
    }

    [HttpGet]
    public async Task Get()
    {
        // var cusId = Guid.NewGuid();
        // await _customerWriteRepository.AddAsync(new() { Id = cusId, Name = "Kerim" });
        //
        // await _orderWriteRepository.AddAsync(new() { Description = "bla bla", Address = "Çankaya", CustomerId = cusId});
        // await _orderWriteRepository.AddAsync(new() { Description = "bla bla", Address = "Pursaklar", CustomerId = cusId});
        // await _orderWriteRepository.SaveAsync();

        Order order = await _orderReadRepository.GetByIdAsync("7870044c-c9b8-4bf5-a825-db1dcebb311e");
        order.Address = "Istanbl";
        await _orderWriteRepository.SaveAsync();
    }

}