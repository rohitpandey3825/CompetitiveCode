using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem.Interface;
namespace Problem.Confrencing
{
    public class WebExConfrencing : IConnector
    {
        public string UserName { get; set; }
        public string AuthToken { get; set; }

        private string connectionSting = "WebExConfrencing";
        public WebExConfrencing()
        {
            this.UserName = "";
            this.AuthToken = "";
        }

        public bool ConnectUser(string userName)
        {
            this.UserName = userName;
            this.AuthToken = Guid.NewGuid().ToString();
            return true;
        }

        public string GetGonnectionString()
        {
            return $"URI:{this.connectionSting}/user:{this.UserName}/Token:{this.AuthToken}";
        }

        public void refreshToken()
        {
            this.AuthToken = Guid.NewGuid().ToString();
        }
    }
}
