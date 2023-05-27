using Lista_Telefonica_APS2;

Function Funções = new Function();

Person people = new Person(1, "Murilo", "41999999");
Console.WriteLine("");



Funções.AddPerson(people);



Funções.DeleteContactsByNumber("41999999");


foreach (var item in Funções.Contact)
{
    Console.WriteLine(item.Name);
}

Funções.DeleteContactsByNumber("41999999");


Funções.DeleteContactsByNumber("41999999");