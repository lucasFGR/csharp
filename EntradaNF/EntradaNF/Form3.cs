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

namespace EntradaNF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(Conn.StrCon);
            var sqlQuery = "SELECT * FROM ENTRADANF";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(  dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            Form2 form2 = new Form2(id);
            form2.ShowDialog();
        }
    }
}
