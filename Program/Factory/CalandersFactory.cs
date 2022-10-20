using Problem.Calanders;
using Problem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.Factory
{
    public class CalandersFactory
    {
        public static ICalanders GetCalander(string cardType)
        {
            ICalanders calander = null;

            if (cardType == "Google")
            {
                calander = new GoogleCalander();
            }
            else if (cardType == "OutLook")
            {
                calander = new OutlookCalander();
            }
            else if (cardType == "ICloud")
            {
                calander = new ICalCalander();
            }

            return calander;
        }
    }
}
