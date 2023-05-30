using Azure.Core;
using System.Text.Json;

[assembly: CodeGenSuppressType("AddRequest")]

namespace MathClient.Models
{
    public partial class AddRequest : IUtf8JsonSerializable
    {
        [CodeGenMember("Values")]
        public IList<int> Values { get; set; }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Values))
            {
                if (Values != null)
                {
                    writer.WritePropertyName("values"u8);
                    writer.WriteStartArray();
                    foreach (var item in Values)
                    {
                        writer.WriteNumberValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("values");
                }
            }
            writer.WriteEndObject();
        }
    }
}
