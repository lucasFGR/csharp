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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntradaNF
{
    public partial class Form2 : Form
    {
        int id = 0;

        public Form2(int id)
        {
            InitializeComponent();
            getPorteiro();
            dtEntrada.Value = System.DateTime.Now;


            this.id = id;

            if (this.id > 0)
            {
                GetEntrada(id);
                chkLastEntry.Visible = false;
                dtEntrada.Enabled = false;
                textEmpresa.Enabled = false;
                textMotorista.Enabled = false;
                textPlaca.Enabled = false;
                textDestino.Enabled = false;
                cboxPorteiro.Enabled = false;
                textRG.Enabled = false;
                textMotivo.Enabled = false;
                textObs.Enabled = false;
                dtNF.Enabled = false;
                Nf.Enabled = false;
                valNF.Enabled = false;
                textTransportadora.Enabled = false;
                textCnpj.Enabled = false;
                ckNf.Enabled = false;
            }


        }

        


        private void GetEntrada(int id)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    var sql = "SELECT * FROM TabEntradaNF WHERE id =" + id;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    //dtEntrada.Text = dr["NOME"].ToString();
                                    dtEntrada.Value = Convert.ToDateTime(dr["ENTRADA"]);
                                    textEmpresa.Text = dr["EMPRESA"].ToString();
                                    textMotorista.Text = dr["MOTORISTA"].ToString();
                                    textPlaca.Text = dr["PLACA"].ToString();
                                    textDestino.Text = dr["DESTINO"].ToString();
                                    cboxPorteiro.Text = dr["PORTEIRO"].ToString();
                                    textRG.Text = dr["RG"].ToString();
                                    textMotivo.Text = dr["MOTIVO"].ToString();
                                    dtSaida.Value = Convert.ToDateTime(dr["SAIDA"]);
                                    textObs.Text = dr["OBSERVACAO"].ToString();
                                    dtNF.Value = Convert.ToDateTime(dr["DATA_EMISSAO"]);
                                    Nf.Text = dr["NF"].ToString();
                                    valNF.Text = dr["VALOR_NF"].ToString();
                                    textTransportadora.Text = dr["TRANSPORTADORA"].ToString();
                                    textCnpj.Text = dr["CNPJ"].ToString();

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao abrir registro" + ex.Message);
            }
        }

        private void seachEmpresa()
        {

        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cn = new SqlConnection(Conn.StrCon);

                cn.Open();


                var sql = "";


                if (this.id == 0)
                    sql = "INSERT INTO TabEntradaNF VALUES (@ENTRADA,@PORTEIRO,@MOTORISTA,@RG,@PLACA,@MOTIVO,@DESTINO,@SAIDA,@CNPJ,@EMPRESA,@OBSERVACAO,@NF,@DATA_EMISSAO,@VALOR_NF,@TRANSPORTADORA)";
                else
                {
                    sql = "UPDATE TabEntradaNF SET ENTRADA=@ENTRADA,PORTEIRO=@PORTEIRO,MOTORISTA=@MOTORISTA,RG=@RG,PLACA=@PLACA,MOTIVO=@MOTIVO,DESTINO=@DESTINO,SAIDA=@SAIDA,CNPJ=@CNPJ,EMPRESA=@EMPRESA,OBSERVACAO=@OBSERVACAO,NF=@NF,DATA_EMISSAO=@DATA_EMISSAO,VALOR_NF=@VALOR_NF,TRANSPORTADORA=@TRANSPORTADORA  WHERE id=" + this.id;
                }

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {

                    cmd.Parameters.AddWithValue("ENTRADA", Convert.ToDateTime(dtEntrada.Value));
                    cmd.Parameters.AddWithValue("PORTEIRO", cboxPorteiro.Text.ToUpper());
                    cmd.Parameters.AddWithValue("MOTORISTA", textMotorista.Text.ToUpper());
                    cmd.Parameters.AddWithValue("RG", textRG.Text.ToUpper());
                    cmd.Parameters.AddWithValue("PLACA", textPlaca.Text.ToUpper());
                    cmd.Parameters.AddWithValue("MOTIVO", textMotivo.Text.ToUpper());
                    cmd.Parameters.AddWithValue("DESTINO", textDestino.Text.ToUpper());

                    if (dtSaida.Value.ToString() == "01/01/2022")
                    {
                        cmd.Parameters.AddWithValue("SAIDA", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("SAIDA", Convert.ToDateTime(dtSaida.Value));
                    }
                    cmd.Parameters.AddWithValue("CNPJ", textCnpj.Text.ToUpper());
                    cmd.Parameters.AddWithValue("EMPRESA", textEmpresa.Text.ToUpper());
                    cmd.Parameters.AddWithValue("OBSERVACAO", textObs.Text.ToUpper());
                    cmd.Parameters.AddWithValue("NF", Nf.Text.ToUpper());
                    cmd.Parameters.AddWithValue("DATA_EMISSAO", Convert.ToDateTime(dtNF.Text));
                    cmd.Parameters.AddWithValue("VALOR_NF", valNF.Text.ToUpper());
                    cmd.Parameters.AddWithValue("TRANSPORTADORA", textTransportadora.Text.ToUpper());






                    cmd.ExecuteNonQuery();
                }
                this.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar entrada \n \n" + ex.Message);
            }

        }

        private void ckNf_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckNf.Checked == true)
            {
                dtNF.Enabled = true;
                Nf.Enabled = true;
                valNF.Enabled = true;

            }
            else
            {
                dtNF.Enabled = false;
                Nf.Enabled = false;
                valNF.Enabled = false;



            }
        }

        private void textCnpj_TextChanged(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT NOME FROM ViewNFFornecedores where RAZAO = @CNPJ";

                    SqlCommand cmd = new SqlCommand(sqlQuery, cn);
                    cmd.Parameters.AddWithValue("@CNPJ", textCnpj.Text);
                    SqlDataReader da = cmd.ExecuteReader();



                    if (da.HasRows)
                    {
                        while (da.Read())
                        {
                            textEmpresa.Text = da.GetValue(0).ToString();
                        }
                    }
                    else
                    {
                        textEmpresa.Text = textCnpj.Text;
                    }
                    cn.Close();
                }
            }
            catch
            {
                textEmpresa.Text = textCnpj.Text;
            }


        }

        private void getPorteiro()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT NOME FROM TabPorteiros";

                    SqlCommand cmd = new SqlCommand(sqlQuery, cn);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand= cmd;
                    DataTable porteiros = new DataTable();
                    da.Fill(porteiros);
                    cboxPorteiro.DataSource= porteiros;
                    cboxPorteiro.ValueMember = "NOME";
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar porteiros \n\n" + ex.Message);
            }
        }

        private void chkLastEntry_CheckedChanged(object sender, EventArgs e)
        {

            if (chkLastEntry.Checked == true)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        var sqlQuery = "SELECT  TOP 1 * FROM TabEntradaNF ORDER BY ID DESC";

                        SqlCommand cmd = new SqlCommand(sqlQuery, cn);
                        cmd.Parameters.AddWithValue("@CNPJ", textCnpj.Text);
                        SqlDataReader da = cmd.ExecuteReader();


                        while (da.Read())
                        {
                            dtEntrada.Value = Convert.ToDateTime(da["ENTRADA"]);
                            textEmpresa.Text = da["EMPRESA"].ToString();
                            textMotorista.Text = da["MOTORISTA"].ToString();
                            textRG.Text = da["RG"].ToString();
                            textPlaca.Text = da["PLACA"].ToString();
                            textMotivo.Text = da["MOTIVO"].ToString();
                            cboxPorteiro.Text = da["PORTEIRO"].ToString();
                            textDestino.Text = da["DESTINO"].ToString();
                            dtSaida.Value = Convert.ToDateTime(da["SAIDA"]);
                            textObs.Text = da["OBSERVACAO"].ToString();
                            textTransportadora.Text = da["TRANSPORTADORA"].ToString();
                            textCnpj.Text = da["CNPJ"].ToString();
                        }

                        cn.Close();
                    }
                }
                catch
                {

                }

            }
        }

       
    }


}
