namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What database do you want to use: List, SQL, or Mongo?");
            string userDatabaseRequest = Console.ReadLine();
            userDatabaseRequest = userDatabaseRequest.ToLower();

            IDataAccess userAccess = DataAccessFactory.GetDataAccessType(userDatabaseRequest);

            userAccess.LoadData();
            userAccess.SaveData();
        }
    }
}
