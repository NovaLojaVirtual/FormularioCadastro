using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Formulario_
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count >0)
            {
                Carregar(Request.QueryString["IdUsuario"]);


                Formulario_.TblFormulario ap = new TblFormulario();
                Formulario_.DBContext con = new DBContext();

                ap.Nome = "nome";
                ap.SobreNome = "SobreNome";
                ap.DtNasc = "DtNasc";
                ap.Email = "Email";
                ap.Endereco = "Endereco";
                ap.Salario = "Salario";

                ap.Incluir(con);

            }
        }

        private void Carregar(string IdUsuario)
        {
            string sql = @"SELECT  [IdUsuario],[Nome],[SobreNome],[DtNasc],[Email],[Endereco],[Salario]
                         FROM [FormularioCadastro].[dbo].[TblFormulario]
                             where idUsuario = " + IdUsuario;

            DBContext con = new DBContext();
            DataTable dt = con.Consultar(sql);


            txtnome.Text = dt.Rows[0]["nome"].ToString();
            txtsobrenome.Text = dt.Rows[0]["sobrenome"].ToString();
            txtdcnasc.Text = dt.Rows[0]["dtnasc"].ToString();
            txtemail.Text = dt.Rows[0]["email"].ToString();
            txtend.Text = dt.Rows[0]["endereco"].ToString();
            txtsalario.Text = dt.Rows[0]["salario"].ToString();
        }

        protected void btnaincluir_Click(object sender, EventArgs e)
        {

            string sql = @"INSERT
                           INTO     [FormularioCadastro].[dbo].[TblFormulario]  ([Nome],[SobreNome],[DtNasc],[Email],[Endereco],[Salario])
                         VALUES ('" + txtnome.Text + "', '" + txtsobrenome.Text + "','" + txtdcnasc.Text + "','" + txtemail.Text + "','" + txtend.Text + "'," + txtsalario.Text + ")";
            DBContext con = new DBContext();
            con.Executar(sql);
        }

        protected void btnatualizar_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE   FormularioCadastro.dbo.TblFormulario
                         SET   nome ='" + txtnome.Text + "', sobrenome ='" + txtsobrenome.Text + "', DtNasc = '" + txtdcnasc.Text + "', Email ='" + txtemail.Text + "', Endereco = '" + txtend.Text + "', Salario = " + txtsalario.Text + " where idUsuario =" + lblidusuario.Text;
            DBContext con = new DBContext();
            con.Executar(sql);


        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName=="Excluir")
            {
                string idusuario = GridView1.DataKeys[int.Parse(e.CommandArgument.ToString())].Value.ToString();
                string sql = "delete FormularioCadastro.dbo.TblFormulario where idusuario=" + idusuario;
                DBContext con = new DBContext();
                con.Executar(sql);

                sql = "select * from  FormularioCadastro.dbo.TblFormulario";
                con = new DBContext();
                DataTable dt = con.Consultar(sql);
                GridView1.DataSource = dt;
                GridView1.DataBind(); 
            }
            if (e.CommandName == "Editar")
            {
                string idusuario = GridView1.DataKeys[int.Parse(e.CommandArgument.ToString())].Value.ToString();
                Carregar(idusuario);
                lblidusuario.Text = idusuario;
            }

        }

        protected void btnpesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from  FormularioCadastro.dbo.TblFormulario";
            DBContext con = new DBContext();
            DataTable dt= con.Consultar(sql);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }


    }
}
