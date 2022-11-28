﻿// <auto-generated />
using GestaoNotas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoNotas.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20221127023608_1")]
    partial class _1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gestao.dominio.Aluno", b =>
                {
                    b.Property<int>("IdAluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAluno"));

                    b.Property<string>("Campus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdNotaDiciplina")
                        .HasColumnType("int");

                    b.Property<int>("IdTurma")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RA")
                        .HasColumnType("int");

                    b.Property<string>("Renda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("IdAluno");

                    b.HasIndex("IdNotaDiciplina");

                    b.HasIndex("IdTurma");

                    b.ToTable("Gestao_Alunos", (string)null);
                });

            modelBuilder.Entity("Gestao.dominio.Disciplina", b =>
                {
                    b.Property<int>("IdDiciplina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDiciplina"));

                    b.Property<string>("DataAvaliacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdProfessor")
                        .HasColumnType("int");

                    b.Property<int>("IdTurma")
                        .HasColumnType("int");

                    b.Property<string>("NomeDiciplina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfessorIdProfessor")
                        .HasColumnType("int");

                    b.HasKey("IdDiciplina");

                    b.HasIndex("IdTurma");

                    b.HasIndex("ProfessorIdProfessor");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("Gestao.dominio.NotaDiciplina", b =>
                {
                    b.Property<int>("IdNotaDiciplina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNotaDiciplina"));

                    b.Property<int>("IdDisciplina")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("IdNotaDiciplina");

                    b.HasIndex("IdDisciplina");

                    b.ToTable("Notas", (string)null);
                });

            modelBuilder.Entity("Gestao.dominio.Professor", b =>
                {
                    b.Property<int>("IdProfessor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProfessor"));

                    b.Property<string>("Campus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProfessor");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Gestao.dominio.Turma", b =>
                {
                    b.Property<int>("IdTurma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTurma"));

                    b.Property<string>("Coordenador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTurma");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("Gestao.dominio.Aluno", b =>
                {
                    b.HasOne("Gestao.dominio.NotaDiciplina", "NotaDiciplina")
                        .WithMany("Alunos")
                        .HasForeignKey("IdNotaDiciplina")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestao.dominio.Turma", "Turma")
                        .WithMany("Alunos")
                        .HasForeignKey("IdTurma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDiciplina");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("Gestao.dominio.Disciplina", b =>
                {
                    b.HasOne("Gestao.dominio.Turma", "Turma")
                        .WithMany("Disciplinas")
                        .HasForeignKey("IdTurma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestao.dominio.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorIdProfessor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("Gestao.dominio.NotaDiciplina", b =>
                {
                    b.HasOne("Gestao.dominio.Disciplina", "Disciplina")
                        .WithMany("NotaDiciplinas")
                        .HasForeignKey("IdDisciplina")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("Gestao.dominio.Disciplina", b =>
                {
                    b.Navigation("NotaDiciplinas");
                });

            modelBuilder.Entity("Gestao.dominio.NotaDiciplina", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("Gestao.dominio.Professor", b =>
                {
                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("Gestao.dominio.Turma", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}
