using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogLibrary;

namespace FileOperations
{
    public class Reader
    {
        public List<string> GetLines()
        {
            try
            {
                return File.ReadAllLines("").ToList();
            }
            catch (Exception e)
            {
                SideTraceListener.Instance.Exception(e);

                return new List<string>();
            }
        }
    }
}
