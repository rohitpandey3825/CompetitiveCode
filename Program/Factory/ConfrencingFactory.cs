using Problem.Confrencing;
using Problem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.Factory
{
    public class ConfrencingFactory : ConnectorsFactory
    {
        public override IConnector GetConnection(string type)
        {
            IConnector confrencing = null;

            if (type.Equals("Google"))
            {
                return new GoogleConfrencing();
            }
            else if (type.Equals("Outlook"))
            {
                return new OutlookConfrencing();
            }
            else if (type.Equals("Zoom"))
            {
                return new ZoomConfrencing();
            }
            else if (type.Equals("Webex"))
            {
                return new WebExConfrencing();
            }

            return confrencing;
        }
    }
}
