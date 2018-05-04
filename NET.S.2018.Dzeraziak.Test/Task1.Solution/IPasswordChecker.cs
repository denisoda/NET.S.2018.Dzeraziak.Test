using System;

namespace Task1.Solution
{
    public interface IPasswordChecker
    {
        Tuple<bool, string> VerifyPassword(string password);
    }
}