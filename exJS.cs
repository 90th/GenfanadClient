using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GenfanadClient {

    public partial class exJS : Form {
        private ChromiumWebBrowser cefSharpBrowser;

        // private Point _previousForm2Position;
        public exJS(ChromiumWebBrowser browser) {
            InitializeComponent();
            // _previousForm2Position = this.Location;
            cefSharpBrowser = browser;
        }

        private void button1_Click(object sender, EventArgs e) {
            cefSharpBrowser.ExecuteScriptAsync(richTextBox1.Text);
            this.Close();
        }

        private void exJS_Load(object sender, EventArgs e) {
            siticoneAnimateWindow1.SetAnimateWindow(this);
            richTextBox1.Text = "alert(\"Hello World!\");";
        }
        private void exJS_LocationChanged(object sender, EventArgs e) {
            {
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            // getting keywords/functions
            string keywords = @"\b(abstract|as|base|break|case|catch|checked|continue|default|delegate|do|else|event|explicit|extern|false|finally|fixed|for|foreach|goto|if|implicit|in|interface|internal|is|lock|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sealed|sizeof|stackalloc|switch|this|throw|true|try|typeof|unchecked|unsafe|using|virtual|volatile|while|alert)\b";
            MatchCollection keywordMatches = Regex.Matches(richTextBox1.Text, keywords);

            // getting types/classes from the text
            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(richTextBox1.Text, types);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(richTextBox1.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(richTextBox1.Text, strings);

            string stringz = "bool|byte|char|class|const|decimal|double|enum|float|int|long|sbyte|short|static|string|struct|uint|ulong|ushort|void";
            MatchCollection stringzMatchez = Regex.Matches(richTextBox1.Text, stringz);

            // saving the original caret position + forecolor
            int originalIndex = richTextBox1.SelectionStart;
            int originalLength = richTextBox1.SelectionLength;
            Color originalColor = Color.GhostWhite;

            // MANDATORY - focuses a label before highlighting (avoids blinking)
            label1.Focus();

            // removes any previous highlighting (so modified words won't remain highlighted)
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionColor = originalColor;

            // scanning...
            foreach (Match m in keywordMatches) {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.IndianRed;
            }

            foreach (Match m in typeMatches) {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.DarkCyan;
            }

            foreach (Match m in commentMatches) {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches) {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.LightGreen;
            }

            foreach (Match m in stringzMatchez) {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.Purple;
            }

            // restoring the original colors, for further writing
            richTextBox1.SelectionStart = originalIndex;
            richTextBox1.SelectionLength = originalLength;
            richTextBox1.SelectionColor = originalColor;

            // giving back the focus
            richTextBox1.Focus();
        }
    }
}