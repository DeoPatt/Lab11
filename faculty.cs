using System;


class Faculty : Person
{
public string Id{get;set;}
public string Title{get;set;}
public  DateTime DateOfEmployment;
public string Employer{get;set;}
public double YearlySalary{get;set;}
public bool Tenured{get;set;}
public double yearsOfExp;




public Faculty() : base() 
{

  Title = "Instructor";
}
public Faculty(string FirstName, string LastName) : base(FirstName, LastName)
{
  Title = "Instructor";
  FirstName = FirstName;
  LastName = LastName;
}
 public void GrantTenure()
        {
          yearsOfExp = DateTime.Today.Year - DateOfEmployment.Year;

          if (DateTime.Today.Year == DateOfEmployment.Year && yearsOfExp >= 5 )
          Tenured = true;
          else
           Tenured = false;
         
         
          
       /* Console.WriteLine("years of experience is " + yearsOfExp);//test */
        }
public void Promote()
{
if (Title == "Instructor" && yearsOfExp > 2 ){
Title = "Assistant Professor";
Console.WriteLine("Promoted to Assistant professor");
}

  if(Title == "Assistant Professor" && yearsOfExp > 5){
Title = "Associate Professor";
Console.WriteLine("Promoted to " + Title);
 }
  if (Title == "Associate Professor" && yearsOfExp > 10){
Title = "Professsor";
Console.WriteLine("Promoted to Professor");
  }
if(Title == "Professor"){
Console.WriteLine("No more Promotions availble");

 
}
}
public override void Intro()
{
 
  Console.WriteLine("I work as a " + Title + " at tric since " + DateOfEmployment);
}
public void Intro2()
{
  Console.WriteLine("my firstname is " + FirstName);
  Console.WriteLine("My lastname is " + LastName);
   
}
}
