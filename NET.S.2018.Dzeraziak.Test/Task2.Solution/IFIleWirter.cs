namespace Task_2
{
    public interface IFileWirter
    {
        void WriteBytesToFile(string fileName, byte[] content);
    }
}