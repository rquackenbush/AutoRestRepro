using Azure.Core;

[assembly: CodeGenSuppressType("AddRequest")]

namespace MathClient.Models
{
    public class AddRequest
    {
        public int[] Values { get; set; }
    }
}
