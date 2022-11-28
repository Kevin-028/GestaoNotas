using GestaoNotas.gestao;
using System.ComponentModel.DataAnnotations;

namespace GestaoNotas.Models.ViewModel
{
    public class alunoViewModel
    {
        [Display(Name = "RA")]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Campus { get; set; }
        public string Cpf { get; set; }
        public int Telefone { get; set; }
        public int RA { get; set; }
        public string Sexo { get; set; }
        public string Renda { get; set; }
        public string Endereco { get; set; }


        public int IdTurma { get; set; }
        public int IdNotaDiciplina { get; set; }

    }
}
