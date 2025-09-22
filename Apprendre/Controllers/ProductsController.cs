using Domain;
using Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetProduct(int id)
    {
        var product = _productService.GetProduct(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts() 
    {
        var products = _productService.GetAllProduct();
        if (products == null)
        {
            return NotFound();
        }
        return Ok(products);
    }

    [HttpPost]
    public ActionResult AddProduct([FromBody] Product product)
    {
        try
        {
            _productService.AddProduct(product);
            return Ok();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}