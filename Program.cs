

// Model (relation with database)
// view model (no relation with database)


// Database

public class Database
{
    public IList<Student> students;
    public IList<Course> courses;
    public IList<Trainer> trainers;

    public Database()
    {
        students = new List<Student>();
        courses = new List<Course>();
        trainers = new List<Trainer>();
    }
}

// Model of student, course, trainer
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class Trainer
{
    public int TrainerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }
}

// Repositories

public class StudentRepository
{
   Database db;
   public StudentRepository(Database db)
    {
        this.db = db;
    }

    public void Add(Student student)
    {
       db.students.Add(student);   
    }

    public void Remove(Student student)
    {
        
    }

    public Student update(Student student)
    {
        return student;
    }
}

public class TrainerRepository
{
    Database db;
    public TrainerRepository(Database db)
    {
        this.db = db;
    }
    public void Add(Trainer student)
    {
        db.trainers.Add(student);
    }

    public void Remove(Trainer student)
    {
        
    }

    public Trainer update(Trainer trainer)
    {
        return trainer;
    }
}


public class CourseRepository
{
    Database db;
    public CourseRepository(Database db)
    {
        this.db = db;
    }
    public void Add(Course course)
    {
        db.courses.Add(course);
    }

    public void Remove(Course course)
    {
        
    }

    public Course update(Course course)
    {
        return course;
    }
}

class Program
{
    public static void Main()
    {

    }
}