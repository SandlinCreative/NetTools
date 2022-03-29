using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace Pinger
{
    internal class PingStuff
    {

        protected List<IPAddress> PingEndpoints(IPEnumeration ipEnum)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Pinging Endpoints");
            Console.WriteLine("");

            Ping pingSender = new Ping();
            List<IPAddress> respondedList = new List<IPAddress>();

            foreach (IPAddress ip in ipEnum)
            {
                Console.Write($"Pinging {ip.ToString()}...");
                PingReply reply = pingSender.Send(ip, 200);
                if (reply.Status == IPStatus.Success)
                {
                    respondedList.Add(ip);
                    Console.WriteLine("Success!");
                }
                else { Console.WriteLine("Fail!"); }
            }

            return respondedList;
        }

    }
}
