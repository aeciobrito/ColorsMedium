using ColorsMedium.WebApi.Models;

namespace ColorsMedium.WebApi.Repositories
{
    public static class ColorsRepository
    {
        public static List<Color> GetAll() => new List<Color>()
            {
                new Color { Id = 1, Name = "Red"},
                new Color { Id = 2, Name = "Black" },
                new Color { Id = 3, Name = "Pink" },
                new Color { Id = 4, Name = "Green" },
                new Color { Id = 5, Name = "Gray" }
            };
    }
}