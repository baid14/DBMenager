using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;

namespace Aplikacja
{
    public partial class Form1 : Form, IObserwator
    {

  
        public void aktualizacjaDanych()
        {
            polacz.pobierzdane(sql);
        }



        public string dane (string mojePolaczenie){
         mojePolaczenie =
    "SERVER=" + textBox1.Text + ";" +
    "DATABASE=" + textBox4.Text + ";" +
    "UID=" + textBox2.Text + ";" +
    "PASSWORD=" + textBox3.Text + ";";
        return mojePolaczenie;
    }

        static void ja()
        {

        }
        

        public void wyswietl(DataTable dt) { 
        dataGridView1.DataSource = dt.DefaultView;
        }

        public void error() { 
        MessageBox.Show("Błąd logowania do bazy danych MySQL", "Błąd");
        }


        string sql = "SELECT * FROM uzytkownicy";


        connect polacz;

        public Form1()
        {
            polacz = new connect();
            InitializeComponent();
        }

        public void onclick()
        {
          
            Form2.Instance.Show();
        }
         

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            polacz.pobierzdane(sql);
            polacz.powiadomObserwatorow();

            if (polacz.con == true)
            {
                wyswietl(polacz.dt);
            } else
            {
                error();
            }


            onclick();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (polacz.con == true)
            {
                polacz.pobierzdane(sql);
                polacz.powiadomObserwatorow();
                wyswietl(polacz.dt);
            }
            else
            {
               
            }
        }
    }

}
