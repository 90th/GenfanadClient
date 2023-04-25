using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GenfanadClient {

    public partial class Client : Form {

        public Client() {
            InitializeComponent();

            using (var settings = new CefSettings()) {
                settings.CefCommandLineArgs.Add("enable-gpu-compositing", "1");
                settings.CefCommandLineArgs.Add("enable-begin-frame-scheduling", "1");
                Cef.Initialize(settings);
            }

            this.KeyPreview = true;
        }
        private async void Client_Load(object sender, EventArgs e) {
            chromiumWebBrowser1.Focus();

            siticoneAnimateWindow1.SetAnimateWindow(this);

            await chromiumWebBrowser1.LoadUrlAsync("https://play.genfanad.com/play/");
        }

        private void ControlBox1_Click(object sender, EventArgs e) => Cef.Shutdown();

        private void JavaScriptToolStrip_Click(object sender, EventArgs e) {
            exJS exJSForm = new exJS(chromiumWebBrowser1) {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent // Set the StartPosition to CenterParent
            };
            exJSForm.ShowDialog();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e) => chromiumWebBrowser1.LoadUrlAsync("https://play.genfanad.com/play/");
    }
}