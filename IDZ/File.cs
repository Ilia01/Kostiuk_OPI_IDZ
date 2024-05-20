using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ
{
    interface IFile
    {
        public string GetLoad();
        public void Read();
        public void SetPath(string path);
        public void SetLoad(string load);
        public void Write();
    }

    public class File : IFile
    {
        private string Path = "";
        private string Load = "";

        public File(string path)
        {
            SetPath(path);
        }

        public string GetLoad() 
        { 
            return Load; 
        }

        public void Read()
        {
            using (System.IO.StreamReader sr  = new System.IO.StreamReader(Path))
            {
                Load = sr.ReadToEnd();
            }
        }

        public void SetPath(string path)
        {
            Path = path;
        }

        public void SetLoad(string load)
        {
            Load = load;
        }

        public void Write()
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(Path))
            {
                sw.Write(Load);
            }
        }
    }
}
