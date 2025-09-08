namespace FactoryPatternExercise2;

public static class DataAccessFactory
{
    public static IDataAccess GetDataAccessType(string input)
    {
        switch (input)
        {
            case "List":
                return new ListDataAccess();
            case "Mongo":
                return new MongoDataAccess();
            case "SQL":
                return new SQLDataAccess();
            default:
                return new ListDataAccess();
        }
    }
}