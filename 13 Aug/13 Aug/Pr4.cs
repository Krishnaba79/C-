using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _13_Aug
{
    internal class Pr4
    {
        public static void Main()
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/");
            listener.Start();
            Console.WriteLine("Listening");

            while(true)
            {
                HttpListenerContext  context = listener.GetContext();
                HttpListenerRequest request = context.Request;  
                HttpListenerResponse response = context.Response;

                string responsesstring = "<html><body>Visual Studio </body></html>"
                byte[] buffer = Encoding.UTF8.GetBytes(responsesstring);
                responsesstring.ContentLength64 = buffer.Length;
                Stream 
            }
        }
    }
}
