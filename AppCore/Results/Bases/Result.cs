namespace AppCore.Results.Bases
{
    public abstract class Result
    {
        protected Result(bool ısSuccesful, string? message)
        {
            IsSuccesful = ısSuccesful;
            Message = message;
        }

        public bool IsSuccesful { get; }
        public string? Message { get; set; }
    }
}
