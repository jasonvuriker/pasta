using pasta.Dtos;
using Swashbuckle.AspNetCore.Filters;

namespace pasta.Examples;

public class GetMenuExample : IExamplesProvider<IList<MenuDto>>
{
    public IList<MenuDto> GetExamples()
    {
        return
        [
            new MenuDto()
            {
                Name = "Food menu",
                Season = Season.Spring,
                Foods = new List<FoodDto>()
                {
                    new()
                    {
                        Id = 1,
                        Name = "Spaghetti",
                        Price = 12.99m,
                        Size = 1.5f,

                    }

                }
            }
        ];
    }
}
