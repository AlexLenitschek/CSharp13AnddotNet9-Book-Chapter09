using System.Xml.Serialization; // To use XmlSerializer.
using Packt.Shared; // To use Person.


// Create a list of Shapes to serialize.
List<Shape> shapes = new()
{
  new Circle { Colour = "Red", Radius = 2.5 },
  new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
  new Circle { Colour = "Green", Radius = 8.0 },
  new Circle { Colour = "Purple", Radius = 12.3 },
  new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 },
};



// Serialize the list of shapes to a Xml file.
XmlSerializer serializerXml = new(type: shapes.GetType());
string path = Combine(CurrentDirectory, "shapes.xml");

using (FileStream stream = File.Create(path))
{
    serializerXml.Serialize(stream, shapes);
    // Closes the stream.
}



// Deserialize the list of shapes from the Xml file.
using (FileStream fileXml = File.Open(path, FileMode.Open))
{ 
    List<Shape>? loadedShapesXml = serializerXml.Deserialize(fileXml) as List<Shape>;

    foreach (Shape item in loadedShapesXml!)
    {
        WriteLine("{0} is {1} and has an area of {2:N2}", item.GetType().Name, item.Colour, item.Area);
    }
}