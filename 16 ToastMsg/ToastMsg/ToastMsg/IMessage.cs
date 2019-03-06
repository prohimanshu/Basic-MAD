using System;
using System.Collections.Generic;
using System.Text;

namespace ToastMsg
{
    public interface IMessage
    {
        void Longtime(string message);
        void Shorttime(string message);
    }
}
