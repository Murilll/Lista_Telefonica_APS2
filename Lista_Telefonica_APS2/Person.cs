using System.Runtime.CompilerServices;

namespace Lista_Telefonica_APS2;

public class Person
{
    public int Identifier { get; set; }
    public string Name { get; set; }
    public string Telephone { get; set; }

    public Person(int identifier, string name, string telephone)
    {
        this.Identifier = identifier;
        this.Name = name;
        this.Telephone = telephone;
    }
}