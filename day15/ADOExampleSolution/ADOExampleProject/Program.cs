using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOExampleProject
{
    class Program
    {
        string constring;
        SqlConnection con;
        SqlCommand cmd;

        public Program()
        {
            constring = "server=DHESH;Integrated security =true;Initial catalog=pubs";
            con = new SqlConnection(constring);
        }
        void FetchMoviesFromDatabase()
        {
            string strCmd = "select * from tblMovie";
            cmd = new SqlCommand(strCmd, con);
            try
            {
                con.Open();
                SqlDataReader drMovies = cmd.ExecuteReader();
                while (drMovies.Read())
                {
                    Console.WriteLine("Movie Id:"+ drMovies[0].ToString());
                    Console.WriteLine("Movie Name: "+ drMovies[1]);
                    Console.WriteLine("Movie Duration: "+ drMovies[2].ToString());
                    Console.WriteLine("-------------------------------------");
                }
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void FetchOneMovieFromDatabase()
        {
            string strCmd = "select * from tblMovie where id=@mid";
            cmd = new SqlCommand(strCmd, con);
            try
            {
                con.Open();
                Console.WriteLine("Please enter the id");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.Add("@mid", SqlDbType.Int);
                cmd.Parameters[0].Value = id;
                SqlDataReader drMovies = cmd.ExecuteReader();
                while (drMovies.Read())
                {
                    Console.WriteLine("Movie Id:" + drMovies[0].ToString());
                    Console.WriteLine("Movie Name: " + drMovies[1]);
                    Console.WriteLine("Movie Duration: " + drMovies[2].ToString());
                    Console.WriteLine("-------------------------------------");
                }
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void UpdateMovieDuration()
        {
            Console.WriteLine("Please enter the Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the movie duration");
            float mDuration = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
            string strCmd = "Update tblMovie set duration =@mdur where id =@mid";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mid", id);
            cmd.Parameters.AddWithValue("@mdur", mDuration);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Movie updated");
                else
                    Console.WriteLine("No not done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void DeleteMovie()
        {
            Console.WriteLine("Please enter the Id");
            int id = Convert.ToInt32(Console.ReadLine());
            string strCmd = "delete from tblMovie where id=@mid";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mid", id);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Movie deleted");
                else
                    Console.WriteLine("No not done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void AddMovie()
        {
            Console.WriteLine("Please enter the movie name");
            string mName = Console.ReadLine();
            Console.WriteLine("please enter the movie duration");
            float mDuration = (float)Math.Round(float.Parse(Console.ReadLine()),2);
            string strCmd = "insert into tblMovie(name,duration) values(@mname,@mdur)";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mname", mName);
            cmd.Parameters.AddWithValue("@mdur", mDuration);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if(result > 0)
                    Console.WriteLine("Movie inserted");
                else
                    Console.WriteLine("No not done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void AddMoreMovie()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Please enter the movie name");
                string mName = Console.ReadLine();
                Console.WriteLine("please enter the movie duration");
                float mDuration = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
                string strCmd = "insert into tblMovie(name,duration) values(@mname,@mdur)";
                cmd = new SqlCommand(strCmd, con);
                cmd.Parameters.AddWithValue("@mname", mName);
                cmd.Parameters.AddWithValue("@mdur", mDuration);
                try
                {
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        Console.WriteLine("Movie inserted");
                    else
                        Console.WriteLine("No not done");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
                Console.WriteLine("Do you want to continue? press 0 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice != 0);
        }
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add a movie");
                Console.WriteLine("2. Add more than one movie");
                Console.WriteLine("3. Update the movie Duration");
                Console.WriteLine("4. Delete the movie");
                Console.WriteLine("5. Print movie by ID");
                Console.WriteLine("6. Print all movies");
                Console.WriteLine("7. Exit the application");
                Console.WriteLine("Select your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        new Program().AddMovie();
                        break;
                    case 2:
                        new Program().AddMoreMovie();
                        break;
                    case 3:
                        new Program().UpdateMovieDuration();
                        break;
                    case 4:
                        new Program().DeleteMovie();
                        break;
                    case 5:
                        new Program().FetchOneMovieFromDatabase();
                        break;
                    case 6:
                        new Program().FetchMoviesFromDatabase();
                        break;
                    case 7:
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 7);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintMenu();
        }
    }
}
