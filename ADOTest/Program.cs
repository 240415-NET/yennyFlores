namespace ADOTest;

using System;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Program  
    {  
        public static string filePath = "data.json";
        static void Main(string[] args)  
        {  

            ADO.Read();
            /*List<Person> source = new List<Person>();  
            //read the json file in text
            string json = File.ReadAllText(filePath);
            //convert the text to a json object
            source = JsonSerializer.Deserialize<List<Person>>(json);
            //declare a variable to put the contents of each object in the json file
            ModifiedPerson dr;
            //declare a list to add all instances of dr to
            List<ModifiedPerson> destination = new();

        //for each person in source
        foreach (var s in source)
        {
            //instantiate a new modified person
            dr = new();
            //add data to the instance
            dr.CityOfResidence = s.City;
            dr.ModifiedPersonId = s.Id;
            dr.fname = s.Firstname;
            dr.lname = s.Lastname;
            //add the modified person to the destination list
            destination.Add(dr);
        }

        //transform the object into text
        string jsonString = JsonSerializer.Serialize(destination, new JsonSerializerOptions() { WriteIndented = true});  
        //write the destination list to the file dataReady.json
        File.WriteAllText("dataReady.json", jsonString);
        
        */
        }  
        
    }  
  
    public class Person  
    {  
        public int Id { get; set; }  
        public string Firstname { get; set; }  
        public string Lastname { get; set; }  
        public string City { get; set; }  
    }  
    public class ModifiedPerson  
    {  
        public int ModifiedPersonId { get; set; }  
        public string fname { get; set; }  
        public string lname { get; set; }  
        public string CityOfResidence { get; set; }  
    }