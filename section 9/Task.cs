using System; 

namespace Task;  

public class Person{
    public string Name;
    public int Age;

    public Person(string name , int age){
      Name = name;
      Age = age;
    }
    public void Print(){
      Console.WriteLine($"My name is {Name}, my age is {Age}");
    }

}

public class Student : Person {
public int Year;
public float Gpa;

  public Student(string name , int age,  int year, float gpa) : base(name , age){
    Year = year;
    Gpa = gpa;
  }

  public void Print(){
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
    Salary = salary;
    JoinYear = joinYear;
  }

public void Print(){
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
            
            var student = new Student(name, age, year, gpa);
            database.AddStudent(student);
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

            var staff = new Staff(name1, age1, salary, joinYear);
            database.AddStaff(staff);
            break;
          case 3:
            Console.Write("Name: ");
            var name2 = Console.ReadLine();
            Console.Write("Age: ");
            var age2 = Convert.ToInt32(Console.ReadLine());

            var person = new Person(name2, age2);
            database.AddPerson(person);
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
