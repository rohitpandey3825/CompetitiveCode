using System.Dynamic;
using System.IO;
using System.Threading.Tasks;
using System;

namespace Helper.IO
{
    public class ConsoleReader: IDisposable
    {
        private StreamReader _sr;
        private StreamWriter _sw;

        public ConsoleReader(string FolderName)
        {
            try
            {
                string filePathName = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string inputPathName = new String(filePathName);
                string outputPathName = new String(filePathName);
                //if (!String.IsNullOrEmpty(FolderName))
                //{
                //    inputPathName = inputPathName + "\\" + FolderName;
                //    outputPathName = outputPathName + "\\" + FolderName;
                //}
                //if(!Directory.Exists(inputPathName))
                //{
                //    Directory.CreateDirectory(inputPathName);
                //}
                //if(!Directory.Exists(outputPathName))
                //{
                //    Directory.CreateDirectory(outputPathName);
                //}
                inputPathName = inputPathName + "\\input.txt";
                outputPathName = outputPathName + "\\output.txt";
                if (!File.Exists(inputPathName))
                {
                    File.Create(inputPathName).Dispose();
                }
                if (!File.Exists(outputPathName))
                {
                    File.Create(outputPathName).Dispose();
                }
                _sr = new StreamReader(inputPathName);
                _sw = new StreamWriter(outputPathName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somthing Bad Happended" + ex.ToString());
            }
        }

        ~ConsoleReader()
        {
            Dispose();
        }

        public void Dispose()
        {
            _sw.Flush();
            _sr.Close();
            _sw.Close();
            _sw.Dispose();
            _sr.Dispose();
            GC.SuppressFinalize(this);
        }

        public string ReadLine()
        {
            return _sr.ReadLine();
        }

        public async Task<string> ReadLineAsync()
        {
            return await _sr.ReadLineAsync();
        }

        public void WriteLine(string str = "")
        {
            _sw.WriteLine(str);
        }

        public async Task WriteLineAsync(string str = "")
        {
            await _sw.WriteLineAsync(str);
        }

        public void Write(string str = "")
        {
            _sw.Write(str);
        }

        public async Task WriteAsync(string str = "")
        {
            await _sw.WriteAsync(str);
        }
    }
}
