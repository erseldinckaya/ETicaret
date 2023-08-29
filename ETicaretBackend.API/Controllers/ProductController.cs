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

    public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
    {
        _productReadRepository = productReadRepository;
        _productWriteRepository = productWriteRepository;
    }

    [HttpGet]
    public async Task Get()
    {
        await _productWriteRepository.AddRangeAsync(new()
        {
            new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Product1", Price = 100, Stock = 10 }
        });
        await _productWriteRepository.SaveAsync();
    }

    [HttpGet("id")]
    public async Task<IActionResult> Get(string id)
    {
        Product product = await _productReadRepository.GetByIdAsync(id);
        return Ok(product);
    }
}