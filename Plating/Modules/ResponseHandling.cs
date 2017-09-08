using Nancy;
using System.IO;

namespace Plating.Modules
{
    public class ByteArrayResponse : Response
    {
        public ByteArrayResponse(byte[] body, string contentType = null)
        {
            ContentType = contentType ?? "application/octet-stream";
            Contents = stream =>
            {
                using (var writer = new BinaryWriter(stream))
                {
                    writer.Write(body);
                }
            };
        }
    }

    public static class ResponseExtensions
    {
        public static Response FromByteArray(this IResponseFormatter formatter, byte[] body, string contentType = null)
        {
            return new ByteArrayResponse(body, contentType);
        }
    }
}