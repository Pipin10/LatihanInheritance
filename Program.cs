namespace baru.LatihanInheritance
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("Mike", 29);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Minnie", 31, "2345", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Pipin", 19, "2629", "Pinnopin@gmail.com");
            student.GetNameAndAge();
        }
    }
}