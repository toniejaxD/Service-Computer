using generowanieserwis.tabele;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace SerwisKomputerowy
{
    public partial class Form3 : Form
    {
        private readonly string oradb;
        private List<Klient> klientList = new();
        public Form3()
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


        //        string imie = textBoxIMIE.Text;
        //        string nazwisko = textBox2NAZWISKO.Text;

        //            using (OracleConnection connection = new OracleConnection(oradb))
        //            {
        //                try
        //                {


        //                    // Tworzenie zapytania SQL do dodawania użytkownika
        //                    string query = "insert into klient (id_klienta, imie, nazwisko, kontakty_id_kontakty, rodzaj_platnosci_id_platnosci, inna_cena_za_naprawe_id_inna_cena) values(:ID, :imie, :nazwisko, :kontakty_id_kontakty, :rodzaj_platnosci_id_platnosci, :inna_cena_za_naprawe_id_inna_cena)"; // Przykładowe zapytanie - dostosuj do swojej tabeli i struktury danych

        //    string imie = textBoxIMIE.Text;
        //    string nazwisko = textBox2NAZWISKO.Text;
        //    connection.Open();
        //                    using (SqlConnection connection = new SqlConnection(oradb))
        //                    {
        //                        connection.Open();

        //                        using (SqlCommand command = new SqlCommand(query, connection))
        //                        {
        //                            string uniqueID = GenerateUniqueID(); // Generowanie unikalnego ID
        //    command.Parameters.AddWithValue(":ID", uniqueID);
        //                            command.Parameters.Add(":imie", imie);

        //                            command.ExecuteNonQuery();
        //                            MessageBox.Show("Użytkownik dodany pomyślnie.");
        //                        }
        //                    }



        //                }
        //                catch (Exception ex)
        //                {
        //    MessageBox.Show("Wystąpił błąd podczas dodawania użytkownika: " + ex.Message);
        //}
        //            }
        private int PobierzOstatnieID(OracleConnection connection)
        {
            string sqlQuery = "SELECT MAX(id_klienta) FROM klient";

            using (OracleCommand command = new OracleCommand(sqlQuery, connection))
            {
                object result = command.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    // Jeśli nie ma żadnych rekordów, zwróć wartość początkową (np. 1)
                    return 0;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //string id = textBoxID.Text;

            string imie = textBoxIMIE.Text;
            string nazwisko = textBox2NAZWISKO.Text;
            string query = "insert into klient (id_klienta, imie, nazwisko, kontakty_id_kontakty, rodzaj_platnosci_id_platnosci, inna_cena_za_naprawe_id_inna_cena) values(:ID, :imie, :nazwisko, :ID1, :ID2, :ID3)"; // Przykładowe zapytanie - dostosuj do swojej tabeli i struktury danych
            using (OracleConnection connection = new OracleConnection(oradb))
            {
                connection.Open();

                // Pobierz ostatnio wygenerowane ID klienta
                int ostatnieID = PobierzOstatnieID(connection);

                // Zwiększ ID o 1
                int noweID = ostatnieID + 1;
                int noweID1 = ostatnieID + 1;
                int noweID2 = ostatnieID + 1;
                int noweID3 = ostatnieID + 1;

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("@ID", noweID);
                    command.Parameters.Add("@Imie", imie);
                    command.Parameters.Add("@Nazwisko", nazwisko);
                    command.Parameters.Add("@ID1", noweID1);
                    command.Parameters.Add("@ID2", noweID2);
                    command.Parameters.Add("@ID3", noweID3);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dodano klienta: " + imie + " " + nazwisko);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIMIE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2NAZWISKO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}