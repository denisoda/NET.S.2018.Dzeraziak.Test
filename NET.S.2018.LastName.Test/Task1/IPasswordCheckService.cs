namespace Task1
{
    public interface IPasswordCheckerService
    {
         public Tuple<bool, string> VerifyPassword(string password);
    }
}