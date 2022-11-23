﻿using System;
using System.Linq;

namespace Gestao.dominio
{
    public class Professor 
    {
        public  int IdProf { get; private set; }
        public int IdDiciplina { get; private set; }

        public string Campus { get; private set; }
        public string Nome { get; private set; }


        //private readonly List<Disciplina> _disciplina;
        //public IReadOnlyCollection<Disciplina> Disciplinas => _disciplina;


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

        //public void SetDisciplina(Disciplina disciplina)
        //{
        //    disciplina.SetProf(IdProf);

        //    _disciplina.Add(disciplina);
        //}

        //public void RemoveDisciplina(int idDisciplina)
        //{
        //    var a = _disciplina.Where(x => x.IdDiciplina == idDisciplina).SingleOrDefault();
        //    if (a != null)
        //    {
        //        _disciplina.Remove(a);
        //    }
        //}

    }
}
