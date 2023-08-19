using AppCore.Results.Bases;
using System.Data.SqlTypes;

namespace AppCore.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult( string? message) : base(true, message)
        {
        }
        public SuccessResult() : base(true,"")
        {
            
        }
    }
}
