using System;
using System.Text.RegularExpressions;

namespace Laba14_w
{
    public class Program
    {
        public static void Main()
        {
            string ip = Console.ReadLine();
            Regex regexIpv6 = new Regex(
                "(([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}|"+
                "([0-9a-fA-F]{1,4}:){1,7}:|"+
                "([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|"+
                "([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|"+
                "([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|"+
                "([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|"+
                "([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|"+
                "fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])"+
                "|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))");
            Regex regexIpv4 = new Regex("((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)");

            Match matchesIpv6 = regexIpv6.Match(ip);
            Match matchesIpv4 = regexIpv4.Match(ip);

            if (matchesIpv6.Success)
            {
                Console.WriteLine("IPv6: " + matchesIpv6.Value);
            }
            if (matchesIpv4.Success)
            {
                Console.WriteLine("IPv4: " + matchesIpv4.Value);
            }
            else
            {
                Console.WriteLine("Совпадений нет.");
            }
        }

    }
}
