using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp6
{
    public partial class CSharp5Form : Form
    {
        public CSharp5Form()
        {
            InitializeComponent();
        }

        private static string SLEEP_URL = "http://kheiakiyama-sample.azurewebsites.net/sleep.php?SECOND=5";

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "Doing...";
            WebClient client = new WebClient();
            client.DownloadString(SLEEP_URL);
            Text = "DONE!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = "Doing...";
            WebClient client = new WebClient();
            client.DownloadStringAsync(new Uri(SLEEP_URL));
            Text = "DONE!!";
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Text = "Doing...";
            WebClient client = new WebClient();
            await client.DownloadStringTaskAsync(SLEEP_URL);
            Text = "DONE!!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Text = "Reset";
        }
    }
}
