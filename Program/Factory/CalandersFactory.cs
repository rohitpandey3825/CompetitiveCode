using Problem.Calanders;
using Problem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.Factory
{
    public class CalandersFactory : ConnectorsFactory
    {
        public CalandersFactory()
        {
            Console.WriteLine("CalandersFactory init");
        }
        public override IConnector GetConnection(string type)
        {
            IConnector calander = null;

            if (type.Equals("Google"))
            {
                return new GoogleCalander();
            }
            else if (type.Equals("Outlook"))
            {
                return new OutlookCalander();
            }
            else if (type.Equals("ICloud"))
            {
                return new ICalCalander();
            }
            else if (type.Equals("Zoom"))
            {
                return new ZoomCalander();
            }

            return calander;
        }
    }
}
