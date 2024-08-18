using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerwisKomputerowy
{
    public partial class Form5 : Form
    {
        private readonly string oradb;
        public Form5()
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

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private int PobierzOstatnieID(OracleConnection connection)
        {
            string sqlQuery = "SELECT * FROM Klient JOIN Komputer ON Klient.ID_klienta = Komputer.klient_id_klienta";

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
            string numer_zlecenia = textBoxNumerZlecenia.Text;

            string rodzaj_komputera = textBoxRodzajKomputera.Text;
            string kolor_komputera = textBoxKolorKomputera.Text;
            // string id_klienta = textBoxIDKlienta.Text;
            string uwage_id_klienta = textBoxUwageOdKlienta.Text;
            // string id_proponowana_cena_za_naprawe = textBoxIDproponowanaCena.Text;
            using (OracleConnection connection = new OracleConnection(oradb))
            {
                try
                {
                    connection.Open();


                    int ostatnieID = PobierzOstatnieID(connection);

                    // Zwiększ ID o 1

                    int noweID1 = ostatnieID + 1;
                    int noweID2 = ostatnieID + 1;


                    // Tworzenie zapytania SQL do dodawania użytkownika
                    string query = "insert into komputer (numer_zlecenia_komputera, rodzaj_komputera, kolor_komputera, klient_id_klienta, uwagi_dla_klienta, proponowana_cena_za_naprawe_id_cennik) values(:numer_zlecenia_komputera, :rodzaj_komputera, :kolor_komputera, :generatedID, :uwagi_dla_klienta, :ID2)"; // Przykładowe zapytanie - dostosuj do swojej tabeli i struktury danych

                    // Tworzenie i konfigurowanie komendy
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        //int generatedID = Convert.ToInt32(command.ExecuteScalar());
                        // Przykład przypisania wartości parametrów do zapytania
                        command.Parameters.Add(new OracleParameter(":numer_zlecenia_komputera", OracleDbType.Varchar2, 38)).Value = numer_zlecenia;
                        command.Parameters.Add(new OracleParameter(":rodzaj_komputera", OracleDbType.Varchar2)).Value = rodzaj_komputera;
                        command.Parameters.Add(new OracleParameter(":kolor_komputera", OracleDbType.Varchar2)).Value = kolor_komputera;
                        command.Parameters.Add(":ID1", noweID1);
                        command.Parameters.Add(new OracleParameter(":uwagi_dla_klienta", OracleDbType.Varchar2, 100)).Value = uwage_id_klienta;
                        command.Parameters.Add(":ID2", noweID2);
                        // ... przypisz inne parametry do zapytania w zależności od danych użytkownika

                        // Wykonaj zapytanie
                        command.ExecuteNonQuery();

                        // Wyświetl komunikat o dodaniu użytkownika
                        MessageBox.Show("Dodano zlecenie " + numer_zlecenia);

                        // Opcjonalnie, wyczyść pola formularza po dodaniu użytkownika
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas dodawania użytkownika: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumerZlecenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

