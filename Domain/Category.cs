using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Category: BaseEntity
{
    public string Name { get; set; }
}