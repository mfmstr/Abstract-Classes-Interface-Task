using System;

namespace AbstractClassAndInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass("txt", 128);

            child.Write();
            child.Read();
            child.Edit();
            child.Delete();

        }
    }
}
