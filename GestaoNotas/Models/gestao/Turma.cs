using System;
using System.Linq;

namespace GestaoNotas.gestao
{
    public class Turma
    {
        public int IdTurma { get; set; }
        public string Descricao { get; set; }
        public string Coordenador { get; set; }


        public readonly List<Aluno> _aluno;
        public IReadOnlyCollection<Aluno> Alunos => _aluno;


        public readonly List<Disciplina> _Disciplina;
        public IReadOnlyCollection<Disciplina> Disciplinas => _Disciplina;


        protected Turma() { }
        public Turma(string descricao, string coordenador)
        {
            _aluno = new List<Aluno>();
            _Disciplina = new List<Disciplina>();

            SetDescricao(descricao);
            SetCoordenador(coordenador);
        }

        public void SetDescricao(string descricao) => Descricao = descricao;

        public void SetCoordenador(string coordenador) => Coordenador = coordenador;

        public void AddAluno(Aluno aluno)
        {
            aluno.SetTurmaId(IdTurma);
            _aluno.Add(aluno);
        }

        public void RemoveAluno(int idAluno)
        {
            Aluno result = (Aluno)_aluno.Where(x => x.IdAluno == idAluno);

            if (result != null)
            {
                _aluno.Remove(result);
            }
        }

        public void AddDisciplina(Disciplina disciplina)
        {
            disciplina.SetTurma(IdTurma);
            _Disciplina.Add(disciplina);

        }

        public void RemoveDisciplina(Disciplina disciplina, int idDisciplina)
        {
            Disciplina result = _Disciplina.Find(x => x.IdDiciplina == disciplina.IdDiciplina);
            if (result != null)
            {
                _Disciplina.Remove(result);
            }
        }

    }
}
