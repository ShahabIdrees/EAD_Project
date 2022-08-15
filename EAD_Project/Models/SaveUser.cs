using Microsoft.Data.SqlClient;
using Microsoft.Data.Sql;
namespace EAD_Project.Models
{
    public class SaveUser
    {
        static public void SaveUserData(string firstname, string lastname, string email, string password)
        {
            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Rexix;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = $"insert into User_Table(FirstName,LastName,Email,Password) values ('{firstname}','{lastname}','{email}','{password}')";
            SqlCommand cmd = new SqlCommand(query, con);
            int insertedRows = cmd.ExecuteNonQuery();
            con.Close();
        }
        static public string getUserPassword(string email)
        {
            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Rexix;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = $"Select Password From User_Table Where Email = @u";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter a = new SqlParameter("u", email);
            cmd.Parameters.Add(a);
            SqlDataReader dr = cmd.ExecuteReader();
            string pwd = "";
            while (dr.Read())
            {
                pwd = Convert.ToString(dr[0]);
            }
            con.Close();    
                return pwd;
        }
        static public List<User> getAllUsers()
        {
            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Rexix;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = $"Select * From User_Table";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            List<User> users = new List<User>();
            
            while (dr.Read())
            {
                User temp = new User();
                temp.Firstname = Convert.ToString(dr[1]);
                temp.Lastname = Convert.ToString(dr[2]);
                temp.Email = Convert.ToString(dr[3]);
                temp.Password = Convert.ToString(dr[4]);
                users.Add(temp);
            }
            return users;
        }
    }
}
