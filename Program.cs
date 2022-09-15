// See https://aka.ms/new-console-template for more information
using Exercise7;

Console.WriteLine("Hello, World!");

Student objectStudent = new Student();
objectStudent.Fname = "Bill";
objectStudent.Lname = "Jones";
Console.WriteLine("Student firstname is "+objectStudent.Fname);
string info = "My name is " + objectStudent.Fname + " " + objectStudent.Lname;
objectStudent.SayName(info);

Teacher objectTeacher = new Teacher();
objectTeacher.SayName("Bill Smith");
