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
                IdAluno = aluno.Id,
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
                Id = aluno.IdAluno,
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
    }
}
