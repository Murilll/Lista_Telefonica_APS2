﻿using Lista_Telefonica_APS2;

Function Funtions = new Function();

Person people = new Person(1, "Murilo", "41999999");
Person people1 = new Person(2, "fdsaf", "543654");
Person people2 = new Person(3, "ghfsh", "543654");
Person people3 = new Person(4, "hgtejeh", "435643");
Person people4 = new Person(5, "uryth", "41999999");
Person people11 = new Person(6, "htrwhtr", "543654");
Person people22 = new Person(7, "jytw", "543654");
Person people33 = new Person(8, "jywyw", "435643");

Console.WriteLine("");



Funtions.AddPerson(people);
Funtions.AddPerson(people1);
Funtions.AddPerson(people2);
Funtions.AddPerson(people3);


Funtions.SearchForFontactByName("fdsaf");

Funtions.SearchForFontactByPhone("435643");

// Funtions.DeleteContactsByName("ghfsh");


// Funtions.DeleteContactsByNumber("41999999");


Funtions.GetPerson();

// Funtions.DeleteContactsByNumber("41999999");


// Funtions.DeleteContactsByNumber("41999999");