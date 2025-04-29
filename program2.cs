using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Reflection;

namespace WSWB_pr
{
    class program2
    {
        public static void Main()
        {
            //Configuration of local host
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080");
            listener.Start();
            Console.WriteLine("Listening");


            while (true)
            {
                HttpListenerContext Context = listener.GetContext();
                HttpListenerRequest Request = Context.Request;
                HttpListenerResponse Response = Context.Response;

                string responseString = "<html><Body> Visual Studio 2022</body></html>";
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                Response.ContentLength64 = buffer.Length;
                Stream output = Response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();

            }
        }
    }   
}