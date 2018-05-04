namespace Task1.Solution
{
    public interface IPasswordChecker
    {
        public Tuple<bool, string> VerifyPassword(string password);
    }
}