// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using autoescola.Repository.Data;

namespace autoescola.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220523231339_AjusteAtivo")]
    partial class AjusteAtivo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("autoescola.Domain.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("HorarioId")
                        .HasColumnType("int")
                        .HasColumnName("horario_id");

                    b.Property<int>("InstrutorId")
                        .HasColumnType("int")
                        .HasColumnName("instrutor_id");

                    b.Property<int>("MatriculaId")
                        .HasColumnType("int")
                        .HasColumnName("matricula_id");

                    b.HasKey("Id")
                        .HasName("PK_agenda");

                    b.HasIndex("HorarioId");

                    b.HasIndex("InstrutorId");

                    b.HasIndex("MatriculaId");

                    b.ToTable("agenda");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("NomeMae")
                        .HasColumnType("longtext")
                        .HasColumnName("nome_mae");

                    b.Property<string>("NomePai")
                        .HasColumnType("longtext")
                        .HasColumnName("nome_pai");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int")
                        .HasColumnName("pessoa_id");

                    b.Property<string>("Profissao")
                        .HasColumnType("longtext")
                        .HasColumnName("profissao");

                    b.Property<string>("RG")
                        .HasColumnType("longtext")
                        .HasColumnName("rg");

                    b.HasKey("Id")
                        .HasName("PK_aluno");

                    b.HasIndex("PessoaId");

                    b.ToTable("aluno");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .HasColumnType("longtext")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext")
                        .HasColumnName("cidade");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext")
                        .HasColumnName("estado");

                    b.Property<string>("Logradouro")
                        .HasColumnType("longtext")
                        .HasColumnName("logradouro");

                    b.HasKey("Id")
                        .HasName("PK_enderco");

                    b.ToTable("endereco");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Frota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Ano")
                        .HasColumnType("int")
                        .HasColumnName("ano");

                    b.Property<string>("Cor")
                        .HasColumnType("longtext")
                        .HasColumnName("cor");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int")
                        .HasColumnName("marca_id");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext")
                        .HasColumnName("modelo");

                    b.Property<string>("Observacao")
                        .HasColumnType("longtext")
                        .HasColumnName("observacao");

                    b.Property<string>("Placa")
                        .HasColumnType("longtext")
                        .HasColumnName("placa");

                    b.HasKey("Id")
                        .HasName("PK_frota");

                    b.HasIndex("MarcaId");

                    b.ToTable("frota");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Horario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<double>("Inicio")
                        .HasColumnType("double")
                        .HasColumnName("inicio");

                    b.Property<double>("Termino")
                        .HasColumnType("double")
                        .HasColumnName("termino");

                    b.HasKey("Id")
                        .HasName("PK_horario");

                    b.ToTable("horario");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Instrutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int")
                        .HasColumnName("pessoa_id");

                    b.Property<int>("TurnoId")
                        .HasColumnType("int")
                        .HasColumnName("turno_id");

                    b.HasKey("Id")
                        .HasName("PK_instrutorW");

                    b.HasIndex("PessoaId");

                    b.HasIndex("TurnoId");

                    b.ToTable("instrutor");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.HasKey("Id")
                        .HasName("PK_marca");

                    b.ToTable("marca");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("AlunoId")
                        .HasColumnType("int")
                        .HasColumnName("aluno_id");

                    b.Property<int>("TipoHabilitacaoId")
                        .HasColumnType("int")
                        .HasColumnName("tipo_habilitacao_id");

                    b.HasKey("Id")
                        .HasName("PK_matricula");

                    b.HasIndex("AlunoId");

                    b.HasIndex("TipoHabilitacaoId");

                    b.ToTable("matricula");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int")
                        .HasColumnName("endereco_id");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("nascimento");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<string>("NumeroEndereco")
                        .HasColumnType("longtext")
                        .HasColumnName("numero_endereco");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("varchar(1)")
                        .HasColumnName("sexo");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext")
                        .HasColumnName("telefone");

                    b.HasKey("Id")
                        .HasName("PK_pessoa");

                    b.HasIndex("EnderecoId");

                    b.ToTable("pessoa");
                });

            modelBuilder.Entity("autoescola.Domain.Models.TipoHabilitacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.HasKey("Id")
                        .HasName("PK_tipo_habilitacao");

                    b.ToTable("tipo_habilitacao");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Turno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.HasKey("Id")
                        .HasName("PK_turno");

                    b.ToTable("turno");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ativo");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<int?>("PessoaId")
                        .HasColumnType("int")
                        .HasColumnName("pessoa_id");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext")
                        .HasColumnName("senha");

                    b.Property<int>("Tentativas")
                        .HasColumnType("int")
                        .HasColumnName("tentativas");

                    b.HasKey("Id")
                        .HasName("PK_usuario");

                    b.HasIndex("PessoaId");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Agenda", b =>
                {
                    b.HasOne("autoescola.Domain.Models.Horario", "Horario")
                        .WithMany("Agenda")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("autoescola.Domain.Models.Instrutor", "Instrutor")
                        .WithMany("Agenda")
                        .HasForeignKey("InstrutorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("autoescola.Domain.Models.Matricula", "Matricula")
                        .WithMany("Agenda")
                        .HasForeignKey("MatriculaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Horario");

                    b.Navigation("Instrutor");

                    b.Navigation("Matricula");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Aluno", b =>
                {
                    b.HasOne("autoescola.Domain.Models.Pessoa", "Pessoa")
                        .WithMany("Alunos")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Frota", b =>
                {
                    b.HasOne("autoescola.Domain.Models.Marca", "Marca")
                        .WithMany("Frotas")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Instrutor", b =>
                {
                    b.HasOne("autoescola.Domain.Models.Pessoa", "Pessoa")
                        .WithMany("Instrutores")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("autoescola.Domain.Models.Turno", "Turno")
                        .WithMany("Instrutores")
                        .HasForeignKey("TurnoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pessoa");

                    b.Navigation("Turno");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Matricula", b =>
                {
                    b.HasOne("autoescola.Domain.Models.Aluno", "Aluno")
                        .WithMany("Matriculas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("autoescola.Domain.Models.TipoHabilitacao", "TipoHabilitacao")
                        .WithMany("Matriculas")
                        .HasForeignKey("TipoHabilitacaoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("TipoHabilitacao");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Pessoa", b =>
                {
                    b.HasOne("autoescola.Domain.Models.Endereco", "Endereco")
                        .WithMany("Pessoas")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Usuario", b =>
                {
                    b.HasOne("autoescola.Domain.Models.Pessoa", "Pessoa")
                        .WithMany("Usuarios")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Aluno", b =>
                {
                    b.Navigation("Matriculas");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Endereco", b =>
                {
                    b.Navigation("Pessoas");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Horario", b =>
                {
                    b.Navigation("Agenda");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Instrutor", b =>
                {
                    b.Navigation("Agenda");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Marca", b =>
                {
                    b.Navigation("Frotas");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Matricula", b =>
                {
                    b.Navigation("Agenda");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Pessoa", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Instrutores");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("autoescola.Domain.Models.TipoHabilitacao", b =>
                {
                    b.Navigation("Matriculas");
                });

            modelBuilder.Entity("autoescola.Domain.Models.Turno", b =>
                {
                    b.Navigation("Instrutores");
                });
#pragma warning restore 612, 618
        }
    }
}
