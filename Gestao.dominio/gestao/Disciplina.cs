using System;
using System.Linq;

namespace Gestao.dominio
{
    public class Disciplina : Entity
    {
        public int IdDiciplina { get; private set; }
        public string NomeDiciplina { get; private set; }
        public decimal Nota { get; private set; }
        public string DataAvaliacao { get; private set; }

        public int IdProf { get; private set; }
        public Professor Professor { get; private set; }


        private readonly List<Turma> _turma;
        public IReadOnlyCollection<Turma> Turmas => _turma;




        protected Disciplina() { }
        public Disciplina(int idDiciplina, int idProf, string nomeDiciplina, decimal notas, string dataAvaliacao)
        {
            SetNomeDiciplina(nomeDiciplina);
            SetNota(notas);
            SetAvaliacao(dataAvaliacao);
        }

        public void SetProf(int idProf) => IdProf = idProf;

        public void SetNomeDiciplina(string nome)
        {
            NomeDiciplina = nome;
        }
        public void SetNota(decimal nota)
        {
            Nota = nota;
        }
        public void SetAvaliacao(string dataAvaliacao)
        {
            DataAvaliacao = dataAvaliacao;

        }

        public void SetTurma(Turma turma)
        {
            turma.SetDisciplina(IdDiciplina);
            _turma.Add(turma);
        }
        public void RemoveTurma(int idTurma)
        {
            var a = _turma.Where(x => x.IdTurma == idTurma).SingleOrDefault();
            if (a != null)
            {
                _turma.Remove(a);
            }
        }



    }
}
