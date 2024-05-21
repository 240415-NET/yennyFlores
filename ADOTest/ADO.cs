namespace ADOTest;
using System.Data.SqlClient;

using System;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class ADO{
    
    public static string filePath = @"C:\Users\A261982\OneDrive - Government Employees Insurance Company\revature\connectionString.txt";

    public static string connectionString = File.ReadAllText(filePath);

    public static void Read(){


        using SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        string cmdText =
                @"SELECT ModifiedPersonID, fname, lname, CityOfResidence FROM personTest";

        //So we use the parameterized string above to create a SqlCommand object. 
        using SqlCommand cmd = new SqlCommand(cmdText, connection);

        using SqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read()){
            Console.WriteLine($"ModifiedPersonID {reader.GetString(0)} , fname {reader.GetString(1)} , lname {reader.GetString(2)},  CityOfResidence {reader.GetString(3)} ");
        }

    }
} 