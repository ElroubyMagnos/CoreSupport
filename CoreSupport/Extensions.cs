using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DesktopSupport
{
    public static class Extensions
    {
        public static Image ToImage(this byte[] img)
        {
            var ms = new MemoryStream();
            ms.Write(img);

            return Image.FromStream(ms);
        }
        public static byte[] ToArray(this Image Image)
        {
            var ms = new MemoryStream();

            Image.Save(ms, ImageFormat.Png);

            return ms.ToArray();
        }
        public static void FlagNotify(string Msg, string Caption = "Attention")
        {
            MessageBox.Show(Msg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void FlagError(string Msg, string Caption = "Error")
        {
            MessageBox.Show(Msg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string ToStringOrEmpty<T>(this T Data)
        {
            try
            {
                return Data.ToString();
            }
            catch { return ""; }
        }
        public static int IntOrDefault(this string IOD)
        {
            int.TryParse(IOD, out int result);

            return result;
        }
        public static short ShortOrDefault(this string IOD)
        {
            short.TryParse(IOD, out short result);

            return result;
        }
        public static byte ByteOrDefault(this string IOD)
        {
            byte.TryParse(IOD, out byte result);

            return result;
        }
        public static decimal DecimalOrDefault(this string IOD)
        {
            decimal.TryParse(IOD, out decimal result);

            return result;
        }
        public static bool IsDate(this string Time)
        {
            DateTime XD;

            DateTime.TryParse(Time, out XD);

            return XD != null;
        }

        public static string ToZeroTime(this DateTime Data)
        {
            string TimeCollector = "";

            TimeCollector += Data.Year;

            if (Data.Month >= 10)
                TimeCollector += Data.Month;
            else TimeCollector += "0" + Data.Month;

            if (Data.Day >= 10)
                TimeCollector += Data.Day;
            else TimeCollector += "0" + Data.Day;

            return TimeCollector;
        }

        public static string ToZeroTimeText(int Year, int Month, int Day)
        {
            string TimeCollector = "";

            TimeCollector += Year;

            if (Month >= 10)
                TimeCollector += Month;
            else TimeCollector += "0" + Month;

            if (Day >= 10)
                TimeCollector += Day;
            else TimeCollector += "0" + Day;

            return TimeCollector;
        }

        public static DateTime FromZeroTime(this string Data)
        {
            if (Data == null || Data.Length <= 0)
            {
                MessageBox.Show("Empty Date Received and auto set to today");

                return DateTime.Now;
            }

            string Year = Data.Substring(0, 4);
            string Month = Data.Substring(4, 2);
            string Day = Data.Substring(6, 2);

            string Date = $"{Day}/{Month}/{Year}";

            try
            {
                return DateTime.Parse(Date);
            }
            catch 
            {
                MessageBox.Show("Wrong Date!");
                return DateTime.Now; 
            }
        }  
    }
}
