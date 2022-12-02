using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace EntradaNF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    toolStripStatusLabel1.Text = "Conectado";
                    statusStrip1.ForeColor = Color.Green;
                    statusStrip1.Refresh();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Desconectado";
                statusStrip1.ForeColor = Color.Red;
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao tentar conectar com o bando de dados \n\n" + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Conn.StrCon);
            var sqlQuery = "SELECT * FROM NFENTRADA2";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Buscar();

        }

        private void Buscar()
        {
            if (cbxBuscar.Text != "" & txtBuscar.Text != "")
            {
                SqlConnection cn = new SqlConnection(Conn.StrCon);
                var sqlQuery = "";

                switch (cbxBuscar.Text)
                {
                    case "PORTEIRO":
                        if (chkSemSaida.Checked == true)
                        {
                            sqlQuery = "SELECT * FROM NFENTRADA2 WHERE PORTEIRO LIKE '%" + txtBuscar.Text + "%' AND SAIDA =  '2022-01-01 00:00:00.000' Order by id";
                        }
                        else
                        {
                            sqlQuery = "SELECT * FROM NFENTRADA2 WHERE PORTEIRO LIKE '%" + txtBuscar.Text + "%'  Order by id";
                        }
                        break;

                    case "MOTORISTA":
                        if (chkSemSaida.Checked == true)
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE MOTORISTA LIKE '%" + txtBuscar.Text + "%' AND SAIDA =  '2022-01-01 00:00:00.000'  Order by id";

                        }
                        else
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE MOTORISTA LIKE '%" + txtBuscar.Text + "%'  Order by id";
                        }
                        break;

                    case "RG":
                        if (chkSemSaida.Checked == true)
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE RG LIKE '%" + txtBuscar.Text + "%' AND SAIDA =  '2022-01-01 00:00:00.000' Order by id";

                        }
                        else
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE RG LIKE '%" + txtBuscar.Text + "%' Order by id";

                        }
                        break;

                    case "PLACA":
                        if (chkSemSaida.Checked == true)
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE PLACA LIKE '%" + txtBuscar.Text + "%' AND SAIDA =  '2022-01-01 00:00:00.000' Order by id";

                        }
                        else
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE PLACA LIKE '%" + txtBuscar.Text + "%' Order by id";

                        }
                        break;

                    case "MOTIVO":
                        if (chkSemSaida.Checked == true)
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE MOTIVO LIKE '%" + txtBuscar.Text + "%' AND SAIDA =  '2022-01-01 00:00:00.000' Order by id";

                        }
                        else
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE MOTIVO LIKE '%" + txtBuscar.Text + "%' Order by id";

                        }
                        break;

                    case "DESTINO":
                        if (chkSemSaida.Checked == true)
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE DESTINO LIKE '%" + txtBuscar.Text + "%' AND SAIDA =  '2022-01-01 00:00:00.000' Order by id";

                        }
                        else
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE DESTINO LIKE '%" + txtBuscar.Text + "%' Order by id";

                        }
                        break;

                    case "EMPRESA":
                        if (chkSemSaida.Checked == true)
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE MOTIVO LIKE '%" + txtBuscar.Text + "%' AND SAIDA =  '2022-01-01 00:00:00.000' Order by id";

                        }
                        else
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE MOTIVO LIKE '%" + txtBuscar.Text + "%' Order by id";
                        }
                        break;

                    case "OBSERVACAO":
                        if (chkSemSaida.Checked == true)
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE OBSERVACAO LIKE '%" + txtBuscar.Text + "%' AND SAIDA =  '2022-01-01 00:00:00.000' Order by id";

                        }
                        else
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE OBSERVACAO LIKE '%" + txtBuscar.Text + "%' Order by id";

                        }
                        break;

                    case "NF":
                        if (chkSemSaida.Checked == true)
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE NF LIKE '%" + txtBuscar.Text + "%' AND SAIDA =  '2022-01-01 00:00:00.000' Order by id";

                        }
                        else
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE NF LIKE '%" + txtBuscar.Text + "%' Order by id";

                        }
                        break;

                    case "VALOR_NF":
                        if (chkSemSaida.Checked == true)
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE VALOR_NF LIKE '%" + txtBuscar.Text + "%' AND SAIDA =  '2022-01-01 00:00:00.000' Order by id";

                        }
                        else
                        {
                            sqlQuery += " SELECT * FROM NFENTRADA2 WHERE VALOR_NF LIKE '%" + txtBuscar.Text + "%' Order by id";
                        }
                        break;
                }


                using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            else if (cbxBuscar.Text != "" & txtBuscar.Text == "")
            {
                SqlConnection cn = new SqlConnection(Conn.StrCon);
                var sqlQuery = "";

                if (chkSemSaida.Checked == true)
                {
                    sqlQuery = "SELECT  * FROM NFENTRADA2 WHERE SAIDA = '2022-01-01 00:00:00.000'";


                }
                else
                {
                    sqlQuery = "SELECT * FROM NFENTRADA2";

                }

                using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            else
            {
                SqlConnection cn = new SqlConnection(Conn.StrCon);
                var sqlQuery = "";

                if (chkSemSaida.Checked == true)
                {
                    sqlQuery = "SELECT  * FROM NFENTRADA2 WHERE SAIDA = '2022-01-01 00:00:00.000'";


                }
                else
                {
                    sqlQuery = "SELECT * FROM NFENTRADA2";

                }

                using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrada_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(0);
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            Form2 form2 = new Form2(id);
            form2.ShowDialog();
        }

        private void chkSemSaida_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i -1 ].HeaderText;
                }
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2,j+1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
