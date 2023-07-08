using System.Text;
//using ZXing.Common;
//using ZXing;
//using ZXing.QrCode;
using System.Drawing;

namespace shop.Application.Common.Utilities
{
    public static class Utilities
    {
        public static string RandomString(int length)
        {
            Random Random = new();
            string Characters = "0123456789qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";

            DateTime now = DateTime.Now;
            string dateString = now.ToString("yyMMdd");

            StringBuilder randomString = new();

            for (int i = 0; i < length; i++)
            {
                randomString.Append(Characters[Random.Next(Characters.Length)]);
            }

            return dateString + randomString.ToString();
        }

    }
}
