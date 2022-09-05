using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class panelProcesos : Form
    {
        public panelProcesos()
        {
            InitializeComponent();
        }


        void getAllprocess()
        {
            sharedClass.proc = Process.GetProcesses();
            listBoxProcesos.Items.Clear();
            foreach (Process p in sharedClass.proc)
                listBoxProcesos.Items.Add(p.ProcessName);

        }

        private void panelProcesos_Load(object sender, EventArgs e)
        {
            getAllprocess();
        }
    }

    public static class sharedClass
    {
        public static Process[] proc;
    }




}
