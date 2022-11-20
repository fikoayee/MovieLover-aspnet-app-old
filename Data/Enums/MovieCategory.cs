using System.ComponentModel.DataAnnotations;

namespace MovieLover.Data.Enums
{
    public enum MovieCategory
    {
        Action = 1,
        Adventure,
        Comedy,
        Drama,
        Horror,
        Romance,
        [Display(Name = "Science Fiction")]
        Sciencefiction,
        Fantasy,
        Historical,
        Crime,
        Documentary,
        [Display(Name = "For Kids")]
        ForKids
    }
}
