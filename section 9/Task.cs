using System; 

namespace Task;  

public class Person{
    public string Name;
    public int Age;

    public Person(string name , int age){

      if(name == null || name == "" || name.Length >=32)
      {
        throw new Exception("Invalid Name");
      }

      if(age <= 0 || age > 128)
      {
        throw new Exception("Invalid Age");
      }

      Name = name;
      Age = age;
    }
    public virtual void Print(){
      Console.WriteLine($"My name is {Name}, my age is {Age}");
    }
}

public class Student : Person {
public int Year;
public float Gpa;

  public Student(string name , int age,  int year, float gpa) : base(name , age){

    if(year >= 1 && year <= 5)
    {
      throw new Exception("Invalid Year");
    }

    if(gpa >= 0 && gpa <= 4)
    {
      throw new Exception("Invalid Gpa");
    }

    Year = year;
    Gpa = gpa;
  }

  public override void Print(){
    Console.WriteLine($"My name is {Name}, my age is {Age}, and gpa is {Gpa}");
  }
}


public class Database{
  
  int _currentIndex;

  public Person[] People = new Person[50];

  public void AddStudent(Student student){
    // if( _currentIndex == 49) return;
    People[_currentIndex++] = student;
  } 

  public void AddStaff(Staff staff){
    People[_currentIndex++] = staff;
  }

  public void AddPerson(Person person){
    People[_currentIndex++] = person;
  } 
  public void PrintAll(){
    for(var i = 0 ; i < _currentIndex; i++){
        People[i].Print();
    }
  } 

}

public class Staff : Person {
  public double Salary;
  public int JoinYear;

  public Staff(string name , int age, double salary, int joinYear) : base(name , age){

       if(salary > 0 && salary < 120_000)
    {
      throw new Exception("Invalid Salary");
    }

    if(joinYear > 21)
    {
      throw new Exception("Invalid JoinYear");
    }


    Salary = salary;
    JoinYear = joinYear;
  }

public override void Print(){
    Console.WriteLine($"My name is {Name}, my age is {Age}, and my salary is {Salary}");
  }

}

public class Task
{
  private static void Main()
  {
    // Console.Write("Hello, World");
      var database = new Database();

      while(true){
        Console.WriteLine("1.Student 2.Staff 3.Person 4.Print All");
        Console.WriteLine("Option: ");
        var option = Convert.ToInt32(Console.ReadLine());

        switch(option){
          case 1:
            // student         
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gpa: ");
            var gpa = Convert.ToSingle(Console.ReadLine());
            
            try{
              var student = new Student(name, age, year, gpa);
              database.AddStudent(student);
            }
            catch(Exception e)
            {
              Console.WriteLine(e.Message);
            }
            break;
          case 2:
            // staff
            Console.Write("Name: ");
            var name1 = Console.ReadLine();
            Console.Write("Age: ");
            var age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary: ");
            var salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("JoinYear: ");
            var joinYear = Convert.ToInt32(Console.ReadLine());

            try{
              var staff = new Staff(name1, age1, salary, joinYear);
              database.AddStaff(staff);
            }
            catch(Exception e)
            {
              Console.WriteLine(e.Message);
            }
            break;
          case 3:
            Console.Write("Name: ");
            var name2 = Console.ReadLine();
            Console.Write("Age: ");
            var age2 = Convert.ToInt32(Console.ReadLine());

            try{
              var person = new Person(name2, age2);
              database.AddPerson(person);
            }
            catch(Exception e)
            {
              Console.WriteLine(e.Message);
            }
            break;
          case 4:
            database.PrintAll();
            break;
          default:
            return;
        }
      } 
  }  
};
