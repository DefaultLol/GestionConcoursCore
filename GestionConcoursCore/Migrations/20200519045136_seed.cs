using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionConcoursCore.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Candidats",
                columns: new[] { "Cne", "Admis", "Adresse", "Cin", "Conforme", "Convoque", "DateInscription", "DateNaissance", "Email", "Gsm", "ID", "LieuNaissance", "Matricule", "Nationalite", "Niveau", "Nom", "NotePreselec", "Num_dossier", "Password", "Photo", "Prenom", "Presence", "Sexe", "Telephone", "Verified", "Ville", "listDatt" },
                values: new object[,]
                {
                    { "R147778136", false, null, "BL146789", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 824, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "zineb.khalis@gmail.com", null, 1, null, "A123", "Marocaine", 3, "Khalis", 0.0, 0, "test", null, "Zineb", false, "Femme", null, 1, "Casablanca", false },
                    { "R45698310", false, null, "BE890936", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "imane.abdennour@gmail.com", null, 1, null, "A89700", "Marocaine", 3, "Abdennour", 0.0, 0, "test", null, "Imane", false, "Femme", null, 1, "Casablanca", false },
                    { "R264797", false, null, "BL7946", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "yassin97@gmail.com", null, 1, null, "A89710", "Marocaine", 3, "Zineddine", 0.0, 451, "test", null, "Ayoub", true, "Homme", null, 1, "Casablanca", false },
                    { "R98567893", false, null, "BE74546", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "hicham@gmail.com", null, 1, null, "A89720", "Marocain", 3, "Ouhamou", 0.0, 452, "test", null, "Tarik", true, "Homme", null, 1, "Agadir", false },
                    { "R14078593", false, null, "BL144243", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "abdelkarim@gmail.com", null, 1, null, "A89730", "Marocaine", 3, "Kfifat", 0.0, 453, "test", null, "Abir", true, "Femme", null, 1, "Essaouira", false },
                    { "R1478562", false, null, "BE144894", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "yasmin@gmail.com", null, 2, null, "A89740", "Marocaine", 3, "Khorchaly", 0.0, 454, "test", null, "Imane", true, "Femme", null, 1, "Casablanca", false },
                    { "R14456325", false, null, "BL185895", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "ousama@gmail.com", null, 2, null, "A89750", "Marocaine", 3, "Dariaoui", 0.0, 455, "test", null, "Oussama", true, "homme", null, 1, "Casablanca", false },
                    { "R96341839", false, null, "BL145996", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "yasmine@gmail.com", null, 2, null, "A89760", "Marocaine", 3, "bakhta", 0.0, 456, "test", null, "yasmin", true, "femme", null, 1, "Casablanca", false },
                    { "R14128897", false, null, "BL157890", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "zineb@gmail.com", null, 2, null, "A89770", "Marocaine", 3, "Khalis", 0.0, 457, "test", null, "zineb", true, "femme", null, 1, "Casablanca", false },
                    { "R14777313", false, null, "BL144810", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "salim@gmail.com", null, 2, null, "A89790", "Marocaine", 3, "salim", 0.0, 459, "test", null, "yahya", true, "homme", null, 1, "Casablanca", false },
                    { "R14778001", false, null, "BL148901", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "amina@gmail.com", null, 2, null, "A89810", "Marocaine", 3, "amina", 0.0, 461, "test", null, "anahcham", true, "femme", null, 1, "Casablanca", false },
                    { "R14777891", false, null, "BL144891", false, false, new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), new DateTime(2020, 5, 19, 4, 51, 35, 825, DateTimeKind.Local), "nisrin@gmail.com", null, 1, null, "A8971", "Marocaine", 3, "Moutrib", 0.0, 151, "test", null, "Nissrin", true, "femme", null, 1, "Casablanca", false }
                });

            migrationBuilder.InsertData(
                table: "AnneeUniversitaires",
                columns: new[] { "Cne", "AnneUni1", "AnneUni2", "AnneUni3", "Redoublant1", "Redoublant2", "Redoublant3", "Semestre1", "Semestre2", "Semestre3", "Semestre4", "Semestre5", "Semestre6" },
                values: new object[,]
                {
                    { "R147778136", "2016", "2017", null, "Non", "Non", "Non", 14.2, 14.8, 15.0, 17.0, 0.0, 0.0 },
                    { "R14128897", "2016", "2017", null, "Non", "Non", "Non", 13.6, 15.9, 16.9, 14.8, 0.0, 0.0 },
                    { "R14078593", "2016", "2017", null, "Non", "Non", "Non", 16.3, 13.9, 14.6, 15.9, 0.0, 0.0 },
                    { "R14456325", "2016", "2017", null, "Non", "Non", "Non", 12.5, 13.9, 14.9, 15.9, 16.9, 16.9 },
                    { "R98567893", "2016", "2017", null, "Non", "Non", "Non", 14.3, 14.9, 15.6, 15.5, 17.6, 15.5 },
                    { "R14777891", "2016", "2017", null, "Non", "Non", "Non", 14.6, 14.8, 15.0, 14.5, 0.0, 0.0 },
                    { "R1478562", "2016", "2017", null, "Non", "Non", "Non", 14.5, 14.9, 14.7, 14.9, 0.0, 0.0 },
                    { "R264797", "2016", "2017", null, "Non", "Non", "Non", 15.6, 16.8, 15.0, 14.5, 17.0, 14.5 },
                    { "R14778001", "2016", "2017", null, "Non", "Non", "Non", 14.8, 16.9, 14.6, 14.7, 0.0, 0.0 },
                    { "R96341839", "2016", "2017", null, "Non", "Non", "Non", 13.5, 14.9, 15.9, 16.9, 0.0, 0.0 },
                    { "R45698310", "2016", "2017", null, "Non", "Non", "Non", 15.3, 14.5, 16.0, 16.5, 0.0, 0.0 },
                    { "R14777313", "2016", "2017", null, "Non", "Non", "Non", 13.8, 16.8, 15.6, 14.8, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Baccalaureats",
                columns: new[] { "Cne", "DateObtentionBac", "MentionBac", "NoteBac", "TypeBac" },
                values: new object[,]
                {
                    { "R14777891", "2016", "Bien", 16.0, "SMA" },
                    { "R14128897", "2016", "Bien", 15.0, "SMA" },
                    { "R147778136", "2016", "Bien", 16.0, "SMA" },
                    { "R14078593", "2016", "Bien", 17.0, "SMA" },
                    { "R14778001", "2016", "Bien", 15.0, "SMA" },
                    { "R96341839", "2016", "Bien", 15.0, "SMA" },
                    { "R14777313", "2016", "Bien", 15.0, "SMA" },
                    { "R45698310", "2015", "Bien", 16.0, "SMA" },
                    { "R14456325", "2016", "Bien", 16.0, "SMB" },
                    { "R264797", "2016", "Bien", 16.0, "SMA" },
                    { "R98567893", "2016", "Bien", 16.0, "SMA" },
                    { "R1478562", "2016", "Bien", 16.0, "SMA" }
                });

            migrationBuilder.InsertData(
                table: "CouncourEcrits",
                columns: new[] { "Cne", "NoteGenerale", "NoteMath", "NoteSpecialite" },
                values: new object[,]
                {
                    { "R14778001", 0.0, 15.0, 14.6 },
                    { "R14456325", 0.0, 16.0, 16.0 },
                    { "R1478562", 0.0, 14.0, 14.0 },
                    { "R96341839", 0.0, 14.0, 14.0 },
                    { "R14078593", 0.0, 15.0, 14.0 },
                    { "R14128897", 0.0, 15.0, 14.6 },
                    { "R98567893", 0.0, 15.0, 16.0 },
                    { "R264797", 0.0, 17.0, 16.0 },
                    { "R45698310", 0.0, 15.0, 15.5 },
                    { "R14777891", 0.0, 14.0, 16.0 },
                    { "R147778136", 0.0, 15.0, 15.5 },
                    { "R14777313", 0.0, 15.0, 14.6 }
                });

            migrationBuilder.InsertData(
                table: "CouncourOrals",
                columns: new[] { "Cne", "Classement" },
                values: new object[,]
                {
                    { "R96341839", 0 },
                    { "R14128897", 0 },
                    { "R14778001", 0 },
                    { "R14777891", 0 },
                    { "R1478562", 0 },
                    { "R14078593", 0 },
                    { "R98567893", 0 },
                    { "R264797", 0 },
                    { "R45698310", 0 },
                    { "R147778136", 0 },
                    { "R14456325", 0 },
                    { "R14777313", 0 }
                });

            migrationBuilder.InsertData(
                table: "Diplomes",
                columns: new[] { "Cne", "Etablissement", "NoteDiplome", "Specialite", "Type", "VilleObtention" },
                values: new object[,]
                {
                    { "R14778001", "EST", 15.4, "chimie", "DUT", "casablanca" },
                    { "R1478562", "EST", 16.5, "Reseau", "DUT", "mohamadia" },
                    { "R14128897", "EST", 15.4, "gtr", "DUT", "casablanca" },
                    { "R96341839", "EST", 16.5, "mecanique", "DUT", "casablanca" },
                    { "R14456325", "EST", 15.5, "Reseau", "Lic.pro-DUT", "settat" },
                    { "R14078593", "EST", 15.0, "Reseau", "DUT", "mohamadia" },
                    { "R98567893", "EST", 15.25, "Informatique", "Lic.pro-DUT", "Essaouira" },
                    { "R264797", "EST", 16.0, "Informatique", "Lic.pro-DUT", "safi" },
                    { "R45698310", "FP", 16.42, "Informatique", "DUT", "safi" },
                    { "R147778136", "EST", 16.42, "Informatique", "DUT", "safi" },
                    { "R14777313", "EST", 15.5, "chimie", "DUT", "casablanca" },
                    { "R14777891", "EST", 15.0, "Informatique", "DUT", "safi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R14078593");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R14128897");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R14456325");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R14777313");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R147778136");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R14777891");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R14778001");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R1478562");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R264797");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R45698310");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R96341839");

            migrationBuilder.DeleteData(
                table: "AnneeUniversitaires",
                keyColumn: "Cne",
                keyValue: "R98567893");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R14078593");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R14128897");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R14456325");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R14777313");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R147778136");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R14777891");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R14778001");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R1478562");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R264797");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R45698310");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R96341839");

            migrationBuilder.DeleteData(
                table: "Baccalaureats",
                keyColumn: "Cne",
                keyValue: "R98567893");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R14078593");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R14128897");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R14456325");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R14777313");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R147778136");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R14777891");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R14778001");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R1478562");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R264797");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R45698310");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R96341839");

            migrationBuilder.DeleteData(
                table: "CouncourEcrits",
                keyColumn: "Cne",
                keyValue: "R98567893");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R14078593");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R14128897");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R14456325");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R14777313");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R147778136");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R14777891");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R14778001");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R1478562");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R264797");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R45698310");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R96341839");

            migrationBuilder.DeleteData(
                table: "CouncourOrals",
                keyColumn: "Cne",
                keyValue: "R98567893");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R14078593");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R14128897");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R14456325");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R14777313");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R147778136");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R14777891");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R14778001");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R1478562");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R264797");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R45698310");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R96341839");

            migrationBuilder.DeleteData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "R98567893");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R14078593");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R14128897");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R14456325");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R14777313");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R147778136");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R14777891");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R14778001");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R1478562");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R264797");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R45698310");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R96341839");

            migrationBuilder.DeleteData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "R98567893");
        }
    }
}
