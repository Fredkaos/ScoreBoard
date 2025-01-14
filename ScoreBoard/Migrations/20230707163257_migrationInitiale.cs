﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScoreBoard.Migrations
{
    /// <inheritdoc />
    public partial class migrationInitiale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Joueurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Equipe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Courriel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joueurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jeu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSortie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoueurId = table.Column<int>(type: "int", nullable: false),
                    ScoreJoueur = table.Column<int>(type: "int", nullable: false),
                    DateEnregistrement = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jeu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jeu_Joueurs_JoueurId",
                        column: x => x.JoueurId,
                        principalTable: "Joueurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jeu_JoueurId",
                table: "Jeu",
                column: "JoueurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jeu");

            migrationBuilder.DropTable(
                name: "Joueurs");
        }
    }
}
