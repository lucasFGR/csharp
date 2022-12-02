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

        public Form2( int id)
        {
            InitializeComponent();
            dtEntrada.Value = System.DateTime.Now;



            this.id = id;

            if (this.id > 0)
            {
                GetEntrada(id);
                chkLastEntry.Visible = false;

            }


        }


        private void GetEntrada(int id)
        {
            
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    var sql = "SELECT * FROM NFENTRADA2 WHERE id =" + id;
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
                                    textPorteiro.Text = dr["PORTEIRO"].ToString();
                                    textRG.Text = dr["RG"].ToString();
                                    textMotivo.Text = dr["MOTIVO"].ToString();
                                    dtSaida.Value = Convert.ToDateTime(dr["SAIDA"]);
                                    textObs.Text = dr["OBSERVACAO"].ToString();
                                    dtNF.Value = Convert.ToDateTime(dr["DATA_EMISSAO"]);
                                    Nf.Text = dr["NF"].ToString();
                                    valNF.Text = dr["VALOR_NF"].ToString();

                                }
                            }
                        }
                    }
                }
            }catch(Exception ex)
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
                    sql = "INSERT INTO NFENTRADA2 VALUES (@ENTRADA,@PORTEIRO,@MOTORISTA,@RG,@PLACA,@MOTIVO,@DESTINO,@SAIDA,@EMPRESA,@OBSERVACAO,@NF,@DATA_EMISSAO,@VALOR_NF)";
                else
                {
                    sql = "UPDATE NFENTRADA2 SET ENTRADA=@ENTRADA,PORTEIRO=@PORTEIRO,MOTORISTA=@MOTORISTA,RG=@RG,PLACA=@PLACA,MOTIVO=@MOTIVO,DESTINO=@DESTINO,SAIDA=@SAIDA,EMPRESA=@EMPRESA,OBSERVACAO=@OBSERVACAO,NF=@NF,DATA_EMISSAO=@DATA_EMISSAO,VALOR_NF=@VALOR_NF  WHERE id=" + this.id;
                }

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    
                    //cmd.Parameters.AddWithValue("@nome", dtEntrada.Text);
                    cmd.Parameters.AddWithValue("ENTRADA", Convert.ToDateTime(dtEntrada.Value));
                    cmd.Parameters.AddWithValue("PORTEIRO", textPorteiro.Text);
                    cmd.Parameters.AddWithValue("MOTORISTA", textMotorista.Text);
                    cmd.Parameters.AddWithValue("RG", textRG.Text);
                    cmd.Parameters.AddWithValue("PLACA", textPlaca.Text);
                    cmd.Parameters.AddWithValue("MOTIVO", textMotivo.Text);
                    cmd.Parameters.AddWithValue("DESTINO", textDestino.Text);

                    if (dtSaida.Value.ToString() == "01/01/2022")
                    {
                        cmd.Parameters.AddWithValue("SAIDA", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("SAIDA", Convert.ToDateTime(dtSaida.Value));
                    }

                    cmd.Parameters.AddWithValue("EMPRESA", textEmpresa.Text);
                    cmd.Parameters.AddWithValue("OBSERVACAO", textObs.Text);
                    cmd.Parameters.AddWithValue("NF", Nf.Text);
                    cmd.Parameters.AddWithValue("DATA_EMISSAO", Convert.ToDateTime( dtNF.Text));
                    cmd.Parameters.AddWithValue("VALOR_NF", valNF.Text);






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

                    var sqlQuery = "SELECT NOME FROM FORNECEDORES WHERE CNPJ = @CNPJ";

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
            catch (Exception ex)
            {
                textEmpresa.Text = textCnpj.Text;
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

                        var sqlQuery = "SELECT  TOP 1 * FROM NFENTRADA2 ORDER BY ID DESC";

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
                            textPorteiro.Text = da["PORTEIRO"].ToString();
                            textDestino.Text = da["DESTINO"].ToString();
                            dtSaida.Value = Convert.ToDateTime(da["SAIDA"]);
                            textObs.Text = da["OBSERVACAO"].ToString();
                        }

                        cn.Close();
                    }
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
    
}
