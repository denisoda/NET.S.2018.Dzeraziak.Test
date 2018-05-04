using System;
using System.Collections.Generic;

namespace Task_2
{
    public abstract class FileGenerator
    {
        protected string  WorkingDirectory;
        protected string FileExtension;

        public abstract void GenerateFiles(int filesCount, int contentLength);

        protected abstract byte[] GenerateFileContent(int contentLength);
    }
}