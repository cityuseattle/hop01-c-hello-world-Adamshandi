using System.Data.SQLite;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class SqliteService 
    {
         
        string stm= "SELECT SQLITE_VERSION()"; //select SQLite version

        static string dbFile= @"URI=file:.\test.db"; //database file

        static SQLiteConnection con;

        //constructor
        public SqliteService(){
            con = new SQLiteConnection(dbFile); //connect the app to database
            con.Open(); // open the connection
        }
        
        // actual connection, return version of databse
        public string connectDB(){
            using var cmd= new SQLiteCommand(stm, con);
            string version= cmd.ExecuteScalar().ToString();
            return version;
        }
        public void createTable(){
            using var cmd= new SQLiteCommand(con);
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS member(id INTEGER PRIMARY KEY,
            name TEXT, password TEXT) "; // SQL command, create table if not exist already
            cmd.ExecuteNonQuery();
        }

        // create member inside table 
        public void createNewMember(){
            using var cmd= new SQLiteCommand(con);
            cmd.CommandText="INSERT INTO member(name, password) VALUES('Adam','cityu') ";
            cmd.ExecuteNonQuery();
        }

        public Task<MemberData> querymember(){
            string stm= "SELECT * FROM member LIMIT 1";
            using var cmd= new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr= cmd.ExecuteReader();
            string name= "";
            string password="";

            while(rdr.Read()){
                name= rdr.GetString(1);
                password=rdr.GetString(2);
            }
            return Task.FromResult(new MemberData {
                Name=name,
                Password=password
            });
        }
    }
}