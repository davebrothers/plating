using System;
using ZXing;

namespace Plating.Barcoding
{
    interface IBarcode
    {
        string Data();
        string Format();

    }

    public class Code128 : IBarcode
    {
        private string _data;
        private BarcodeFormat _barcodeFormat;

        public Code128(string data, int length = 200, int height = 150)
        {
            _data = data;
            _barcodeFormat = BarcodeFormat.CODE_128;
        }

        public string Data()
        {
            return _data;
        }

        public string Format()
        {
            return _barcodeFormat.ToString();
        }
    }
}
