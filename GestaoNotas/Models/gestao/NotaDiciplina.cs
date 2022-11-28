namespace GestaoNotas.gestao
{
    public class NotaDiciplina
    {
        public int IdNotaDiciplina { get; set; }
        public int Nota { get; set; }


        public readonly List<Aluno> _aluno;
        public IReadOnlyCollection<Aluno> Alunos => _aluno;

        public int IdDisciplina { get; set; }
        public Disciplina Disciplina { get; set; }


        public NotaDiciplina() { }
        public NotaDiciplina(Aluno aluno, Disciplina disciplina, int nota)
        {
            _aluno = new List<Aluno>();

            AddAluno(aluno);
            SetDisciplina(disciplina);
            SetNota(nota);
        }

        public void SetDisciplina(Disciplina disciplina) => IdDisciplina = disciplina.IdDiciplina;
        public void SetNota(int nota) => Nota = nota;
        public void SetDisciplinaId(int idDisciplina) => IdDisciplina = idDisciplina;

        public void AddAluno(Aluno aluno)
        {
            aluno.SetNotaId(IdNotaDiciplina);
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

    }
}
