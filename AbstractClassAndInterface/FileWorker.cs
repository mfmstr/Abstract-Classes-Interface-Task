using System.Reflection.Metadata.Ecma335;

namespace AbstractClassAndInterface
{
    public abstract class FileWorker
    {
        public decimal FileMaxSize;
        public abstract string FileExtention { get; set; }

        public abstract void Read();
        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();

    }
}
