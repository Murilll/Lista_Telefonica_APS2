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

public class Function
{
    public List<Person> Contact = new List<Person>();

    string result = "This name does not exist";

    public void AddPerson(Person people)
    {
        Contact.Add(people);
    }

    public void GetPerson()
    {
        foreach (var item in Contact)
        {
            System.Console.WriteLine($"ID: {item.Identifier}\nName: {item.Name}\nTelephone: {item.Telephone}\n");
        }
    }

    public void SearchForFontactByPhone(string number)
    {
        foreach (var item in Contact)
            if (item.Telephone == number)
               Console.WriteLine($"ID: {item.Identifier}\nName: {item.Name}\nTelephone: {item.Telephone}\n");
    }

    public void SearchForFontactByName(string name)
    {
        foreach (var item in Contact)
            if (item.Name == name)
                Console.WriteLine($"ID: {item.Identifier}\nName: {item.Name}\nTelephone: {item.Telephone}\n");
    }

    public string DeleteContactsByNumber(string number)
    {
        foreach (var item in Contact)
        {
            if (item.Name == null)
                return result;

            else if (item.Telephone == number)
            {
                Console.WriteLine($"ID: {item.Identifier}\nName: {item.Name}\nTelephone: {item.Telephone}\nSuccessfully Deleted.");
                Contact.Remove(item);
            }
        }

        return result;
    }

    public string DeleteContactsByName(string name)
    {
        foreach (var item in Contact)
        {
            if (item.Name == null)
                return result;

            else if (item.Name == name)
            {
                Console.WriteLine($"ID: {item.Identifier}\nName: {item.Name}\nTelephone: {item.Telephone}\nSuccessfully Deleted.");
                Contact.Remove(item);
            }
        }

        return result;
    }
}
