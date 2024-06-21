namespace Day1Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John Franklin";
            string middleName = "Perez";
            string lastName = "Nieras";
            int age = 22;
            string gender = "Male";

            string fullName = ($"{firstName} {middleName} {lastName}");

            System.Console.WriteLine($"My name is {fullName}. My gender is {gender}. I am {age} years old.");

        }
    }
}