using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HTC_OEM_Tool
{
    class ADB
    {
        private static ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "adb.exe",
            CreateNoWindow = true,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            StandardOutputEncoding = Encoding.UTF8,
            StandardErrorEncoding = Encoding.UTF8
        };

        public static bool su { get; set; }

        public enum SecureFlag
        {
            UNKNOWN = -1,
            OFF = 0,
            ENG = 1,
            DEB = 2,
            ON = 3
        }

        private static ADBResult Run(string arg)
        {
            ADBResult result;
            using (Process p = new Process())
            {
                p.StartInfo = psi;
                p.StartInfo.Arguments = arg;
                p.Start();
                string text_stdout = p.StandardOutput.ReadToEnd();
                string text_stderr = p.StandardError.ReadToEnd();
                p.WaitForExit();
                result = new ADBResult(text_stdout, text_stderr);
            }
            return result;
        }

        private static ADBResult Shell(string arg)
        {
            ADBResult result;
            using (Process p = new Process())
            {
                p.StartInfo = psi;
                p.StartInfo.Arguments = $"shell {(su ? "su -c" : "")} \"{arg}\"";
                p.Start();
                string text_stdout = p.StandardOutput.ReadToEnd();
                string text_stderr = p.StandardError.ReadToEnd();
                p.WaitForExit();
                result = new ADBResult(text_stdout, text_stderr);
            }
            return result;
        }

        public static bool CheckDevice()
        {
            ADBResult result;
            result = Run("devices");
            if (result.stdout.ReadToEnd().Contains("\tdevice"))
            {
                return true;
            }
            return false;
        }

        public static bool CheckPermission()
        {
            ADBResult result;
            result = Run("shell whoami");
            if (result.stdout.ReadLine().Contains("root"))
            {
                su = false;
                return true;
            }
            result = Run("shell su -v");
            if (result.stderr.EndOfStream)
            {
                su = true;
                return true;
            }
            return false;
        }

        public static SecureFlag CheckSOFF()
        {
            ADBResult result;
            result = Run("shell getprop ro.sf");
            switch (result.stdout.ReadLine())
            {
                case "0":
                    return SecureFlag.OFF;
                case "1":
                    return SecureFlag.ENG;
                case "2":
                    return SecureFlag.DEB;
                case "3":
                    return SecureFlag.ON;
                default:
                    return SecureFlag.UNKNOWN;
            }
        }

        public static bool CheckBootdevice()
        {
            ADBResult result;
            result = Shell("ls -l /dev/block/bootdevice/by-name/ | grep system");
            if (result.stdout.ReadLine().Contains("system"))
            {
                return true;
            }
            return false;
        }

        public static void DumpPartition()
        {
            if (File.Exists("board_info")) File.Delete("board_info");
            if (File.Exists("mfg")) File.Delete("mfg");
            if (File.Exists("misc")) File.Delete("misc");
            Shell("dd if=/dev/block/bootdevice/by-name/board_info of=/sdcard/board_info bs=4096 count=1");
            Shell("dd if=/dev/block/bootdevice/by-name/mfg of=/sdcard/mfg bs=4096 count=10");
            Shell("dd if=/dev/block/bootdevice/by-name/misc of=/sdcard/misc bs=4096 count=1");
            Run("pull /sdcard/board_info");
            Run("pull /sdcard/mfg");
            Run("pull /sdcard/misc");
            Run("shell rm -f /sdcard/board_info");
            Run("shell rm -f /sdcard/mfg");
            Run("shell rm -f /sdcard/misc");
        }

        public static int GetPatternOffset(string file, string pattern, int count, bool unicode = false)
        {
            var data = File.ReadAllBytes(file);
            var regex = new Regex(pattern);
            var buff = new byte[unicode ? count * 2 : count];
            var encoding = unicode ? Encoding.Unicode : Encoding.UTF8;
            for (int i = 0; i < data.Length - buff.Length; i++)
            {
                Buffer.BlockCopy(data, i, buff, 0, buff.Length);
                var str = encoding.GetString(buff).TrimEnd('\0');
                if (regex.IsMatch(str))
                {
                    return i;
                }
            }
            return -1;
        }

        public static string GetString(string file, int offset, int count, bool unicode = false)
        {
            var data = File.ReadAllBytes(file);
            var buff = new byte[unicode ? count * 2 : count];
            var encoding = unicode ? Encoding.Unicode : Encoding.UTF8;
            Buffer.BlockCopy(data, offset, buff, 0, buff.Length);
            return encoding.GetString(buff).TrimEnd('\0');
        }

        public static void WriteString(string partition, string text, int offset, int erase, bool unicode = false)
        {
            var encoding = unicode ? Encoding.Unicode : Encoding.UTF8;
            var buff = encoding.GetBytes(text);
            var str = "";
            for (int i = 0; i < buff.Length; i++)
            {
                str += "\\x" + buff[i].ToString("X2");
            }
            Run($"shell \"echo -ne '{str}' > /sdcard/tmp\"");
            Shell($"dd if=/dev/zero of=/dev/block/bootdevice/by-name/{partition} bs=1 seek={offset} count={erase}");
            Shell($"dd if=/sdcard/tmp of=/dev/block/bootdevice/by-name/{partition} bs=1 seek={offset} count={buff.Length}");
            Run("shell rm -f /sdcard/tmp");
        }
    }
}
