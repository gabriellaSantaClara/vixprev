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
    public partial class frmerenciar : Form
    {
        public frmerenciar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Vixprev;Data Source=LAPTOP-TJEV6A02\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("select * from favoritos where nome=@nome", sql);
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = textNomeAtual.Text;
          

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("Usuário ou Senha!");
                }
                drms.Read();
                text1.Text = Convert.ToString(drms["id"]);
                text0.Text = Convert.ToString(drms["iduser"]);
                text2.Text = textNomeAtual.Text;
                text3.Text = Convert.ToString(drms["link"]);




                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Vixprev;Data Source=LAPTOP-TJEV6A02\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("update favoritos set iduser=@iduser, nome=@nome, link=@link where id=@id", sql);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = text1.Text;
            command.Parameters.Add("@iduser", SqlDbType.VarChar).Value = 1;
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = textNomeNovo.Text;
            command.Parameters.Add("@link", SqlDbType.VarChar).Value = text3.Text;


            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Alterado com sucesso!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            catch
            {
                MessageBox.Show("Nao foi possivel!");
            }
            finally
            {
                sql.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Vixprev;Data Source=LAPTOP-TJEV6A02\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("delete from favoritos where id=@id", sql);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = text1.Text;


            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Deletado com sucesso!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }

        }
    }
}
