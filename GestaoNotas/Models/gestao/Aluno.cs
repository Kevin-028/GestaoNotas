using System;
using System.Linq;

namespace GestaoNotas.gestao
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Campus { get; set; }
        public string Cpf { get; set; }
        public int Telefone { get; set; }
        public int RA { get; set; }
        public string Sexo { get; set; }
        public string Renda { get; set; }
        public string Endereco { get; set; }

        public int? IdTurma { get; set; }






        public Turma Turma { get; set; }

        public int? IdNotaDisciplina { get; set; }
        public NotaDiciplina NotaDisciplina { get; set; }


        public Aluno() { }
        public Aluno(string name, string email, string campus, string cpf, int telefone, string sexo, string endereco, string renda)
        {
            SetName(name);
            SetEmail(email);
            SetCampus(campus);
            SetSexo(sexo);
            SetCampus(campus);
            SetCPF(cpf);
            SetEndereco(endereco);
            SetTelefone(telefone);
            SetRenda(renda);
        }

        public void SetName(string name) => Nome = name;
        public void SetEmail(string email) => Email = email;
        public void SetCampus(string campus) => Campus = campus;
        public void SetCPF(string cpf) => Cpf = cpf;
        public void SetTelefone(int telefone) => Telefone = telefone;
        public void SetRA(int ra) => RA = ra;
        public void SetSexo(string sexo) => Sexo = sexo;
        public void SetRenda(string renda) => Renda = renda;
        public void SetEndereco(string endereco) => Endereco = endereco;
        public void SetTurmaId(int turmaId) => IdTurma = turmaId;
        public void SetNotaId(int idnota) => IdNotaDisciplina = idnota;

    }
}
