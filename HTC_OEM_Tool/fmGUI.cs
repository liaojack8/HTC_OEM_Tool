using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTC_OEM_Tool
{
    public partial class fmGUI : Form
    {
        private string labelStatus
        {
            get
            {
                string text = null;
                Invoke(new Action(() => text = label_Status.Text));
                return text;
            }
            set
            {
                Invoke(new Action(() => label_Status.Text = value));
            }
        }
        private int offset_cid, offset_mid, offset_sn, offset_ver;

        public fmGUI()
        {
            InitializeComponent();
        }

        private async void button_Check_Click(object sender, EventArgs e)
        {
            button_Check.Enabled = false;
            bool flag = false;
            labelStatus = "Checking adb devices...";
            await Task.Run(() => flag = ADB.CheckDevice());
            if (!flag)
            {
                labelStatus = "No device found!";
                button_Check.Enabled = true;
                return;
            }
            labelStatus = "Checking ROOT or SU permission...";
            await Task.Run(() => flag = ADB.CheckPermission());
            if (!flag)
            {
                labelStatus = "No ROOT or SU permission!";
                button_Check.Enabled = true;
                return;
            }
            labelStatus = "Checking bootdevice symlink...";
            await Task.Run(() => flag = ADB.CheckBootdevice());
            if (!flag)
            {
                labelStatus = "No bootdevice symlink!";
                button_Check.Enabled = true;
                return;
            }
            labelStatus = "Checking secure flag...";
            var sf = ADB.SecureFlag.UNKNOWN;
            await Task.Run(() => sf = ADB.CheckSOFF());
            if (sf != ADB.SecureFlag.UNKNOWN && sf != ADB.SecureFlag.OFF)
            {
                MessageBox.Show("No S-OFF, modify may not work!");
            }
            labelStatus = "Getting partitions...";
            await Task.Run(() => ADB.DumpPartition());
            groupBox_board_info.Enabled = File.Exists("board_info");
            groupBox_mfg.Enabled = File.Exists("mfg");
            groupBox_misc.Enabled = File.Exists("misc");
            if (groupBox_board_info.Enabled)
            {
                offset_cid = ADB.GetPatternOffset("board_info", "^[0-9A-Z_]{8}", 8);
                label_off_cid.Text = $"0x{offset_cid.ToString("X8")}";
                textBox_CID.Text = ADB.GetString("board_info", offset_cid, 8);
                File.Delete("board_info");
            }
            if (groupBox_mfg.Enabled)
            {
                offset_mid = ADB.GetPatternOffset("mfg", "^[0-9A-Z]{4}[0-9*]{5}", 9, true);
                label_off_mid.Text = $"0x{offset_mid.ToString("X8")}";
                textBox_MID.Text = ADB.GetString("mfg", offset_mid, 9, true);
                offset_sn = ADB.GetPatternOffset("mfg", "^[A-Z]{2}[0-9A-Z]{3}[A-Z]{2}\\d{5}", 12);
                label_off_sn.Text = $"0x{offset_sn.ToString("X8")}";
                textBox_SN.Text = ADB.GetString("mfg", offset_sn, 12);
                File.Delete("mfg");
            }
            if (groupBox_misc.Enabled)
            {
                offset_ver = ADB.GetPatternOffset("misc", "^\\d{1}\\.\\d{2}\\.\\d{3}\\.\\d{1,3}", 16);
                label_off_ver.Text = $"0x{offset_ver.ToString("X8")}";
                textBox_VER.Text = ADB.GetString("misc", offset_ver, 16);
                File.Delete("misc");
            }
            labelStatus = null;
            button_Check.Enabled = true;
        }

        private async void button_CID_Click(object sender, EventArgs e)
        {
            button_CID.Enabled = false;
            labelStatus = $"Writing CID: {textBox_CID.Text}...";
            await Task.Run(() => ADB.WriteString("board_info", textBox_CID.Text, offset_cid, 8));
            labelStatus = null;
            button_CID.Enabled = true;
        }

        private async void button_MID_Click(object sender, EventArgs e)
        {
            button_MID.Enabled = false;
            labelStatus = $"Writing MID: {textBox_MID.Text}...";
            await Task.Run(() => ADB.WriteString("mfg", textBox_MID.Text, offset_mid, 9, true));
            labelStatus = null;
            button_MID.Enabled = true;
        }

        private async void button_SN_Click(object sender, EventArgs e)
        {
            button_SN.Enabled = false;
            labelStatus = $"Writing SN: {textBox_SN.Text}...";
            await Task.Run(() => ADB.WriteString("mfg", textBox_SN.Text, offset_sn, 12));
            labelStatus = null;
            button_SN.Enabled = true;
        }

        private async void button_VER_Click(object sender, EventArgs e)
        {
            button_VER.Enabled = false;
            labelStatus = $"Writing VER: {textBox_VER.Text}...";
            await Task.Run(() => ADB.WriteString("misc", textBox_VER.Text, offset_ver, 16));
            labelStatus = null;
            button_VER.Enabled = true;
        }
    }
}
