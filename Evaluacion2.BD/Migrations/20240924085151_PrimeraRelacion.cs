using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Evaluacion2.BD.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraRelacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Optometristas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Disponible",
                table: "Disponibilidad",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Disponibilidad",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Horarios",
                table: "Disponibilidad",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OptometristaId",
                table: "Disponibilidad",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisponibilidadId",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Citas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Citas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Hora",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Optometristas_PersonaId",
                table: "Optometristas",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilidad_OptometristaId",
                table: "Disponibilidad",
                column: "OptometristaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PersonaId",
                table: "Clientes",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_ClienteId",
                table: "Citas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_DisponibilidadId",
                table: "Citas",
                column: "DisponibilidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Clientes_ClienteId",
                table: "Citas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Disponibilidad_DisponibilidadId",
                table: "Citas",
                column: "DisponibilidadId",
                principalTable: "Disponibilidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Personas_PersonaId",
                table: "Clientes",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disponibilidad_Optometristas_OptometristaId",
                table: "Disponibilidad",
                column: "OptometristaId",
                principalTable: "Optometristas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Optometristas_Personas_PersonaId",
                table: "Optometristas",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Clientes_ClienteId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Disponibilidad_DisponibilidadId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Personas_PersonaId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Disponibilidad_Optometristas_OptometristaId",
                table: "Disponibilidad");

            migrationBuilder.DropForeignKey(
                name: "FK_Optometristas_Personas_PersonaId",
                table: "Optometristas");

            migrationBuilder.DropIndex(
                name: "IX_Optometristas_PersonaId",
                table: "Optometristas");

            migrationBuilder.DropIndex(
                name: "IX_Disponibilidad_OptometristaId",
                table: "Disponibilidad");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_PersonaId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Citas_ClienteId",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_DisponibilidadId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Optometristas");

            migrationBuilder.DropColumn(
                name: "Disponible",
                table: "Disponibilidad");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Disponibilidad");

            migrationBuilder.DropColumn(
                name: "Horarios",
                table: "Disponibilidad");

            migrationBuilder.DropColumn(
                name: "OptometristaId",
                table: "Disponibilidad");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "DisponibilidadId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Citas");
        }
    }
}
