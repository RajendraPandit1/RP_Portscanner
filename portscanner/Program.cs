using System.Diagnostics;
using System.IO.Pipes;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;


string host = "51.254.81.57";

if(host!=null){   //if the ports is define or not

for(int PRT=0;PRT<=1023;PRT++)
        {

            try
            {
                // Attempt to connect to the port
                using (TcpClient client = new TcpClient())
                {
                   client.Connect(host, PRT); 
                    String Service = "";

                    switch(PRT){
                         case 21: Service  = "(FTP)";  break;
                        case 22: Service  = "(SSH)";  break;
                        case 25: Service  = "(SMTP)"; break;
                        case 53: Service  = "(DNS)";  break;
                        case 67: Service  = "DHCP"; break;
                        case 68: Service  = "DHCP"; break;
                        case 80: Service  = "(HTTP)"; break;
                        case 110: Service  = "(POP3)"; break;
                        case 143: Service  = "IMAP"; break;
                        case 161: Service  = "(SNMP)"; break; 
                        case 389: Service  = "(LDAP)"; break;
                        case 443: Service  = "(HTTPS)"; break;
                        case 1521: Service  = "(Oracle database)"; break;
                        case 3306: Service  = "(MySQL)"; break;
                        case 5432: Service  = "(PostgreSQL)"; break;
                        case 8080: Service  = "(8080)"; break;
                        default: Service  = "Unknown"; break;

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{Service} on Port {PRT} [OPEN] ");
                }
            }
            catch (SocketException)
            {
                //Port is not open
                 
                 /*String Service = "";

                    switch(PRT){ 
                        case 21: Service  = "(FTP)";  break;
                        case 22: Service  = "(SSH)";  break;
                        case 25: Service  = "(SMTP)"; break;
                        case 53: Service  = "(DNS)";  break;
                        case 67: Service  = "DHCP"; break;
                        case 68: Service  = "DHCP"; break;
                        case 80: Service  = "(HTTP)"; break;
                        case 110: Service  = "(POP3)"; break;
                        case 143: Service  = "IMAP"; break;
                        case 161: Service  = "(SNMP)"; break; 
                        case 389: Service  = "(LDAP)"; break;
                        case 443: Service  = "(HTTPS)"; break;
                        case 1521: Service  = "(Oracle database)"; break;
                        case 3306: Service  = "(MySQL)"; break;
                        case 5432: Service  = "(PostgreSQL)"; break;
                        case 8080: Service  = "()"; break;
                        default: Service  = "Unknown"; break;

                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Service} on Port {PRT} [CLOSED] ");*/
            if(PRT==1023){
                Console.WriteLine("------ Completed ----------");
            }
        }
        
        
        }}
