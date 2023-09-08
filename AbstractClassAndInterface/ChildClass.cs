using System;

namespace AbstractClassAndInterface
{
    public class ChildClass : FileWorker
    {
        public string fileExtention;

        public ChildClass(string extension, decimal maxSize)
        {
            this.fileExtention = extension;
            FileMaxSize = maxSize;
        }

        public override string FileExtention
        {
            get => fileExtention;
            set => fileExtention = value;
        }

        public override void Delete()
        {
            Console.WriteLine($"I can delete from {fileExtention} file with max storage {FileMaxSize}");
        }

        public override void Edit()
        {
            Console.WriteLine($"I can edit {fileExtention} file with max storage {FileMaxSize}");
        }

        public override void Read()
        {
            Console.WriteLine($"I can read from {fileExtention} file with max storage {FileMaxSize}");
        }

        public override void Write()
        {
            Console.WriteLine($"I can write to {fileExtention} file with max storage {FileMaxSize}");
        }
    }
}
