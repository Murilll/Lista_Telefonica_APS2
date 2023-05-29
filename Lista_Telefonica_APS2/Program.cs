using Lista_Telefonica_APS2;

Function Functions = new Function();

Person people = new Person(1, "Murilo", "41999999");
Person people1 = new Person(2, "fdsaf", "543654");
Person people2 = new Person(3, "ghfsh", "543654");
Person people3 = new Person(4, "hgtejeh", "435643");

Console.WriteLine("");

// Functions.AddPerson(people);
Functions.AddPerson(people1);
Functions.AddPerson(people2);
Functions.AddPerson(people3);

// Functions.SearchForContactByName("Murilo");

// Functions.SearchForContactByPhone("435643");

// Functions.SearchForContactByNameLinq("Murilo");

// Functions.DeleteContactsByName("Murilo");

// Functions.DeleteContactsByNumber("41999999");

// Functions.SortContactsByNumber();

 Functions.GetPerson();

// Functions.DeleteContactsByNumber("41999999");

// Functions.DeleteContactsByNumber("41999999");