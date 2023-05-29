using Lista_Telefonica_APS2;

Function Functions = new Function();

Person people = new Person(1, "Murilo", "41999999");
Person people1 = new Person(2, "fdsaf", "543654");
Person people2 = new Person(3, "ghfsh", "543654");
Person people3 = new Person(4, "hgtejeh", "435643");


Functions.AddPerson(people);
Functions.AddPerson(people1);
Functions.AddPerson(people2);
Functions.AddPerson(people3);


//Functions.GetPerson();
//Functions.SearchForContactByPhone();
//Functions.SearchForContactByName();
//Functions.SearchForContactByNameLinq;
//Functions.DeleteContactsByName();
//Functions.DeleteContactsByNumber();
//Functions.SortContactsByName();
//Functions.SortContactsByNumber();

string phone;
string name;

while (true)
{
    Console.WriteLine("1 - GetPerson\n" +
        "2 - SearchForContactByPhone\n" +
        "3 - SearchForContactByName\n" +
        "4 - DeleteContactsByName\n" +
        "5 - DeleteContactsByNumber\n" +
        "6 - SortContactsByName\n" +
        "7 - SortContactsByNumber\n" +
        "8 - Close");

    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            { 
                Functions.GetPerson();
                break;
            }

        case 2:
            {
                Console.WriteLine("Enter the phone number.");
                phone = Console.ReadLine();
                Functions.SearchForContactByPhone(phone);
                break;
            }

        case 3:
            {
                Console.WriteLine("Enter the phone name.");
                name = Console.ReadLine();
                Functions.SearchForContactByPhone(name);
                break;
            }

        case 4:
            {
                Console.WriteLine("Enter a name for the contact to be deleted.");
                name = Console.ReadLine();
                Functions.DeleteContactsByName(name);
                break;
            }

        case 5:
            {
                Console.WriteLine("Enter a phone for the contact to be deleted.");
                phone = Console.ReadLine();
                Functions.DeleteContactsByName(phone);
                break;
            }

        case 6:
            {
                Functions.SortContactsByName();
                break;
            }

        case 7:
            {
                Functions.SortContactsByNumber();
                break;
            }

        case 8:
            break;
    }
}