using Microsoft.EntityFrameworkCore.Migrations;

namespace autoescola.Repository.Migrations
{
    public partial class AjusteUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_aluno_pessoa_PessoaId",
                table: "aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_instrutor_pessoa_PessoaId",
                table: "instrutor");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "instrutor",
                newName: "pessoa_id");

            migrationBuilder.RenameIndex(
                name: "IX_instrutor_PessoaId",
                table: "instrutor",
                newName: "IX_instrutor_pessoa_id");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "aluno",
                newName: "pessoa_id");

            migrationBuilder.RenameIndex(
                name: "IX_aluno_PessoaId",
                table: "aluno",
                newName: "IX_aluno_pessoa_id");

            migrationBuilder.AddColumn<int>(
                name: "ativo",
                table: "usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tentativas",
                table: "usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_aluno_pessoa_pessoa_id",
                table: "aluno",
                column: "pessoa_id",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_instrutor_pessoa_pessoa_id",
                table: "instrutor",
                column: "pessoa_id",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_aluno_pessoa_pessoa_id",
                table: "aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_instrutor_pessoa_pessoa_id",
                table: "instrutor");

            migrationBuilder.DropColumn(
                name: "ativo",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "tentativas",
                table: "usuario");

            migrationBuilder.RenameColumn(
                name: "pessoa_id",
                table: "instrutor",
                newName: "PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_instrutor_pessoa_id",
                table: "instrutor",
                newName: "IX_instrutor_PessoaId");

            migrationBuilder.RenameColumn(
                name: "pessoa_id",
                table: "aluno",
                newName: "PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_aluno_pessoa_id",
                table: "aluno",
                newName: "IX_aluno_PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_aluno_pessoa_PessoaId",
                table: "aluno",
                column: "PessoaId",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_instrutor_pessoa_PessoaId",
                table: "instrutor",
                column: "PessoaId",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
