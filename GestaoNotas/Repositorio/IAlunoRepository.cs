using Gestao.dominio;

namespace GestaoNotas.Repositorio
{
    public interface IAlunoRepository
    {
        List<Aluno> GetAll();

        Aluno adcionar(Aluno aluno);

    }
}
