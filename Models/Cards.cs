using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalUnique
{

    public class Card
    {
    public int CardID {get; set;}
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string CardName {get; set;}
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string CardColor {get; set;}
    [Range(1,100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal CardPrice {get; set;}
    [StringLength(5)]
    [Required]
    public string Rarity {get; set;}
    [StringLength(60, MinimumLength = 3)]
    [Required]public string 
    ExspansionName {get; set;}
    }
    
    public class Exspansion
{
    public int ExspansionSetID {get; set;}
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string ExspansionName {get; set;}
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate {get; set;}
}
}