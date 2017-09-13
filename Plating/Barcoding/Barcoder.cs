using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using ZXing;
using ZXing.Common;

namespace Plating.Barcoding
{
    public class Barcoder
    {
        private BarcodeWriter _writer;

        public Barcoder(string format = "code128", int height = 100, int width = 300)
        {
            _writer = new BarcodeWriter
            {
                Format = TypeFormat(format),
                Options = new EncodingOptions
                {
                    Height = height,
                    PureBarcode = false,
                    Width = width
                }
            };
        }

        public MemoryStream WriteArray(string data)
        {
            var stream = new MemoryStream();
            _writer
                .Write(data)
                .Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return stream;
        }

        private BarcodeFormat TypeFormat(string format)
        {
            switch (format.ToLower())
            {
                case "qr":
                    return BarcodeFormat.QR_CODE;
                default:
                    return BarcodeFormat.CODE_128;
            }
        }
    }
}