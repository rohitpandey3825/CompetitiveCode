using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem.Calanders;

namespace Problem.Interface
{
    /// <summary>
    /// Defines a interface of calander types created by facotry;
    /// </summary>
    public interface IConnector
    {
        string UserName { get; set; }
        string AuthToken { get; set; }
        bool ConnectUser(string UserName);
        string GetGonnectionString();
        void refreshToken();
    }
}
