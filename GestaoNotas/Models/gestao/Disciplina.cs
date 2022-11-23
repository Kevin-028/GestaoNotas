using System;
using System.Linq;

namespace Gestao.dominio
{
    public class Disciplina
    {
        public int IdDiciplina { get; private set; }
        public int IdProfessor { get; private set; }


        public string NomeDiciplina { get; private set; }
        public int Nota { get; private set; }
        public string DataAvaliacao { get; private set; }

        public int IdProf { get; private set; }
        public int idTurma { get; private set; }

        protected Disciplina() { }

        public Disciplina(int idProf, string nomeDiciplina, int notas, string dataAvaliacao)
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
        public void SetNota(int nota)
        {
            Nota = nota;
        }
        public void SetAvaliacao(string dataAvaliacao)
        {
            DataAvaliacao = dataAvaliacao;

        }
        public void SetDisciplina(int idDiciplina) => IdDiciplina = idDiciplina;

    }
}
