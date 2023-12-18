using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mygame.Client.Models;

public class Game
{
    public int Id { get; set; }
    [Required]
    public required string Name { get; set; }
    [Required]
    public required string Genre { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public DateTime ReleaseDate { get; set; }
}