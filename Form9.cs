﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerwisKomputerowy
{
    public partial class Form9 : Form
    {
        private readonly string oradb;
        public Form9()
        {
            InitializeComponent();
            //oradb: Prywatne pole przechowujące ciąg połączenia do bazy danych Oracle.
            //DATA SOURCE:Określa adres IP serwera bazy danych oraz port, na którym Oracle nasłuchuje (w tym przypadku 1521). tpdb to identyfikator SID (System Identifier) bazy danych, czyli unikalny identyfikator instancji Oracle na serwerze.
            //TNS_ADMIN: To ścieżka do pliku konfiguracji sieciowej Oracle (pliku tnsnames.ora), który zawiera informacje o różnych nazwach usług bazodanowych. Plik ten znajduje się na lokalnym komputerze użytkownika
            //PERSIST SECURITY INFO:  Ustawienie to pozwala na ponowne uzyskanie danych uwierzytelniających (takich jak użytkownik i hasło) z połączenia, nawet po jego otwarciu. Wartość True oznacza, że połączenie będzie przechowywać te informacje w pamięci.
            //USER ID:Nazwa użytkownika, która jest używana do logowania się do bazy danych Oracle.
            //PASSWORD: Jest to hasło, które umożliwia uwierzytelnienie użytkownika podczas logowania do bazy danych.
            oradb = "DATA SOURCE=************;TNS_ADMIN=************;PERSIST SECURITY INFO=True;USER ID=************;PASSWORD=************";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numer_zlecenia = textBoxNumerZlecenia.Text;


            string query = "DELETE FROM komputer WHERE numer_zlecenia_komputera = :numer_zlecenia_komputera"; // Przykładowe zapytanie - dostosuj do swojej tabeli i struktury danych
            using (OracleConnection connection = new OracleConnection(oradb))
            {
                connection.Open();

                // Pobierz ostatnio wygenerowane ID klienta




                using (OracleCommand command = new OracleCommand(query, connection))
                {

                    command.Parameters.Add("@numer_zlecenia_komputera", numer_zlecenia);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Usunięto zlecenia: " + numer_zlecenia);
                }
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}