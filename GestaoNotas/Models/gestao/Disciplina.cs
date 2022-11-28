using System;
using System.Linq;

namespace GestaoNotas.gestao
{
    public class Disciplina
    {
        public int IdDiciplina { get; set; }
        public string NomeDiciplina { get; set; }
        public string DataAvaliacao { get; set; }

        public int IdTurma { get; set; }
        public Turma Turma { get; set; }

        public int IdProfessor { get; set; }
        public Professor Professor { get; set; }


        public readonly List<NotaDiciplina> _nota;
        public IReadOnlyCollection<NotaDiciplina> NotaDiciplinas => _nota;



        public Disciplina() { }
        public Disciplina(string nome, string dataAvaliacao, Professor professor)
        {
            SetNomeDiciplina(nome);
            SetAvaliacao(dataAvaliacao);
            SetProf(professor);
        }

        public void SetProf(Professor professor) => IdProfessor = professor.IdProfessor;
        public void SetTurma(int idTurma) => IdTurma = idTurma;
        public void SetNomeDiciplina(string nome) => NomeDiciplina = nome;
        public void SetAvaliacao(string dataAvaliacao) => DataAvaliacao = dataAvaliacao;
        public void SetDisciplina(int idDiciplina) => IdDiciplina = idDiciplina;
        public void AddNota(NotaDiciplina nota)
        {
            nota.SetDisciplinaId(IdDiciplina);
            _nota.Add(nota);
        }

        public void RemoveNota(int idNota)
        {
            NotaDiciplina result = (NotaDiciplina)_nota.Where(x => x.IdNotaDiciplina == idNota);

            if (result != null)
            {
                _nota.Remove(result);
            }
        }
    }
}
