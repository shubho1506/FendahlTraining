using System;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class XmlSerializationExample
{
    public void Serialize()
    {
        Person p = new Person { Name = "Alice", Age = 25 };
        XmlSerializer serializer = new XmlSerializer(typeof(Person));

        using (TextWriter writer = new StreamWriter("person.xml"))
        {
            serializer.Serialize(writer, p);
        }

        Console.WriteLine("XML Serialization Complete!");
    }

    public void Deserialize()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Person));

        using (TextReader reader = new StreamReader("person.xml"))
        {
            Person p = (Person)serializer.Deserialize(reader);
            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
        }
    }
}
