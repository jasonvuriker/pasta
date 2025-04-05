using System.Net;
using Microsoft.AspNetCore.Mvc;
using pasta.Dtos;
using pasta.Examples;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace pasta.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MenuController : ControllerBase
{
    [HttpGet]
    [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(GetMenuExample))]
    [SwaggerResponse((int)HttpStatusCode.OK, "Get all menu", typeof(IList<MenuDto>))]
    [SwaggerResponse((int)HttpStatusCode.NotFound, "Menu not found")]
    public async Task<IActionResult> GetMenu()
    {
        var menu = new MenuDto()
        {
            Foods = new List<FoodDto>()
            {
                new()
                {
                    Id = 1,
                    Name = "Spaghetti",
                    Price = 12.99m,
                    Size = 1.5f,
                    Description = "A classic Italian pasta dish with tomato sauce and meatballs."
                },
                new()
                {
                    Id = 2,
                    Name = "Fettuccine Alfredo",
                    Price = 14.99m,
                    Size = 1.0f,
                    Description = "Fettuccine pasta tossed in a creamy Alfredo sauce with Parmesan cheese."
                },
                new()
                {
                    Id = 3,
                    Name = "Penne Arrabbiata",
                    Price = 11.99m,
                    Size = 1.2f,
                    Description = "Penne pasta in a spicy tomato sauce with garlic and chili flakes."
                },
                new()
                {
                    Id = 4,
                    Name = "Lasagna",
                    Price = 15.99m,
                    Size = 2.0f,
                    Description = "Layers of pasta, meat, cheese, and tomato sauce baked to perfection."
                },
                new()
                {
                    Id = 5,
                    Name = "Pesto Pasta",
                    Price = 13.99m,
                    Size = 1.3f,
                    Description = "Pasta tossed in a fresh basil pesto sauce with pine nuts and Parmesan."
                },
                new()
                {
                    Id = 6,
                    Name = "Ravioli",
                    Price = 16.99m,
                    Size = 1.4f,
                    Description = "Stuffed pasta with ricotta cheese and spinach, served with marinara sauce."
                },
            }
        };

        return Ok(new List<MenuDto>() { menu });
    }
}
