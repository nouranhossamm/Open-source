using System; 

namespace Task;  

public abstract class Person{
    public string Name;
    public int Age;

    public Person(string name , int age){
      Name = name;
      Age = age;
    }
    public abstract void Print();

}

public class Student : Person {
public int Year;
public float Gpa;

  public Student(string name , int age,  int year, float gpa) : base(name , age){
    Year = year;
    Gpa = gpa;
  }

  public override void Print(){
    Console.WriteLine($"My name is{Name}, my age is {Age}, and gpa is {Gpa}");
  }
}


public class Database{
  
  int _currentIndex;
  int _stuffMember;

  public Person[] People = new Person[50];
  public Staff[] Staff = new Staff[50];

  public void AddStudent(Student student){
    // if( _currentIndex == 49) return;
    People[_currentIndex++] = student;
  } 

  public void AddStaff(Staff staff){
    Staff[_stuffMember++] = staff;
  } 
}

public class Staff : Person {
  public double Salary;
  public int JoinYear;

  public Staff(string name , int age, double salary, int joinYear) : base(name , age){
    Salary = salary;
    JoinYear = joinYear;
  }

public override void Print(){
    Console.WriteLine($"My name is{Name}, my age is {Age}, and my salary is {Salary}");
  }

}



public class Task
{
  private static void Main()
  {
    // Console.Write("Hello, World");
    // student
      var database = new Database();
      
      Console.Write("Name: ");
      var name = Console.ReadLine();
      Console.Write("Age: ");
      var age = Convert.ToInt32(Console.ReadLine());
      Console.Write("Year: ");
      var year = Convert.ToInt32(Console.ReadLine());
      Console.Write("Gpa: ");
      var gpa = Convert.ToSingle(Console.ReadLine());
      
      var student = new Student(name, age, year, gpa);
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



      database.AddStudent(student);
      database.AddStaff(staff);
  
  }  
};
