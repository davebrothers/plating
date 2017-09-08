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

        public Barcoder()
        {
            _writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Height = 150,
                    PureBarcode = false,
                    Width = 200
                }
            };
        }

        public void WriteArray(string data, MemoryStream stream)
        {
            _writer
                .Write(data)
                .Save(stream, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}