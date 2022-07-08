using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
namespace CLIPingScript
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Ping ping = new Ping();
            PingOptions options = new PingOptions();
            string buffer = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] bytes = Encoding.UTF8.GetBytes(buffer);
            int timeout = 100;
            PingReply reply = ping.Send(args[0], timeout, bytes, options);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Host is up! See below for ping information: \n \n");
                Console.WriteLine("Address of Host: {0} \n Time To Live: {1} \n Don't Fragment: {2}", reply.Address, options.Ttl, options.DontFragment);
            }
        }
    }
}