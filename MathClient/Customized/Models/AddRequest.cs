using Azure.Core;

[assembly: CodeGenSuppressType("AddRequest")]
namespace MathClient.Models
{
    public partial class AddRequest
    {
        public IList<int> Values { get; set; }
    }
}
