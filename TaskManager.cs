using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        public TaskManager()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {

        }

        private void BTNProcesos_Click(object sender, EventArgs e)
        {
            openChildForm(new panelProcesos());
        }

        private void BTNProcesos_MouseHover(object sender, EventArgs e)
        {
            panelBTNProcesos.Visible = true;
        }

        private void BTNProcesos_MouseLeave(object sender, EventArgs e)
        {
            panelBTNProcesos.Visible = false;
        }

        private void BTNRendimiento_Click(object sender, EventArgs e)
        {
            openChildForm(new panelRendimiento());
        }

        private void BTNRendimiento_MouseHover(object sender, EventArgs e)
        {
            panelBTNRendimiento.Visible = true;
        }

        private void BTNRendimiento_MouseLeave(object sender, EventArgs e)
        {
            panelBTNRendimiento.Visible = false;
        }

        private void openChildForm(object childForm) {
            if (this.panelCentral.Controls.Count > 0)
                this.panelCentral.Controls.RemoveAt(0);
            Form fh = childForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCentral.Controls.Add(fh);
            this.panelCentral.Tag = fh;
            fh.Show();
        }

        private void barraMenu_Paint(object sender, PaintEventArgs e)
        {
            openChildForm(new panelProcesos());
        }

        private void BTNMenu_Click(object sender, EventArgs e)
        {
            // Hide or show button called 'BTNProcesos'

            BTNProcesos.Visible = !BTNProcesos.Visible;

            // Hide or show button called 'BTNRendimiento'

            BTNRendimiento.Visible = !BTNRendimiento.Visible;

        }

        private void BTNMenu_MouseHover(object sender, EventArgs e)
        {
            panelBTNMenu.Visible = true;
        }

        private void BTNMenu_MouseLeave(object sender, EventArgs e)
        {
            panelBTNMenu.Visible = false;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
       
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        { 

        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNEndTask_Click(object sender, EventArgs e)
        {
            try
            {
                sharedClass.proc[];
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
