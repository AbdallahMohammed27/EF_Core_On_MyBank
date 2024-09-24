using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;

namespace Bank_Ado.net
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Insert();
            //Update();
           // Delete();
            Show();
        }
    static void Show()
    {
        var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
        var constr = config.GetSection("constr").Value;
        var conn = new SqlConnection(constr);

        string sql = "select * from Branch";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.CommandType = CommandType.Text;
        conn.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Branch branch = new Branch
            {
                Id = reader.GetInt32("Id"),
                Name = reader.GetString("Name"),
                Location = reader.GetString("Location")
            };
            Console.WriteLine(branch);
        }
        conn.Close();
    }
    static void Insert()
    {
            var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
            var constr = config.GetSection("constr").Value;
            var conn = new SqlConnection(constr);


            var Id = Convert.ToInt32(Console.ReadLine());
            var Name = Console.ReadLine();
            var Location = Console.ReadLine();

            Branch branch = new Branch()
            {
                Id = Id,
                Name = Name,
                Location = Location
            };
            string st = "insert into Branch (Id,Name,Location) values" + $"(@Id,@Name,@Location)";
            SqlParameter Id_par = new SqlParameter 
            {
                ParameterName = "Id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = branch.Id
            };

            SqlParameter Name_par = new SqlParameter
            {
                ParameterName = "Name",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = branch.Name
            };

            SqlParameter Location_par = new SqlParameter
            {
                ParameterName = "Location",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = branch.Location
            };

            SqlCommand cmd = new SqlCommand(st, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(Id_par);
            cmd.Parameters.Add(Name_par);
            cmd.Parameters.Add(Location_par);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    static void Update()
    {
            var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
            var constr = config.GetSection("constr").Value;
            var conn = new SqlConnection(constr);

            string st = "update Branch set Name = @Name where Id = @Id";
            SqlParameter Name_par = new SqlParameter
            {
                ParameterName="Name",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Ahmed"
            };

            SqlParameter Id_par = new SqlParameter
            {
                ParameterName ="Id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = 14
            };
            SqlCommand cmd = new SqlCommand(st,conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(Name_par);
            cmd.Parameters.Add(Id_par);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
     }

    static void Delete()
    {
            var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
            var constr = config.GetSection("constr").Value;
            var conn = new SqlConnection(constr);

            string st = "delete from Branch where Id = @Id";
            SqlCommand cmd = new SqlCommand(st,conn);
            cmd.CommandType = CommandType.Text;
            SqlParameter Id_par = new SqlParameter
            {
                ParameterName = "Id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = 14
            };
            cmd.Parameters.Add(Id_par);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
    }

   }

}
