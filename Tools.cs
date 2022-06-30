using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SHSApp
{
    public static class Tools
    {
        public static void ToLog(string zek, string narushenie, decimal hours, decimal minutes, string whoCreated, DateTime when)
        {
            string res = "Рапорт создан " + DateTime.Now.ToString() + ' ' + whoCreated + " на осужденного " + zek + " за «" + narushenie + "» ";
            res += when.Date.GetDateTimeFormats()[0] + " в " + Convert.ToInt32(hours) + " ч. " + Convert.ToInt32(minutes) + " м." + (char)13;
            File.AppendAllText(@"\\ik18srv\папкаобмена\ОПЕРА\5881\raportLog.txt", res);
        }
    }
}
