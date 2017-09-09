using Nancy;
using System.IO;
using Plating.Barcoding;

namespace Plating.Modules
{
    public class IndexModule : NancyModule
    {
        private readonly string[] _acceptedBarcodeFormats = { "code128", "qr" };
        public IndexModule()
        {
            Get["/"] =
            Get[@"^(.*)$"] = _ =>
            {
                return View["index"];
            };

            Get["barcode/{data}/{format?code128}"] = _ =>
            {
                string format = _.format;
                var barcoder = new Barcoder(format: format);
                MemoryStream stream = barcoder.WriteArray(_.data);
                return Response.FromByteArray(stream.GetBuffer(), "image/png");
            };
        }
    }
}