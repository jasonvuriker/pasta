using pasta.Dtos;
using Swashbuckle.AspNetCore.Filters;

namespace pasta.Examples;

public class CreateFoodExample : IExamplesProvider<CreateFoodDto>
{
    public CreateFoodDto GetExamples()
    {
        return new CreateFoodDto()
        {
            Name = "Spaghetti",
            Price = 12.99m,
            Size = 1.5f,
            Description = "A classic Italian pasta dish with tomato sauce and meatballs.",
            MenuId = 1
        };
    }
}

public class GetFoodExample : IExamplesProvider<FoodDto>
{
    public FoodDto GetExamples()
    {
        return new()
        {
            Name = "Spaghetti",
            Price = 12.99m,
            Size = 1.5f,
            Description = "A classic Italian pasta dish with tomato sauce and meatballs.",
            Id = 1
        };
    }
}