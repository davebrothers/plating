using Nancy;
using System.IO;

namespace Plating.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ =>
            {
                return View["index"];
            };

            Get["barcode/{format}/{length}/{width}/{data}"] = _ =>
            {
                return $"{_.format} {_.length} {_.width} {_.data}";
            };

            Get["barcode/{data}"] = _ =>
            {
                string data = _.data;
                var stream = new MemoryStream();
                var barcoder = new Barcoding.Barcoder();
                barcoder.WriteArray(data, stream);
                return Response.FromByteArray(stream.GetBuffer(), "image/png");
            };

        }
    }
}