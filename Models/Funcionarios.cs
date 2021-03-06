using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalWebPontoCertificado.Models
{
    [Table("Funcionarios")]
    public class Funcionarios
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome do Funcionário")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Column("CPF")]
        public string CPF { get; set; }

        [Display(Name = "Gênero")]
        [Column("Genero")]
        public string Genero { get; set; }

        [Display(Name = "PIS")]
        [Column("PIS")]
        public string PIS { get; set; }

        [Display(Name = "Salário (R$)")]
        [Column("Salario")]
        public double Salario { get; set; }

        [Display(Name = "E-mail")]
        [Column("E-mail")]
        public string Email { get; set; }

        [Display(Name = "Data de Admissão")]
        [Column("Data de Admissão")]
        public string DataAdmissao { get; set; }
    }
}
