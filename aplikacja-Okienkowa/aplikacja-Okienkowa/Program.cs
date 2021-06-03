using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacja_Okienkowa
{
    public class MainForm : Form
    {
        Button button = new Button();
        public MainForm()
        {
            this.Width = 320;
            this.Height = 500;
            this.Text = "Tytuł okna";
            Application.ApplicationExit += new EventHandler(this.onExit);
        }
        private void onExit(object sender, EventArgs ea) 
        {
            MessageBox.Show("Aplikacja zostanie zamknięta!");
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
