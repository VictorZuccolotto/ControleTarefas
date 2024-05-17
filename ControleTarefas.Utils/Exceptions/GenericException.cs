namespace ControleTarefas.Utils.Exceptions
{
    public class GenericException : Exception
    {
        public GenericException() { }
        public GenericException(string message) : base(message) { }
        public GenericException(string message, Exception exception) : base(message, exception) { }
    }
}
