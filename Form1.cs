using generowanieserwis.tabele;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System;
namespace SerwisKomputerowy
{
    public partial class Form1 : Form
    {
        

        private readonly string oradb;
       
        public Form1()
        {
            InitializeComponent();
            //oradb: Prywatne pole przechowuj¹ce ci¹g po³¹czenia do bazy danych Oracle.
            //DATA SOURCE:Okreœla adres IP serwera bazy danych oraz port, na którym Oracle nas³uchuje (w tym przypadku 1521). tpdb to identyfikator SID (System Identifier) bazy danych, czyli unikalny identyfikator instancji Oracle na serwerze.
            //TNS_ADMIN: To œcie¿ka do pliku konfiguracji sieciowej Oracle (pliku tnsnames.ora), który zawiera informacje o ró¿nych nazwach us³ug bazodanowych. Plik ten znajduje siê na lokalnym komputerze u¿ytkownika
            //PERSIST SECURITY INFO:  Ustawienie to pozwala na ponowne uzyskanie danych uwierzytelniaj¹cych (takich jak u¿ytkownik i has³o) z po³¹czenia, nawet po jego otwarciu. Wartoœæ True oznacza, ¿e po³¹czenie bêdzie przechowywaæ te informacje w pamiêci.
            //USER ID:Nazwa u¿ytkownika, która jest u¿ywana do logowania siê do bazy danych Oracle.
            //PASSWORD: Jest to has³o, które umo¿liwia uwierzytelnienie u¿ytkownika podczas logowania do bazy danych.
            oradb = "DATA SOURCE=************;TNS_ADMIN=************;PERSIST SECURITY INFO=True;USER ID=************;PASSWORD=************";
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                var oradb_usuwanie1 = "DELETE DOSTAWCA_CZESCI_KOMPUTEROWE";
                var oradb_usuwanie2 = "DELETE USLUGI";
                var oradb_usuwanie3 = "DELETE INNA_CENA_ZA_NAPRAWE";
                var oradb_usuwanie4 = "DELETE KOMPUTER";
                var oradb_usuwanie5 = "DELETE KONTAKTY";
                var oradb_usuwanie6 = "DELETE KLIENT";
                var oradb_usuwanie7 = "DELETE WYMIANA_CZESCI_KOMPUTEROWE";


                var oradb_usuwanie8 = "DELETE PRACOWNIK";
                var oradb_usuwanie9 = "DELETE PROPONOWANA_CENA_ZA_NAPRAWE";
                var oradb_usuwanie10 = "DELETE RACHUNEK";
                var oradb_usuwanie11 = "DELETE RODZAJ_PLATNOSCI";
                var oradb_usuwanie12 = "DELETE HISTORIA_SERWISU";
                using (OracleConnection connection = new OracleConnection(oradb))
                {
                    // otwarcie po³¹czenia
                    connection.Open();

                    // utworzenie obiektu OracleCommand z zapytaniem SQL i po³¹czeniem
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie1, connection))
                    {
                        // wykonanie zapytania SQL
                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie2, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie3, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie4, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie5, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie6, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie7, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie8, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie9, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie10, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie11, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand(oradb_usuwanie12, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Tworzenie nowego okna
            Form2 form2 = new Form2();

            // Wyœwietlanie nowego okna
            form2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            // Wyœwietlanie nowego okna
            form3.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            // Wyœwietlanie nowego okna
            form4.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            // Wyœwietlanie nowego okna
            form5.Show();
        }





        private bool IsValidXml(string filePath)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void ExportButton_Click_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(oradb))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM klient";

                    OracleCommand command = new OracleCommand(selectQuery, connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DataSet dataSet = new DataSet();
                    dataSet.Tables.Add(dataTable);

                    //filePath: Jest to œcie¿ka pliku, gdzie dane zostan¹ zapisane. W tym przypadku, jest to lokalizacja na komputerze u¿ytkownika, a plik bêdzie nazywa³ siê exported_data.xml.
                    string filePath = @"************";

                    //Ten kod zapisuje dane zawarte w obiekcie DataSet do pliku XML. DataSet to struktura danych w .NET, która mo¿e przechowywaæ wiele tabel z danych. Metoda WriteXml zapisuje te dane do pliku XML w okreœlonej œcie¿ce.
                    dataSet.WriteXml(filePath);

                    MessageBox.Show("Eksport danych zakoñczony pomyœlnie.", "Sukces");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wyst¹pi³ b³¹d podczas eksportowania danych: " + ex.Message, "B³¹d");
            }
        }

        private void ImportButton_Click_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Pliki XML|*.xml";
                    openFileDialog.Title = "Wybierz plik XML";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        if (IsValidXml(filePath))
                        {
                            DataSet dataSet = new DataSet();
                            dataSet.ReadXml(filePath);

                            if (dataSet.Tables.Count > 0)
                            {
                                DataTable dataTable = dataSet.Tables[0];

                                using (OracleConnection connection = new OracleConnection(oradb))
                                {
                                    connection.Open();

                                    string tableName = "klient";

                                    // Usuwanie istniej¹cych danych z tabeli
                                    string deleteQuery = $"DELETE FROM {tableName}";
                                    OracleCommand deleteCommand = new OracleCommand(deleteQuery, connection);
                                    deleteCommand.ExecuteNonQuery();

                                    // Wstawianie danych do tabeli
                                    using (OracleBulkCopy bulkCopy = new OracleBulkCopy(connection))
                                    {
                                        bulkCopy.DestinationTableName = tableName;
                                        bulkCopy.WriteToServer(dataTable);
                                    }

                                    // Odœwie¿anie danych w widoku DataGridView
                                    string selectQuery = $"SELECT * FROM {tableName}";
                                    OracleDataAdapter adapter = new OracleDataAdapter(selectQuery, connection);
                                    DataTable refreshedDataTable = new DataTable();
                                    adapter.Fill(refreshedDataTable);


                                    MessageBox.Show("Import danych zakoñczony pomyœlnie.", "Sukces");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Brak danych do importu w pliku XML.", "B³¹d");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wybrany plik XML ma niepoprawny format.", "B³¹d");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wyst¹pi³ b³¹d podczas importowania danych: " + ex.Message, "B³¹d");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();

            // Wyœwietlanie nowego okna
            form8.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();

            // Wyœwietlanie nowego okna
            form9.Show();
        }
    }
}