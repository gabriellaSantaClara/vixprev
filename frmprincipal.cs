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
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serialization.Json;

namespace API_Giphy
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                RestClient restClient = new RestClient(string.Format("https://api.giphy.com/v1/gifs/search?&api_key=dc6zaTOxFJmzC&q={0}", textGiphy.Text));
                RestRequest restRequest = new RestRequest(Method.GET);
                IRestResponse restResponse = restClient.Execute(restRequest);

                if (restResponse.ContentLength < -1)
                    MessageBox.Show("Houve um problema!" + restResponse.Content, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DadosRetorno dadosRetorno = new JsonDeserializer().Deserialize<DadosRetorno>(restResponse);

                    textresultado1.Text = dadosRetorno.Data[0].url;
                    textresultado2.Text = dadosRetorno.Data[1].url;
                    textresultado3.Text = dadosRetorno.Data[3].url;
                    textresultado4.Text = dadosRetorno.Data[4].url;
                    textresultado5.Text = dadosRetorno.Data[5].url;
                    

                 
                }
            }
            catch (Exception erro)
            {

            }


        }

        private void textGiphy_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Vixprev;Data Source=LAPTOP-TJEV6A02\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("insert into favoritos(iduser, nome, link) values (@iduser, @nome, @link)", sql);
            command.Parameters.Add("@iduser", SqlDbType.VarChar).Value = 1;
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = textNome.Text;

            if (comboLink.Text == "Opção 1")
            {
                command.Parameters.Add("@link", SqlDbType.VarChar).Value = textresultado1.Text;
            }

            if (comboLink.Text == "Opção 2")
            {
                command.Parameters.Add("@link", SqlDbType.VarChar).Value = textresultado2.Text;
            }

            if (comboLink.Text == "Opção 3")
            {
                command.Parameters.Add("@link", SqlDbType.VarChar).Value = textresultado3.Text;
            }

            if (comboLink.Text == "Opção 4")
            {
                command.Parameters.Add("@link", SqlDbType.VarChar).Value = textresultado4.Text;
            }

            if (comboLink.Text == "Opção 5")
            {
                command.Parameters.Add("@link", SqlDbType.VarChar).Value = textresultado5.Text;
            }

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                 MessageBox.Show("Favoritado com sucesso!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNome.Text = "";
                comboLink.Text = "";
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

        private void Gerenciar_Click(object sender, EventArgs e)
        {
            frmerenciar frmgen = new frmerenciar();
            frmgen.Show();
            this.Visible = false;
        }
    }

    class DadosRetorno
    {
        public IList<Data> Data { get; set; }

    }

    public class Data
    {
        public string url { get; set; }
    }
}
