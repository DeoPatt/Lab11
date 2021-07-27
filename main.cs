using System;


class MainClass {
  public static void Main (string[] args) {
    
    /*Console.WriteLine("Testing Address");
    Address addr1 = new Address();
    addr1.AddressLine1="1234 Main St";
    addr1.AddressLine2="Apt 102";
    addr1.City = "Cleveland";
    addr1.State = "azzffdsfd";
    addr1.Zipcode = "44143";

    addr1.Display();*/

   /* Console.WriteLine("Testing Person");
    Person p1 = new Person();
    p1.FirstName = "John";
    p1.LastName = "Smith";
    p1.PermanentAddress.AddressLine1 = "1234 Main St";
    p1.PermanentAddress.City = "Cleveland";
    p1.PermanentAddress.State = "OH";
    p1.PermanentAddress.Zipcode = "44143";
    p1.DateOfBirth = Convert.ToDateTime("07/13/1994");
    p1.Intro();
    p1.IsBirthday();  */

   /* Console.WriteLine("Testing Student 1");
    Student s1 = new Student();
    s1.FirstName = "Kara";
    s1.LastName="Kaiser";
    s1.DateOfBirth = Convert.ToDateTime("01/01/2020");
    s1.PermanentAddress.AddressLine1 = "999 Mallard Dr";
    s1.PermanentAddress.City = "Parma";
    s1.PermanentAddress.State = "OH";
    s1.PermanentAddress.Zipcode = "44143";
    s1.GPA = 2.1;
    s1.School = "Cleveland State University";
    s1.Intro();
    s1.IsBirthday();
    s1.SetAcademicStanding();
    Console.WriteLine(s1.AcademicStanding);*/


  /*  Console.WriteLine("Testing Student 2");
    Student s2 = new Student("Andrew", "Peggman");    
    s2.DateOfBirth = Convert.ToDateTime("01/01/1989");
    s2.PermanentAddress.AddressLine1 = "999 Mallard Dr";
    s2.PermanentAddress.City = "Parma";
    s2.PermanentAddress.State = "OH";
    s2.PermanentAddress.Zipcode = "44143";
    s2.GPA = 2.75;
    s2.School = "Ohio State University";
    s2.Intro();
    s2.IsBirthday();
    s2.SetAcademicStanding();
    Console.WriteLine(s2.AcademicStanding);*/ 
    
  
        Faculty f1 = new Faculty();
  
   
        
           f1.DateOfEmployment = Convert.ToDateTime("01/01/2009");


    f1.FirstName = "deo";
   f1.LastName = "patt";
   f1.Intro2();
   f1.Intro();
      
  f1.Title = "Professor";
   f1.GrantTenure();
  
  Console.WriteLine("My years of experience now is " + f1.yearsOfExp + " years");
  Console.WriteLine("My title is " + f1.Title);
  f1.Promote();
 
 Faculty f2 = new Faculty();
      f2.DateOfEmployment = Convert.ToDateTime("01/01/2015");


    f2.FirstName = "joe";
   f2.LastName = "pete";
   f2.Intro2();
   
      
  f2.Title = "Assistant Professor";
  f2.Intro();
   f2.GrantTenure();
  
  Console.WriteLine("My years of experience now is " + f2.yearsOfExp + " years");
 
  f2.Promote();
 

 Faculty f3 = new Faculty();
      f3.DateOfEmployment = Convert.ToDateTime("01/01/2009");


    f3.FirstName = "diamond";
   f3.LastName = "ruby";
   f3.Intro2();
   
      
  f3.Title = "Associate Professor";
  f3.Intro();
   f3.GrantTenure();
  
  Console.WriteLine("My years of experience now is " + f3.yearsOfExp + " years");
 
  f3.Promote();


  Faculty f4 = new Faculty();
      f4.DateOfEmployment = Convert.ToDateTime("01/01/2018");


    f4.FirstName = "diamond";
   f4.LastName = "ruby";
   f4.Intro2();
   
      
  f4.Title = "Instructor";
  f4.Intro();
   f4.GrantTenure();
  
  Console.WriteLine("My years of experience now is " + f4.yearsOfExp + " years");
 
  f4.Promote();
  
  }
}