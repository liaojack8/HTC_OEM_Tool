using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTC_OEM_Tool
{
    class ADBResult
    {
        public StreamReader stdout{ get; private set; }
        public StreamReader stderr { get; private set; }
        public ADBResult(string text_stdout, string text_stderr)
        {
            stdout = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(text_stdout)));
            stderr = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(text_stderr)));
        }
    }
}
