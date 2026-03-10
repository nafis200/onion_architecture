

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


// interface

public interface IStudentRepository
{
     public void Add(Student student);

    public void Remove(Student student);

    public Student update(Student student);

}


public interface ICourseRepository
{
     public void Add(Course student);

    public void Remove(Course student);

    public Course update(Course student);

}


public interface ITrainerRepository
{
     public void Add(Trainer student);

    public void Remove(Trainer student);

    public Trainer update(Trainer student);

}


// Repositories

public class StudentRepository : IStudentRepository
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

public class TrainerRepository : ITrainerRepository
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


public class CourseRepository : ICourseRepository
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

// Services -- Business Logic

public class StudentServices
{
    IStudentRepository studentRepository;

    public StudentServices(IStudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
    }

    public void Add(Student student)
    {
        studentRepository.Add(student);
    }

    public void remove(Student student )
    {
        studentRepository.Remove(student);
    }
}



public class TrainerServices
{
    ITrainerRepository trainerRepository;

    public TrainerServices(ITrainerRepository trainerRepository)
    {
        this.trainerRepository = trainerRepository;
    }

    public void Add(Trainer train)
    {
        trainerRepository.Add(train);
    }

    public void remove(Trainer train)
    {
        trainerRepository.Remove(train);
    }
}

public class CourseServices
{
    ICourseRepository courseRepository;

    public CourseServices(ICourseRepository courseRepository)
    {
        this.courseRepository = courseRepository;
    }

    public void Add(Course course)
    {
        courseRepository.Add(course);
    }

    public void remove(Course course)
    {
        courseRepository.Remove(course);
    }
}




class Program
{
    public static void Main()
    {

    }
}