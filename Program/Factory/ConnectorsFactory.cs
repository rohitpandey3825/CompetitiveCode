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

        private static readonly Lazy<ConnectorsFactory> CalandersInstancelock =
                    new Lazy<ConnectorsFactory>(() => new CalandersFactory());

        private static readonly Lazy<ConnectorsFactory> ConfrencingInstancelock =
                    new Lazy<ConnectorsFactory>(() => new ConfrencingFactory());

        public static Lazy<ConnectorsFactory> CreateConnectorType(string root)
        {
            if (root.Equals("Calander"))
            {
                return CalandersInstancelock;
            }
            else
            {
                return ConfrencingInstancelock;
            }
        }
    }
}
