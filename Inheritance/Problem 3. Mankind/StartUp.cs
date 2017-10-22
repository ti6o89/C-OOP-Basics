using System;

namespace Problem_3.Mankind
{
    class StartUp
    {
        static void Main()
        {
            var studentInfo = Console.ReadLine().Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries);
            var workerInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                var worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), double.Parse(workerInfo[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
