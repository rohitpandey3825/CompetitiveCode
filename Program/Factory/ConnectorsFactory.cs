using Problem.Calanders;
using Problem.Factory;
using Problem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.Interface
{
    public abstract class ConnectorsFactory
    {
        public abstract IConnector GetConnection(string type);
        public static ConnectorsFactory CreateConnectorType(string root)
        {
            if(root.Equals("Calander"))
            {
                return new CalandersFactory();
            }
            else
            {
                return new ConfrencingFactory();
            }
        }
    }
}
