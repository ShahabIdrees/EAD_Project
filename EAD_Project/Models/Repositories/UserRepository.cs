using EAD_Project.Models.Interface;
using System.Data.SqlClient;

namespace EAD_Project.Models.Repositories
{
    public class UserRepository : IUser
    {
        public void AddUser(User u)
        {
            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Rexix;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            //string query = $"insert into User_Table(FirstName,LastName,Email,Password) values ('{firstname}','{lastname}','{email}','{password}')";
            //SqlCommand cmd = new SqlCommand(query, con);
            //int insertedRows = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
