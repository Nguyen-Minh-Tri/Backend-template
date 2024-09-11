using System.ComponentModel.DataAnnotations;

namespace BackendTemplate.DataAccess;

public class User : BaseEntity
{
    [Required]
    public string Name { get; set; }

    [Required]
    public int Age { get; set; }
}
