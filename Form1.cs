using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Giphy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Vixprev;Data Source=LAPTOP-TJEV6A02\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("select * from usuarios where usuario=@usuario and senha=@senha", sql);
            command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = textUser.Text;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = textSenha.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false) { 
                throw new Exception("Usuário ou Senha!");
                }
                drms.Read();
                MessageBox.Show("Login realizado com sucesso!","Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmprincipal frmpri = new frmprincipal();
                frmpri.Show();
                this.Visible = false;
            }
             
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                sql.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
