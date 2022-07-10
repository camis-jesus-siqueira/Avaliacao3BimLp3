using Microsoft.Data.Sqlite;

namespace Avaliacao3BimLp3.Database;

class DatabaseSetup 
{
    private readonly DatabaseConfig _databaseConfig ;
    public DatabaseSetup(DatabaseConfig databaseConfig)
  {
      _databaseConfig = databaseConfig;
      CreateStudentsTable();
  
  }
    private void CreateStudentsTable()
    {
        
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();


        var command = connection.CreateCommand();
        command.CommandText = @"
            CREATE TABLE IF NOT EXISTS Computers(
                registration int not null primary key,
                name varchar(100) not null,
                city varchar(100) not null,
                formed bit not null
            );
        ";


        command.ExecuteNonQuery();

        connection.Close();
    }

    
}