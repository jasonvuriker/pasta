namespace pasta.Dtos;

public class MenuDto
{
    public string Name { get; set; }

    public IList<FoodDto> Foods { get; set; }

    public Season Season { get; set; }
}

public enum Season
{
    Spring,
    Fall,
}