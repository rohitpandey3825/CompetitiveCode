using Problem.Calanders;
using Problem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.Factory
{
    public class DextopCalanderFactory : CalandersFactory
    {
        protected override IList<ICalanders> GetCalanders()
        {
            var calander = new List<ICalanders>();
            calander.Add(new GoogleCalander());
            calander.Add(new OutlookCalander());
            calander.Add(new ZoomCalander());
            return calander;
        }
    }
}
