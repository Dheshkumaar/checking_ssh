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
        public DataTable DisplayBooksandAuthor()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("data source=DHESH;database=BookDb;Integrated security=true;");
            SqlCommand cmd = new SqlCommand("select BookId,Title,AuthorName,Price from tbl_book b join tbl_author a on b.AuthorId = a.AuthorId ", con);
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
        public DataTable BookById(int bookId)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("data source=DHESH;database=BookDb;Integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl_book where bookId ="+bookId,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public int UpdateBook(int BookId,string title, int aid, double price )
        {
            SqlConnection con = new SqlConnection("data source=DHESH;database=BookDb;Integrated security=true;");
            con.Open();
            string query = "Update tbl_book set title = @title,AuthorID = @aid,Price = @price where bookId = @BookId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@aid", aid);
            cmd.Parameters.AddWithValue("@price",price );
            cmd.Parameters.AddWithValue("@BookId", BookId);
            return cmd.ExecuteNonQuery();
        }
        public int DeleteBook(int BookId)
        {
            SqlConnection con = new SqlConnection("data source=DHESH;database=BookDb;Integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from tbl_Book where bookid = @bkid", con);
            cmd.Parameters.AddWithValue("@bkid", BookId);
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
        public int selectbyName(string authorname)
        {
            SqlConnection con = new SqlConnection("data source=DHESH;database=BookDb;Integrated security=true;");
            SqlCommand cmd = new SqlCommand("select authorID from tbl_author where AuthorName='"+authorname+"'", con);
            con.Open();
            string c =  cmd.ExecuteScalar().ToString();
            con.Close();
            return Convert.ToInt32(c);
        }
    }
}