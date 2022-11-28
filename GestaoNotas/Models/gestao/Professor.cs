using System;
using System.Linq;

namespace GestaoNotas.gestao
{
    public class Professor
    {
        public int IdProfessor { get; private set; }

        public string Campus { get; private set; }
        public string Nome { get; private set; }


        public readonly List<Disciplina> _disciplina;
        public IReadOnlyCollection<Disciplina> Disciplina => _disciplina;


        public Professor() { }

        public Professor(string campus, string nome)
        {
            SetCampus(campus);
            SetNome(nome);
        }
        public void SetCampus(string campus)
        {
            Campus = campus;

        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetDisciplina(Disciplina disciplina)
        {
            if (!_disciplina.Any(x => x.NomeDiciplina == disciplina.NomeDiciplina))
            {
                _disciplina.Add(disciplina);
            }
        }
        //public void RemoveDisciplina(Disciplina disciplina, int idDisciplina)
        //{
        //    Disciplina result = _disciplina.Find(delegate(Disciplina a) { return a.IdDiciplina == idDisciplina; });
        //    if (result != null)
        //    {
        //        _disciplina.Remove(result);
        //    }
        //}

    }
}
