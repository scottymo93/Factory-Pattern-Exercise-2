namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what type of data are you trying to access?");
            var input = Console.ReadLine();

           var level2 = DataAccessFactory.GetDataAccessType(input);
           
           level2.LoadData();
           level2.SaveData();
        }
    }
}
