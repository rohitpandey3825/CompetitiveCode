using Problem.Calanders;
using Problem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.Interface
{
    public abstract class CalandersFactory
    {
        protected abstract IList<ICalanders> GetCalanders();
        public IList<ICalanders> CreateCalanders()
        {
            return this.GetCalanders();
        }
    }
}
