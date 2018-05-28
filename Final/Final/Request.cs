using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Final
{
    class Request
    {
        int code;
        List<string> Values = new List<string>();

        public Request(string Message)
        {
            code = int.Parse(Message.Substring(0, 3));

            if (Message.Length == 3)
                return;
            Message = Message.Substring(3);

            
            while(Message.Length != 0 && Message[0] != '\0')
            {
                int length = int.Parse(Message.Substring(0, 2));
                Message = Message.Substring(2);
                Values.Add(Message.Substring(0, length));
                Message = Message.Substring(length);

            }
        }
        public int getCode()
        {
            return code;
        }

        public List<string> getValues()
        {
            return this.Values;
        }
    }
}
