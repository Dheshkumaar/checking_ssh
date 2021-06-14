using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCWithADO.Models
{
    public class CRUDModel
    {
        public DataTable DisplayBooks()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("data source=DHESH;database=BookDb;Integrated security=true;");
            SqlCommand cmd = new SqlCommand("select * from tbl_book", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public int NewBook(string Title,int Aid,Double price)
        {
            SqlConnection con = new SqlConnection("data source=DHESH;database=BookDb;Integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_InsBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@AuthorId", Aid);
            cmd.Parameters.AddWithValue("@Price", price);
            return cmd.ExecuteNonQuery();
        }
        public DataTable DisplayAuthors()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("data source=DHESH;database=BookDb;Integrated security=true;");
            SqlCommand cmd = new SqlCommand("select * from tbl_author", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public int NewAuthor(string AName)
        {
            SqlConnection con = new SqlConnection("data source=DHESH;database=BookDb;Integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_InsAuthor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AuthorName", AName);
            return cmd.ExecuteNonQuery();
        }
    }
}