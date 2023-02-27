using System.ComponentModel;
using System.IO;
using System.Text;

namespace SearchWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countBads = 0;
            string[] badwords = new string[] { "LOX", "JOPA" };
            string originPath = @"D:\EXAM";
            DirectoryInfo info = new DirectoryInfo(originPath);
            List<FileInfo> list = new List<FileInfo>();
            List<DirectoryInfo> list2 = new List<DirectoryInfo>();
            bool end = false;

            MyGetDirectories(info, ref list2,ref list);
           
            foreach (FileInfo file in list)
            {
                Console.WriteLine(file.FullName);
            }
            foreach (DirectoryInfo directory in list2)
            {
                Console.WriteLine(directory.FullName);
            }
            foreach (FileInfo file in list) 
            {
                bool needCopy = false;
                foreach(string str in badwords)
                {
                    byte[] bytes = Encoding.ASCII.GetBytes(str);
                    byte[] buffer = new byte[bytes.Length];
                    FileStream stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Read, bytes.Length, FileOptions.Asynchronous);
                    byte[] data = new byte[stream.Length];
                    long readbytes = stream.EndRead(stream.BeginRead(data, 0, data.Length, null, null));
                        int counter = 0 ;
                    foreach(byte b in BitConverter.GetBytes(readbytes))
                    {
                        if (b == bytes[counter])
                        {
                            buffer[counter] = b;
                            counter++;
                        }
                        else 
                        {
                            counter = 0;
                        }
                        if(counter == bytes.Length - 1)
                        {
                            countBads++;
                            counter = 0;
                            needCopy= true;
                        }
                    }
                    stream.Close();
                }
                if(needCopy)
                {

                }
            }
        }
        static void MyGetDirectories(DirectoryInfo directory,ref List<DirectoryInfo>mylist,ref List<FileInfo> files)
        {
            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                mylist.Add(dir);
                files.AddRange(dir.GetFiles());
                MyGetDirectories(dir,ref mylist,ref files);
            }
        }
    }
}