using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientResizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ocean.SelectedIndex = 0;
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            var pirateName = PirateName.Text;
            var ocean = Ocean.SelectedItem.ToString();

            if (pirateName.Length < 2 || pirateName.Length > 12)
            {
                MessageBox.Show("Invalid Pirate Name");
                return;
            }

            var clientString = $"Puzzle Pirates - {pirateName} on the {ocean} ocean";

            var clientHandle = WindowsInterface.WinGetHandle(clientString);

            if (clientHandle == IntPtr.Zero)
            {
                MessageBox.Show($"Failed to find process \"{clientString}\"");
                return;
            }

            WindowsInterface.ResizeWindow(clientHandle, (int)Width.Value, (int)Height.Value);
        }
    }
}
