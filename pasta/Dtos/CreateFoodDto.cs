using Swashbuckle.AspNetCore.Annotations;

namespace pasta.Dtos;

public class CreateFoodDto
{
    [SwaggerSchema("The menu identifier", ReadOnly = true)]
    public int MenuId { get; set; }

    [SwaggerSchema("The food name")]
    public string Name { get; set; }

    public decimal Price { get; set; }

    public float Size { get; set; }

    public string Description { get; set; }
}
