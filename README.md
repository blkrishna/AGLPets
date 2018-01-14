# AGL.CodingExcercise a coding challenge task (See the coding challenge description below).

INSTRUCTIONS

1. Download solution

2. Download the Nuget packages (Newtonsoft.Json)

3. Build solution

4. Execute the Utiltiy Project

6. Execute the Unit Tests project

7. Execute the Web Project, navigate to the PetsTest.html page to run the JavaScript unit tests

SOLUTION DESCRIPTION

The solution consists of 5 projects.

1. AGL.Pets.Common contains interfaces used for dependency injection (Castle).
 
2. AGL.Pets.Domain contains two classes (Person, Pet) used to deserialize the Json data etc.
 
3. AGL.Pets.UnitTests contains tests for the PersonsRepository.GetPets... 
 
4. AGL.Pets.Utiltity is a Windows Console app project. This project defines a PersonRepository class which is used to list Pets in the requested structure described by the coding challenge.

5. A web project to demonstrate a testable JavaScript version

The Utiltity project also defines a DataContext class that is used by the repository to retrieve data. This DataContext class is an implementation of an IDataContext class which is injected (using Property Injection and the Castle Window IoC framework).
The concrete implementations of IDataContext includes a version which does not download Json data from the API service called FakeDataContext. This is useful for debugging, so the WindowsInstaller defines this as the concrete class for IDataContext given a pre-compiler directive of DEBUG.

Three Unit Tests target the PersonReporitoy method GetCatsByOwnerGender. The tests cover three cases:

1. Valid data and successful execution

2. Border case valid data and successful execution

3. Invalid data with an expected exception

NOTE


Further improvements would include 

1. Custom exception handling.

2. Extracting the DataContext and Repositories to a seperate project


PROGRAMMING CHALLENGE

The following describes a Programming challenge for this coding exercise.
A json web service has been set up at the url: http://agl-developer-test.azurewebsites.net/people.json
You need to write some code to consume the json and output a list of all the cats in alphabetical order under a heading of the gender of their owner.
You can write it in any language you like. You can use any libraries/frameworks/SDKs you choose.
Example:
Male
  Angel
  Molly
  Tigger
Female
  Gizmo
  Jasper

Notes

Use of language features and/or libraries for grouping/sorting is encouraged. Eg: C# -> LINQ, Java8 -> Stream API, Javascript -> Lodash, Python -> List comprehension
Use of libraries for consumption of web services is encouraged. Eg: C# -> HttpClient, Java -> HttpClient, Javascript -> jQuery
You can write it in your favourite Text Editor/IDE
Submissions will only be accepted via a fiddle or github or bitbucket


