
<!-- full code follow -->

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



public interface IStudentServices
{
    public void Add(Student student);

    public void Remove(Student student);


}


public interface ICourseServices
{
    public void Add(Course student);

    public void Remove(Course student);


}


public interface ITrainerServices
{
    public void Add(Trainer student);

    public void Remove(Trainer student);


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
        Console.WriteLine("student Repository");
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

public class StudentServices : IStudentServices
{
    IStudentRepository studentRepository;

    public StudentServices(IStudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
    }

    public void Add(Student student)
    {
        Console.WriteLine("student Services");
        studentRepository.Add(student);
    }

    public void Remove(Student student)
    {
        studentRepository.Remove(student);
    }
}



public class TrainerServices : ITrainerServices
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

    public void Remove(Trainer train)
    {
        trainerRepository.Remove(train);
    }
}

public class CourseServices : ICourseServices
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

    public void Remove(Course course)
    {
        courseRepository.Remove(course);
    }
}


// Controller

public class StudentController
{
    public IStudentServices studentServices;

    public StudentController(IStudentServices studentServices)
    {
        this.studentServices = studentServices;
    }
    public void Add(Student student)
    {
        Console.WriteLine("student controller");
        studentServices.Add(student);
    }

    public void Remove(Student student)
    {
         studentServices.Remove(student);
    }
}


public class CourseController
{
    public ICourseServices courseServices;

    public CourseController(ICourseServices courseServices)
    {
        this.courseServices = courseServices;
    }
    public void Add(Course course)
    {
        courseServices.Add(course);
    }

    public void Remove(Course course)
    {
         courseServices.Remove(course);
    }
}


public class TrainerController
{
    public ITrainerServices trainServices;

    public TrainerController(ITrainerServices trainServices)
    {
        this.trainServices = trainServices;
    }
    public void Add(Trainer course)
    {
        trainServices.Add(course);
    }

    public void Remove(Trainer course)
    {
         trainServices.Remove(course);
    }
}

class Program
{
    public static void Main()
    {
       Database db = new Database();

       IStudentRepository studentRepository = new StudentRepository(db);

       IStudentServices studentServices = new StudentServices(studentRepository);
       
       StudentController studentController = new StudentController(studentServices);

       Student students = new Student();

       students.Email="nafis@gmail.com";
       students.Name="Nafis";
       students.StudentId=200129;

       studentController.Add(students);

       students.Email="nabil@gmail.com";
       students.Name="Nabil";
       students.StudentId=200128;

       studentController.Add(students);

       IList<Student> dbstudents = db.students;

       foreach(var x in dbstudents)
        {
            Console.WriteLine($"studennt Email {x.Email}");
            Console.WriteLine($"Student Name {x.Name}");
            Console.WriteLine($"student ID {x.StudentId}");
        }

       

    }
}