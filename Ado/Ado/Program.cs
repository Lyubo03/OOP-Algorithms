namespace Ado
{
    using System;
    using System.Data.SqlClient;

    public class Program
    {
        private static SqlCommand command;
        private static SqlConnection connection;
        public static void Main()
        {//zad8
            int id = int.Parse(Console.ReadLine());

            connection = new SqlConnection(@"Server=DESKTOP-2RO7KG1\SQLEXPRESS;Database=MinionsDb;Integrated Security=true");
            command = connection.CreateCommand();
            command.Connection = connection;

            connection.Open();
            using (connection)
            {
                try
                {
                command.CommandText = $"EXEC usp_GetOlder @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                command.CommandText = @"SELECT * FROM Minions";
                var reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[1]} - {reader[2]} years old");
                    }
                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
//zad8
//int[] ids = Console.ReadLine().Split().Select(int.Parse).ToArray();

//connection = new SqlConnection(@"Server=DESKTOP-2RO7KG1\SQLEXPRESS;Database=MinionsDb;Integrated Security=true");
//command = connection.CreateCommand();
//            command.Connection = connection;

//            connection.Open();
//            using (connection)
//            {
//                for (int i = 0; i<ids.Length; i++)
//                {
//                    command.CommandText = $"UPDATE Minions SET Age += 1 WHERE Id = {ids[i]}";
//                    command.ExecuteNonQuery();
//                }

//                command.CommandText = @"SELECT * FROM Minions";
//                var reader = command.ExecuteReader();

//                using (reader)
//                {
//                    while (reader.Read())
//                    {
//                        Console.WriteLine($"{reader[1]} {reader[2]}");
//                    }
//                }
//            }
//zad7
//int n = 1;
//connection = new SqlConnection(@"Server =DESKTOP-2RO7KG1\SQLEXPRESS;Database=MinionsDb;Integrated Security=true");
//command = connection.CreateCommand();
//command.Connection = connection;


//connection.Open();
//using (connection)
//{
//    command.CommandText = "SELECT MAX(rowNum) FROM(SELECT Id, [Name], ROW_NUMBER() OVER(ORDER BY Id) AS rowNum FROM Minions) as k";
//    double countOfRows = (Int64)command.ExecuteScalar();
//    while (n < countOfRows)
//    {
//        command.CommandText = $"SELECT Name FROM(SELECT[Name], ROW_NUMBER() OVER(ORDER BY Id) AS rowNum FROM Minions) as k WHERE k.rowNum = {n}";
//        Console.WriteLine(command.ExecuteScalar());

//        command.CommandText = $"SELECT Name FROM(SELECT[Name], ROW_NUMBER() OVER(ORDER BY Id) AS rowNum FROM Minions) as k WHERE k.rowNum = {countOfRows}";
//        Console.WriteLine(command.ExecuteScalar());

//        countOfRows--;
//        n++;
//    }
//}
//zad6
//     int id = int.Parse(Console.ReadLine());
//connection = new SqlConnection(@"Server=DESKTOP-2RO7KG1\SQLEXPRESS; Database=MinionsDb;Integrated Security=true");
//connection.Open();
//            using (connection)
//            {
//                transaction = connection.BeginTransaction("RemoveVillain");
//                command = connection.CreateCommand();
//                command.Connection = connection;
//                command.Transaction = transaction;
//                try
//                {
//                    command.CommandText = $"SELECT Name FROM Villains WHERE Id = {id}";
//                    var villainName = command.ExecuteScalar();
//                    if (villainName == null)
//                    {
//                        transaction.Rollback();
//                        Console.WriteLine("No such villain was found.");
//                        return;
//                    }

//                    command.CommandText = $"SELECT COUNT(MinionId) FROM MinionsVillains GROUP BY VillainId HAVING VillainId = {id}";
//                    var minionsCount = command.ExecuteScalar();

//                    if (minionsCount == null)
//                    {
//                        minionsCount = 0;
//                    }
//                    command.CommandText = $"DELETE FROM MinionsVillains WHERE VillainId = {id}";
//                    command.ExecuteNonQuery();

//                    command.CommandText = $"DELETE FROM Villains WHERE Id = {id}";
//                    command.ExecuteNonQuery();

//                    transaction.Commit();
//                    Console.WriteLine($"{villainName} was deleted.{Environment.NewLine}{minionsCount} minions were released.");

//                }
//                catch (Exception ex)
//                {
//                    try
//                    {
//                        Console.WriteLine(ex.Message);
//                        transaction.Rollback();
//                    }
//                    catch (Exception e)
//                    {
//                        Console.WriteLine(e.Message);
//                    }

//                }

//            }
//var connection = new SqlConnection(@"Server=DESKTOP-2RO7KG1\SQLEXPRESS;Database=MinionsDb;Integrated Security=true");
//connection.Open();
//            using (connection)
//            {
//                string text = "SELECT v.Name, Count(MinionId) AS MinionCount FROM Villains v JOIN MinionsVillains mv ON mv.VillainId = v.Id GROUP BY v.Id,v.Name HAVING COUNT(MinionId) > 3 ORDER BY MinionCount DESC";
//                try
//                {
//                    var command = new SqlCommand(text, connection);
//var reader = command.ExecuteReader();

//                    using (reader)
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"{reader[0]} - {reader[1]}");
//                        }
//                    }
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e.Message);
//                }
//int n = int.Parse(Console.ReadLine());
//var connection = new SqlConnection(@"Server=DESKTOP-2RO7KG1\SQLEXPRESS;Database=MinionsDb;Integrated Security=true");
//connection.Open();

//            using (connection)
//            {
//                string villian = $@"SELECT Name FROM Villains WHERE Id = {n}";
//string minions = @$"SELECT ROW_NUMBER() OVER(ORDER BY m.Name) AS RowNum, m.Name, m.Age FROM MinionsVillains mv JOIN Villains v ON mv.VillainId = v.Id JOIN Minions m ON m.Id = mv.MinionId WHERE mv.VillainId = {n}";
//                try
//                {
//                    var command = new SqlCommand(villian, connection);
//var villianReader = (string)command.ExecuteScalar();
//                    if (villianReader == null)
//                    {
//                        Console.WriteLine($"No villain with ID {n} exists in the database.");
//                        return;
//                    }
//                    Console.WriteLine($@"Villain: {villianReader}");
//                    command = new SqlCommand(minions, connection);
//var minionReader = command.ExecuteReader();

//                    using (minionReader)
//                    {
//                        if (!minionReader.HasRows)
//                        {
//                            Console.WriteLine($"(no minions)");
//                            return;
//                        }

//                        while (minionReader.Read())
//                        {
//                            Console.WriteLine(@$"{minionReader[0]}. {minionReader[1]} {minionReader[2]}");
//                        }
//                    }
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e.Message);
//                }

//            }
//string[] minion = Console.ReadLine().Split().ToArray();
//string minionName = minion[1];
//int age = int.Parse(minion[2]);
//string town = minion[3];

//string[] villain = Console.ReadLine().Split().ToArray();
//string villainName = villain[1];

//var connection = new SqlConnection(@"Server=DESKTOP-2RO7KG1\SQLEXPRESS;Database=MinionsDb;Integrated Security=true");
//connection.Open();

//            using (connection)
//            {
//                query = $@"SELECT * FROM Towns WHERE Name = '{town}'";
//                command = new SqlCommand(query, connection);
//var townId = command.ExecuteScalar();

//                if (townId == null)
//                {
//                    command = new SqlCommand(@$"INSERT INTO Towns (Name) VALUES ('{town}')", connection);
//command.ExecuteNonQuery();
//                    Console.WriteLine($@"Town {town} was added to the database.");
//                }

//                query = @$"SELECT Id FROM Villains WHERE Name = '{villainName}'";
//                command = new SqlCommand(query, connection);
//var villainId = command.ExecuteScalar();

//                if (villainId == null)
//                {
//                    command = new SqlCommand($@"INSERT INTO Villains(Name, EvilnessFactorId) VALUES ('{villainName}', 4)", connection);
//Console.WriteLine($"Villain {villainName} was added to the database.");
//                }

//                command = new SqlCommand($@"SELECT Id FROM Minions WHERE Name = {minionName}", connection);
//var minionId = command.ExecuteScalar();

//                if (minionId == null)
//                {
//                    command = new SqlCommand($@"INSERT INTO Minions (Name, Age, TownId) VALUES ({minionName}, {age}, {townId})", connection);
//                }

//                query = @$"INSERT INTO MinionsVillians (MinionId, VillainId) VALUES({minionName}, {villainId})";
//                command = new SqlCommand(query, connection);

//Console.WriteLine($@"Successfully added {minionName} to be minion of {villainName}.");
//string country = Console.ReadLine();
//var connection = new SqlConnection(@"Server=DESKTOP-2RO7KG1\SQLEXPRESS;Database=MinionsDb;Integrated Security=true");
//connection.Open();

//            using (connection)
//            {
//                query = $"SELECT * FROM Countries c WHERE c.Name = '{country}'";
//                command = new SqlCommand(query, connection);
//var countryId = command.ExecuteScalar();
//                if (countryId == null)
//                {
//                    Console.WriteLine("No town names were affected.");
//                    return;
//                }
//                query = $"UPDATE Towns SET [Name] = UPPER([Name]) WHERE CountryCode = {countryId}";
//                command = new SqlCommand(query, connection);
//command.ExecuteNonQuery();


//                query = $"SELECT COUNT(t.Name) FROM Towns t JOIN Countries c ON t.CountryCode = c.Id GROUP BY t.CountryCode, c.Name HAVING t.CountryCode = {countryId}";
//                command = new SqlCommand(query, connection);
//var countOfTowns = command.ExecuteScalar();

//                if (countOfTowns == null)
//                {
//                    Console.WriteLine("No town names were affected.");
//                }
//                else
//                {
//                    Console.WriteLine(@$"{countOfTowns} town names were affected.");

//                    query = $"SELECT [Name] FROM Towns WHERE CountryCode = {countryId}";
//                    command = new SqlCommand(query, connection);
//var reader = command.ExecuteReader();

//                    using (reader)
//                    {
//                        List<string> towns = new List<string>();
//                        while (reader.Read())
//                        {
//                            towns.Add(reader[0].ToString());
//                        }
//                        Console.WriteLine($"[{string.Join(", ",towns)}]");
//                    }

//                }