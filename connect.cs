using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace Aplikacja
{
    public class connect : IObserwowany
    {
        public bool con { get; set; }

        public connect()
        {
        }

        

        public string dane2 { get; set; }
        public DataTable dt { get; private set; }

        private List<IObserwator> _listaObserwatorow = new List<IObserwator>();

        public void dodajObserwatora(IObserwator o)
        {
            _listaObserwatorow.Add(o);
        }

        public void usunObserwator(IObserwator o)
        {
            _listaObserwatorow.Remove(o);
        }


        public void powiadomObserwatorow()
        {
            foreach (var item in _listaObserwatorow)
            {
                item.aktualizacjaDanych();
            }
        }


        public void pobierzdane(string sql)
        {

           // f.dane(dane2);

            string mojePolaczenie2 =
    "SERVER=mysql11.mydevil.net;" +
    "DATABASE=m1756_aplikacja;" +
    "UID=m1756_baid2;" +
    "PASSWORD=30Projektto;";




            MySqlConnection connection = new MySqlConnection(mojePolaczenie2);

            try
            {
                //otwórz połączenie z bazą danych
                connection.Open();
                //wykonaj polecenie języka SQL na danych połączeniu
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {



                    dt = new DataTable();

                    //Pobierz dane i zapisz w strukturze DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    //wpisz dane do kontrolki DATAGRID
                    con = true; 
                }

            }
            //Jeżeli wystąpi wyjątek wyrzuć go i pokaż informacje
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                con = false;            }
            //Zamknij połączenie po wyświetleniu danych
            connection.Close();

        }

    }
}
