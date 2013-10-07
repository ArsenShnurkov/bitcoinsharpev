using System;

namespace BitCoinSharp.Discovery
{
    public class IrcDiscoveryEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public IrcDiscoveryEventArgs(string message)
        {
            Message = message;
        }
    }
}