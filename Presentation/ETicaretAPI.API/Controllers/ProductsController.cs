using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories.ICustomer;
using ETicaretAPI.Application.Repositories.IOrder;
using ETicaretAPI.Application.Repositories.IProduct;
using ETicaretAPI.Domain.Entity;
using Microsoft.AspNetCore.Mvc;


namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        readonly private IOrderReadRepository _orderReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;
        readonly private ICustomerReadRepository _customerReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository,IOrderReadRepository orderReadRepository , IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
        }

    
        [HttpGet]
        public async Task Get()
        {
            Customer customer = await _customerReadRepository.GetByIdAsync("ec4d0bd6-fc77-4edc-91b5-0704994ad4fe");
            customer.Name = "Mustafa";
            await _customerWriteRepository.SaveAsync();

        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(string id)
        {
           
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }

    }
}