using System;
using System.Linq;

namespace Gestao.dominio
{
    public class Turma
    {
        public int IdTurma { get; private set; }
        public int IdDiciplina { get; private set; }

        public string Descricao { get; private set;}
        public string Coordenador { get; private set; }

        

        //private readonly List<Aluno> _aluno;
        //public IReadOnlyCollection<Aluno> Alunos => _aluno;


        //private readonly List<Disciplina> _Disciplina;
        //public IReadOnlyCollection<Disciplina> Disciplinas => _Disciplina;


        protected Turma() { }
        public Turma(string descricao, string coordenador)
        {
            //_aluno = new List<Aluno>();

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
        //public void SetAluno(Aluno aluno)
        //{
        //    aluno.SetTurma(IdTurma);

        //    _aluno.Add(aluno);
        //}

        //public void RemoveAluno(int idAluno)
        //{
        //    var a = _aluno.Where(x => x.IdTurma == idAluno).SingleOrDefault();
        //    if(a != null)
        //    {
        //        _aluno.Remove(a);
        //    }
        //}     
        
        //public void SetDisciplina(Disciplina disciplina)
        //{
        //    disciplina.SetDisciplina(IdDiciplina);

        //    _Disciplina.Add(disciplina);
        //}

        //public void RemoveDisciplina(int idDisciplina)
        //{
        //    var a = _Disciplina.Where(x => x.IdDiciplina == idDisciplina).SingleOrDefault();
        //    if(a != null)
        //    {
        //        _Disciplina.Remove(a);
        //    }
        //}

    }
}
