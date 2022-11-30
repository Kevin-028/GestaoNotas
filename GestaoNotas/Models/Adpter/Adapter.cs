using GestaoNotas.gestao;
using GestaoNotas.Models.ViewModel;

namespace GestaoNotas.Models.Adpter
{
    public static class Adapter
    {
        public static Aluno ToAluno(alunoViewModel aluno)
        {
            return new Aluno
            {
                IdAluno = aluno.IdAluno,
                Nome = aluno.Nome,
                Email = aluno.Email,
                Campus = aluno.Campus,
                Cpf = aluno.Cpf,
                Telefone = aluno.Telefone,
                RA = aluno.RA,
                Sexo = aluno.Sexo,
                Renda = aluno.Renda,
                Endereco = aluno.Endereco,
            };
        }

        public static alunoViewModel  ToAlunoViewModel(Aluno aluno)
        {
            return new alunoViewModel
            {
                Nome = aluno.Nome,
                Email = aluno.Email,
                Campus = aluno.Campus,
                Cpf = aluno.Cpf,
                Telefone = aluno.Telefone,
                RA = aluno.RA,
                Sexo = aluno.Sexo,
                Renda = aluno.Renda,
                Endereco = aluno.Endereco,
            };
        }
        public static Professor ToProf(ProfViewModel prof)
        {
            return new Professor
            {
                IdProfessor = prof.IdProfessor,
                Campus = prof.Campus,
                Nome = prof.Nome,
            };
        }   
        public static Turma ToTurma(TurmaViewModel turma)
        {
            return new Turma
            {
                IdTurma = turma.IdTurma,
                Descricao = turma.Descricao,
                Coordenador = turma.Coordenador,
            };
        }   
        public static Disciplina ToDisciplina(DisciplicaViewModel disciplina)
        {
            return new Disciplina
            {
                IdTurma = disciplina.IdTurma,
                IdDisciplina = disciplina.IdDiciplina,
                IdProfessor = disciplina.IdProfessor,
                NomeDisciplina = disciplina.NomeDiciplina,
                DataAvaliacao = disciplina.DataAvaliacao,
            };
        }    
        public static Aluno ToNewTurmaAluno(AddTurmaAlunoViewModel addTurmaAlunoViewModel)
        {
            return new Aluno
            {
                IdTurma = addTurmaAlunoViewModel.IdTurma,
                IdAluno = addTurmaAlunoViewModel.IdAluno

            };
        }   
        public static Login Tologin(LoginViewModel login)
        {
            return new Login
            {
                Email = login.Email,
                Senha = login.Senha,
                perfil = login.perfil
                
            };
        }
        


        
    }
}
