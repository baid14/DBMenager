using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class Form2 : Form
    {
        private static Form2 m_oInstance = null;

        dane dd = new dane();
        dodatkoweDane d;




        public static Form2 Instance
        {
            get
            {
                if (m_oInstance == null)
                {
                    m_oInstance = new Form2();
                }
                return m_oInstance;
            }
        }



        Proxy pro = new Proxy(new dane());
        string s,ss;

        public string dane2(string insert)
        {
            insert =
       "INSERT INTO uzytkownicy VALUES (NULL,'" + d.imie(textBox1.Text) + 
       "','" + d.pass(textBox3.Text) + "'" +
       ",'" + d.mail(textBox2.Text) + "','1','1','1','1');";
       
       return insert;
        }

        public string dane3(string delete)
        {
            delete =
       "DELETE FROM uzytkownicy WHERE user= '" + textBox5.Text + "' AND " +
       "pass= '" + textBox4.Text + "';";
            return delete;
        }


        private Form2()
        {
            InitializeComponent();
            d = new dodatkoweDane(dd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add a = new add(dane2(ss));
            a.aktualizacjaDanych();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            delete d = new delete(dane3(s));
            d.aktualizacjaDanych();
        }
    }
}
