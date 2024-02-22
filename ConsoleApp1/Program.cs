using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BddpersonnelContext;
using DllbddPersonnels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "localhost";
            string port = "3036";
            string user = "valthur";
            string password = "Password1234!";


            bddpersonnels bdd = new bddpersonnels(host, port, user, password);

            foreach (Service s in bdd.ListServices())
            {
                Console.WriteLine(s);
            }
        }
    }
}
