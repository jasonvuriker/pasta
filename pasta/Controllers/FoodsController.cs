using Microsoft.AspNetCore.Mvc;
using pasta.Dtos;
using pasta.Examples;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace pasta.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FoodsController : ControllerBase
{
    [HttpPost]
    [SwaggerOperation("Create food")]
    [SwaggerRequestExample(typeof(CreateFoodDto), typeof(CreateFoodExample))]
    [SwaggerResponseExample(201, typeof(GetFoodExample))]
    [SwaggerResponse(201, "Food created successfully", typeof(FoodDto))]
    [SwaggerResponse(400, "Bad request")]
    public IActionResult CreateFood([FromBody] CreateFoodDto food)
    {
        //if (food == null)
        //{
        //    return BadRequest("Food cannot be null");
        //}
        //// Simulate saving to a database
        //food.Id = new Random().Next(1, 1000); // Simulate generated ID
        //return CreatedAtAction(nameof(GetFood), new { id = food.Id }, food);

        return Created();
    }
}
