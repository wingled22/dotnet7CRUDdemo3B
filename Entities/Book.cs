using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace newFolder.Entities;

public partial class Book
{
    public int Id { get; set; }

    [DisplayName("Enter Name")]
    [Required]
    public string? Name { get; set; }

    [DisplayName("Enter Author")]
    [MaxLength(5)]
    [Required]
    public string? Author { get; set; }
}
