using System;
using System.Linq;

namespace Gestao.dominio
{
    public class Turma : Entity
    {
        public int IdTurma { get; private set; }

        public string Descricao { get; private set;}
        public string Coordenador { get; private set; }


        private readonly List<Aluno> _aluno;
        public IReadOnlyCollection<Aluno> Alunos => _aluno;

        public int IdDisciplina { get; private set; }
        public Disciplina Disciplina { get; private set; }


        protected Turma() { }
        public Turma(string descricao, string coordenador)
        {
            _aluno= new List<Aluno>();

            SetDescricao(descricao);
            SetCoordenador(coordenador);

        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public void SetCoordenador(string coordenador)
        {
            Coordenador = coordenador;
        }
        public void SetAluno(Aluno aluno)
        {
            aluno.SetTurma(IdTurma);
            _aluno.Add(aluno);
        }

        public void RemoveAluno(int idAluno)
        {
            var a = _aluno.Where(x => x.Id == idAluno).SingleOrDefault();
            if(a != null)
            {
                _aluno.Remove(a);
            }
        }
        public void SetDisciplina(int id) => IdDisciplina = id;


    }
}
