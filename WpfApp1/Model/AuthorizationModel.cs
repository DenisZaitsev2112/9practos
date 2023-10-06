using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class AuthorizationModel
    {
        public AuthorizationModel(string password, string address, string host)
        {
            if(host == null)
            {
                throw new Exception();
            }

            ImapHelper.Initialize(host);

            try
            {
                if (ImapHelper.Login(address, password))
                {
                    _isConnect = true;
                }
            }
            catch
            {
                _isConnect = false;
            }
        }

        private bool _isConnect = false;

        public bool isConnect()
        {
            return _isConnect;
        }
    }
}
