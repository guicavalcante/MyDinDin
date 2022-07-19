using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDinDin.Models;

public class Expenses
{
    [Required]
    public int Id { get; set; }
    [Required]
    [Column(TypeName = "varchar(255)")]
    public string Descripition { get; set; }
    [Required]
    public double Value { get; set; }
    [Required]
    public DateTime Time { get; set; }

    // PROPRIEDADE DE NAVEGAÇÃO 
    public User User { get; set; }
    public Categories Category { get; set; }

    // PROPPRIEDADE DE CHAVE ESTRANGEIRA 
    // NOMEADA USANDO CONVENÇÃO - CLASSEID
    [Required]
    public int UserId { get; set; }
    [Required]
    public int CategoriesId { get; set; }
}
