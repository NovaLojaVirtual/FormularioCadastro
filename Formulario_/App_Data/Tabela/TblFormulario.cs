using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Formulario_
{
    public class TblFormulario
    {
        public int    IdUsuario;
        public string Nome;
        public string SobreNome;
        public string DtNasc;
        public string Email;
        public string Endereco;
        public string Salario;

        public DataTable Get(DBContext con)
        {
            string sql = "Select * from TblFormulario";
            return con.Consultar(sql);
        }

        public void Incluir(DBContext con)
        { 
            string sql = "INSERT INTO FormularioCadastro.dbo.TblFormulario(Nome, SobreNome, DtNasc, Email, Endereco, Salario)";
            sql += "('" + Nome + "','" + SobreNome + "','" + DtNasc + "','" + Email + "','" + Endereco + "','" + Salario + "')'";



        }

        public void Atualizar(DBContext con)
        { 
            string sql = "UPDATE FormularioCadastro.dbo.TblFormulario(Nome,SobreNome,DtNasc,Email,Endereco,Salario)";
            sql += "( SET '" + Nome + "','" + SobreNome + "','" + DtNasc + "','" + Email + "','" + Endereco + "','" + Salario + "')'";
            sql += " where idusuario=" + IdUsuario;
        }

        public void Deletar(DBContext con)
        {
            string sql = "DELETE FROM FormularioCadastro.dbo.TblFormulario ";
            sql += "('" + IdUsuario + "')";
        }
    }
}

