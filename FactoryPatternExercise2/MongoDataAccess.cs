namespace FactoryPatternExercise2;

public class MongoDataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine("Loading data from Mongo Data Access.");
    }

    public void SaveData()
    {
        Console.WriteLine("Saving data to Mongo Data Access.");
    }
}