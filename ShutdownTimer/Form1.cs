using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace ShutdownTimer
{
    public partial class Form_Interface : Form
    {
        public Form_Interface()
        {
            InitializeComponent();

            // Hour Item
            addItem(12, comboBox_Hour);

            // Minute Item
            addItem(59, comboBox_Minute);
        }

        private void addItem(int number, ComboBox comboBox)
        {           
            for (int i = 0; i <= number; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = i.ToString();
                item.Value = i;

                comboBox.Items.Add(item);
            }
            comboBox.SelectedIndex = 0;
        }

        private void shutdownTimer()
        {
            int hour = 3600 * int.Parse((comboBox_Hour.SelectedItem as ComboboxItem).Value.ToString());
            int minute = 60 * int.Parse((comboBox_Minute.SelectedItem as ComboboxItem).Value.ToString());
            int allSecond = hour + minute;

            if (allSecond == 0) { allSecond = 300; }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "shutdown.exe";
            startInfo.Arguments = "/s /f /t " + allSecond;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button_Shutdown_Click(object sender, EventArgs e)
        {
            shutdownTimer();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "shutdown.exe";
            startInfo.Arguments = "/a";
            process.StartInfo = startInfo;
            process.Start();
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
