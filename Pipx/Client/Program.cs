using System;
using System.IO;
using System.IO.Pipes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeClient
{
    class Program
    {

        NamedPipeClientStream CStream;

        int Main(string[] args)
        {
            StartClient("Test1");
            return 0;
        }

        /// <summary>
        /// Builds the namedpipe to a specified pipestream
        /// </summary>
        /// <param name="pipe"></param>
        /// <returns></returns>
        string StartClient(string pipe)
        {
            BuildClient(pipe);
            return "Started Client";
        }
        
        string BuildClient(string pipename)
        {
            CStream = new NamedPipeClientStream(pipename);
            return "Built stream " + pipename;
        }
        /// <summary>
        /// Sends a debug byte of 1 to the ClientPipeStream
        /// </summary>
        /// <param name="CPS"></param>
        void SendData(NamedPipeClientStream CPS)
        {
            CPS.WriteByte(1);
        }
        /// <summary>
        /// Sends a single Byte message to the ClientPipeStream
        /// </summary>
        /// <param name="CPS"></param>
        /// <param name="message"></param>
        void SendData(NamedPipeClientStream CPS, byte message)
        {
            CPS.WriteByte(message);
        }
        /// <summary>
        /// Sends a Byte array to the ClientPipeStream
        /// </summary>
        /// <param name="CPS"></param>
        /// <param name="message"></param>
        void SendData(NamedPipeClientStream CPS, byte[] message)
        {
            do
            {

            } while (true);
        }
    }
}
