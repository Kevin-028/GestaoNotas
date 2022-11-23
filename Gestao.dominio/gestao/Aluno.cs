//using System;
//using System.Linq;

//namespace Gestao.dominio
//{
//    public class Aluno : Entity
//    {
//        public int Id { get; set; }
//        public string? Nome { get; private set; }
//        public string? Email { get; private set; }
//        public string? Campus { get; private set; }
//        public string? Cpf { get; private set; }
//        public int? Telefone { get; private set; }
//        public int? RA { get; private set; }
//        public string? Sexo { get; private set; }
//        public string? Renda { get; private set; }
//        public string? Endereco { get; private set; }

//        public int? IdTurma { get; private set; }
//        public Turma Turma{ get; private set; }


//        protected Aluno() { }
//        public Aluno(string name,string email,string campus, string cpf, int telefone, int ra, string sexo, string renda, string endereco)
//        {
//            SetName(name);
//            SetEmail(email);
//            SetCampus(campus);
//            SetCPF(cpf); 
//            SetTelefone(telefone);
//            SetRA(ra);
//            SetSexo(sexo);
//            SetEndereco(endereco);
//        }
//        public void SetTurma(int idTurma) => IdTurma = idTurma; 

//        public void SetName(string name)
//        {
//            Nome = name;
//        }
//        public void SetEmail(string email)
//        {
//            Email = email;
//        }
//        public void SetCampus(string campus)
//        {
//            Campus = campus;
//        }
//        public void SetCPF(string cpf)
//        {
//            Cpf = cpf;
//        }
//        public void SetTelefone(int telefone)
//        {
//            Telefone = telefone;
//        }
//        public void SetRA(int ra)
//        {
//            RA = ra;
//        }
//        public void SetSexo(string sexo)
//        {
//            Sexo = sexo;
//        }
//        public void SetRenda(string renda)
//        {
//            Renda = renda;
//        }
//        public void SetEndereco(string endereco)
//        {
//            Endereco = endereco;
//        }


//    }
//}
