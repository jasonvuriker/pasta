namespace pasta.Dtos;

public class CreateFoodDto
{
    public int MenuId { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public float Size { get; set; }

    public string Description { get; set; }
}
