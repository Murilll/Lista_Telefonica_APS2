using Lista_Telefonica_APS2;
using System.Security.Cryptography.X509Certificates;

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
        Console.WriteLine("-------  Phone book -------\n");
        foreach (var item in Contact)
        {
            System.Console.WriteLine($"ID: {item.Identifier}\nName: {item.Name}\nTelephone: {item.Telephone}\n");
        }
        Console.WriteLine("---------------------------");
    }

    public void SearchForContactByPhone(string number)
    {
        foreach (var item in Contact)
            if (item.Telephone == number)
                Console.WriteLine($"ID: {item.Identifier}\nName: {item.Name}\nTelephone: {item.Telephone}\n");
    }

    public void SearchForContactByNameLinq(string name)
    {
        List<Person> SearchName = Contact.Where(x => x.Name == name).ToList();
        Console.WriteLine(SearchName);
    }

    public void SearchForContactByName(string name)
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
                Console.WriteLine($"Successfully Deleted.");
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
                Console.WriteLine($"Successfully Deleted.");
                Contact.Remove(item);
            }
        }

        return result;
    }

    public void DeleteContactByNameUsingLinq(string name)
    {
        List<Person> SearchName = Contact.Where(x => x.Name == name).ToList();
        // SearchName.Remove();

        Console.WriteLine("Successfully Deleted."); 
    }

    public List<Person> SortContactsByName()
    {
        List<Person> SortedByName = Contact.OrderBy(x => x.Name).ToList();
        foreach (var item in SortedByName)
        {
            System.Console.WriteLine($"ID: {item.Identifier}\nName: {item.Name}\nTelephone: {item.Telephone}\n");
        }

        return SortedByName;
    }

    public List<Person> SortContactsByNumber()
    {
        List<Person> SortedByName = Contact.OrderBy(x => x.Telephone).ToList();
        foreach (var item in SortedByName)
        {
            System.Console.WriteLine($"ID: {item.Identifier}\nName: {item.Name}\nTelephone: {item.Telephone}\n");
        }

        return SortedByName;
    }
}