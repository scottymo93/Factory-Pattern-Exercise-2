namespace FactoryPatternExercise2;

public class ListDataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine("Loading data from List Data Access.");
    }

    public void SaveData()
    {
        Console.WriteLine("Saving data from List Data Access.");
    }
}