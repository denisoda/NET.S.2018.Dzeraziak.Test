namespace Task2.Solution
{
    public interface IFileWirter
    {
        void WriteBytesToFile(string fileName, byte[] content);
    }
}