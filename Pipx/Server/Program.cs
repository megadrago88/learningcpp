using System;
using System.IO.Pipes;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipx
{
    class Program
    {
        static void Main(string[] args)
        {
            StartServer();
        }
        static void StartServer()
        {
            using (NamedPipeServerStream NamePipeServer = new NamedPipeServerStream("TestPipe"))
            {
                NamePipeServer.WaitForConnection();
                NamePipeServer.WriteByte(1);
                int CByte = NamePipeServer.ReadByte();
                Console.WriteLine(CByte);
                NamePipeServer.Disconnect();
                NamePipeServer.Dispose();
            }
        }
    }
}
