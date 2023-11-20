using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class Parser
    {
        public Parser() 
        {
        }
        public void createMessage(byte[] buf, string strFam, string strName, string strSurname) 
        {
            
        }
        public void parse(byte[] buf, out string strFam, out string strName,out string strSurname)
        {
            strFam = null;
            strName = null;
            strSurname = null;
            
            if ((buf != null) && (buf.Length >= 3))
            {
                int famLength = buf[0];
                int nameLength = buf[1];
                int surnameLength = buf[2];

                if (buf.Length >= (3 + buf[0] + buf[1] + buf[2])) 
                {
                    strFam = Encoding.UTF8.GetString(buf, 3, buf[0]);
                    strName = Encoding.UTF8.GetString(buf, 3 + buf[0], buf[1]);
                    strSurname = Encoding.UTF8.GetString(buf, 3 + buf[0] + buf[1], buf[2]);
                }
            }
        }

    }
}
