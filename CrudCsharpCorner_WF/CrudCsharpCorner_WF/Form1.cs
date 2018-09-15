using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CrudCsharpCorner_WF
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        int ID = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_State.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO tbl_record(name,state) values(@name,@state)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@state", txt_State.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Dados inseridos com sucesso");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("por favor insira seus dados");
            }
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM tbl_record", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void ClearData()
        {
            txt_Name.Text = "";
            txt_State.Text = "";
            ID=0;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_State.Text != "")
            {
                cmd = new SqlCommand("UPDATE tbl_record SET Name=@name,State=@state WHERE ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@state", txt_State.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso!");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Por favor insira os dados para serem gravados!");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("DELETE tbl_record WHERE ID =@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Dados excluidos com sucesso");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selecione um dado para ser excluido!");
            }
        }
    }
}
