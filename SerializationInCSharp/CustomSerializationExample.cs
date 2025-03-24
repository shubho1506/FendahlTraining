using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class CustomEmployee : ISerializable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public CustomEmployee() { }

    // Custom serialization logic
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("EmployeeName", Name);
        info.AddValue("EmployeeAge", Age);
    }

    // Custom deserialization logic
    public CustomEmployee(SerializationInfo info, StreamingContext context)
    {
        Name = info.GetString("EmployeeName");
        Age = info.GetInt32("EmployeeAge");
    }
}

class CustomSerializationExample
{
    public void Serialize()
    {
        CustomEmployee emp = new CustomEmployee { Name = "David", Age = 40 };

        using (FileStream fs = new FileStream("custom_employee.dat", FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, emp);
        }

        Console.WriteLine("Custom Serialization Complete!");
    }

    public void Deserialize()
    {
        using (FileStream fs = new FileStream("custom_employee.dat", FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            CustomEmployee emp = (CustomEmployee)formatter.Deserialize(fs);
            Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}");
        }
    }
}
