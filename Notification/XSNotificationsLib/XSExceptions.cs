namespace XSNotifications.Exception
{
    public class XSFormatException : System.Exception
    {
        public XSFormatException() { }
        public XSFormatException(string message) : base(message) { }
        public XSFormatException(string message, System.Exception inner) : base(message, inner) { }
        public XSFormatException(System.Exception ex) : base(ex.Message, ex.InnerException) { }
    }

    public class XSNetworkException : System.Exception
    {
        public XSNetworkException() { }
        public XSNetworkException(string message) : base(message) { }
        public XSNetworkException(string message, System.Exception inner) : base(message, inner) { }
        public XSNetworkException(System.Exception ex) : base(ex.Message, ex.InnerException) { }
    }

    public class XSRuntimeException : System.Exception
    {
        public XSRuntimeException() { }
        public XSRuntimeException(string message) : base(message) { }
        public XSRuntimeException(string message, System.Exception inner) : base(message, inner) { }
        public XSRuntimeException(System.Exception ex) : base(ex.Message, ex.InnerException) { }
    }
}