namespace FactoryPatternExercise2;

public class SQLDataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine("Loading data from SQL Data Access.");
    }

    public void SaveData()
    {
        Console.WriteLine("Saving data to SQL Data Access.");
    }
}