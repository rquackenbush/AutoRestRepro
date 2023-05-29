using Azure.Core;

namespace MathClient.Models
{
    public partial class AddRequest
    {
        [CodeGenMember("Values")]
        public IList<int> Values { get; set; }
    }
}
