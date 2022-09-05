namespace TaskManager
{
    partial class TaskManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManager));
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barraMenu = new System.Windows.Forms.Panel();
            this.panelBTNMenu = new System.Windows.Forms.Panel();
            this.BTNMenu = new System.Windows.Forms.Button();
            this.panelBTNRendimiento = new System.Windows.Forms.Panel();
            this.panelBTNProcesos = new System.Windows.Forms.Panel();
            this.BTNRendimiento = new System.Windows.Forms.Button();
            this.BTNProcesos = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelBTNS = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNEndTask = new System.Windows.Forms.Button();
            this.BTNRefresh = new System.Windows.Forms.Button();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barraMenu.SuspendLayout();
            this.panelBTNS.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.barraSuperior.Controls.Add(this.label1);
            this.barraSuperior.Controls.Add(this.pictureBox2);
            this.barraSuperior.Controls.Add(this.pictureBox1);
            this.barraSuperior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(800, 35);
            this.barraSuperior.TabIndex = 0;
            this.barraSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.barraSuperior_Paint);
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Manager";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(771, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.barraMenu.Controls.Add(this.panelBTNMenu);
            this.barraMenu.Controls.Add(this.BTNMenu);
            this.barraMenu.Controls.Add(this.panelBTNRendimiento);
            this.barraMenu.Controls.Add(this.panelBTNProcesos);
            this.barraMenu.Controls.Add(this.BTNRendimiento);
            this.barraMenu.Controls.Add(this.BTNProcesos);
            this.barraMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraMenu.Location = new System.Drawing.Point(0, 35);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(145, 465);
            this.barraMenu.TabIndex = 1;
            this.barraMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.barraMenu_Paint);
            // 
            // panelBTNMenu
            // 
            this.panelBTNMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.panelBTNMenu.Location = new System.Drawing.Point(2, 0);
            this.panelBTNMenu.Name = "panelBTNMenu";
            this.panelBTNMenu.Size = new System.Drawing.Size(3, 32);
            this.panelBTNMenu.TabIndex = 3;
            this.panelBTNMenu.Visible = false;
            // 
            // BTNMenu
            // 
            this.BTNMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.BTNMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMenu.FlatAppearance.BorderSize = 0;
            this.BTNMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.BTNMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNMenu.Image = ((System.Drawing.Image)(resources.GetObject("BTNMenu.Image")));
            this.BTNMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMenu.Location = new System.Drawing.Point(5, 0);
            this.BTNMenu.Name = "BTNMenu";
            this.BTNMenu.Size = new System.Drawing.Size(138, 32);
            this.BTNMenu.TabIndex = 2;
            this.BTNMenu.UseVisualStyleBackColor = false;
            this.BTNMenu.Click += new System.EventHandler(this.BTNMenu_Click);
            this.BTNMenu.MouseLeave += new System.EventHandler(this.BTNMenu_MouseLeave);
            this.BTNMenu.MouseHover += new System.EventHandler(this.BTNMenu_MouseHover);
            // 
            // panelBTNRendimiento
            // 
            this.panelBTNRendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.panelBTNRendimiento.Location = new System.Drawing.Point(2, 69);
            this.panelBTNRendimiento.Name = "panelBTNRendimiento";
            this.panelBTNRendimiento.Size = new System.Drawing.Size(3, 32);
            this.panelBTNRendimiento.TabIndex = 1;
            this.panelBTNRendimiento.Visible = false;
            // 
            // panelBTNProcesos
            // 
            this.panelBTNProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.panelBTNProcesos.Location = new System.Drawing.Point(2, 36);
            this.panelBTNProcesos.Name = "panelBTNProcesos";
            this.panelBTNProcesos.Size = new System.Drawing.Size(3, 32);
            this.panelBTNProcesos.TabIndex = 0;
            this.panelBTNProcesos.Visible = false;
            // 
            // BTNRendimiento
            // 
            this.BTNRendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.BTNRendimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNRendimiento.FlatAppearance.BorderSize = 0;
            this.BTNRendimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.BTNRendimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRendimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRendimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNRendimiento.Image = ((System.Drawing.Image)(resources.GetObject("BTNRendimiento.Image")));
            this.BTNRendimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNRendimiento.Location = new System.Drawing.Point(5, 69);
            this.BTNRendimiento.Name = "BTNRendimiento";
            this.BTNRendimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTNRendimiento.Size = new System.Drawing.Size(138, 32);
            this.BTNRendimiento.TabIndex = 1;
            this.BTNRendimiento.Text = "Rendimiento";
            this.BTNRendimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNRendimiento.UseVisualStyleBackColor = false;
            this.BTNRendimiento.Visible = false;
            this.BTNRendimiento.Click += new System.EventHandler(this.BTNRendimiento_Click);
            this.BTNRendimiento.MouseLeave += new System.EventHandler(this.BTNRendimiento_MouseLeave);
            this.BTNRendimiento.MouseHover += new System.EventHandler(this.BTNRendimiento_MouseHover);
            // 
            // BTNProcesos
            // 
            this.BTNProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.BTNProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNProcesos.FlatAppearance.BorderSize = 0;
            this.BTNProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.BTNProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNProcesos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNProcesos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNProcesos.Image = ((System.Drawing.Image)(resources.GetObject("BTNProcesos.Image")));
            this.BTNProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNProcesos.Location = new System.Drawing.Point(5, 36);
            this.BTNProcesos.Name = "BTNProcesos";
            this.BTNProcesos.Size = new System.Drawing.Size(138, 32);
            this.BTNProcesos.TabIndex = 0;
            this.BTNProcesos.Text = " Procesos";
            this.BTNProcesos.UseVisualStyleBackColor = false;
            this.BTNProcesos.Visible = false;
            this.BTNProcesos.Click += new System.EventHandler(this.BTNProcesos_Click);
            this.BTNProcesos.MouseLeave += new System.EventHandler(this.BTNProcesos_MouseLeave);
            this.BTNProcesos.MouseHover += new System.EventHandler(this.BTNProcesos_MouseHover);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(145, 35);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(655, 68);
            this.panelInfo.TabIndex = 2;
            this.panelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfo_Paint);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelCentral.Location = new System.Drawing.Point(145, 104);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(655, 396);
            this.panelCentral.TabIndex = 3;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Paint);
            // 
            // panelBTNS
            // 
            this.panelBTNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelBTNS.Controls.Add(this.button1);
            this.panelBTNS.Controls.Add(this.BTNEndTask);
            this.panelBTNS.Controls.Add(this.BTNRefresh);
            this.panelBTNS.Location = new System.Drawing.Point(606, 104);
            this.panelBTNS.Name = "panelBTNS";
            this.panelBTNS.Size = new System.Drawing.Size(194, 28);
            this.panelBTNS.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(103, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BTNEndTask
            // 
            this.BTNEndTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNEndTask.FlatAppearance.BorderSize = 0;
            this.BTNEndTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.BTNEndTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEndTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEndTask.ForeColor = System.Drawing.Color.White;
            this.BTNEndTask.Image = ((System.Drawing.Image)(resources.GetObject("BTNEndTask.Image")));
            this.BTNEndTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEndTask.Location = new System.Drawing.Point(107, 2);
            this.BTNEndTask.Name = "BTNEndTask";
            this.BTNEndTask.Size = new System.Drawing.Size(101, 23);
            this.BTNEndTask.TabIndex = 1;
            this.BTNEndTask.Text = "End Task";
            this.BTNEndTask.UseVisualStyleBackColor = false;
            this.BTNEndTask.Click += new System.EventHandler(this.BTNEndTask_Click);
            // 
            // BTNRefresh
            // 
            this.BTNRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNRefresh.FlatAppearance.BorderSize = 0;
            this.BTNRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.BTNRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRefresh.ForeColor = System.Drawing.Color.White;
            this.BTNRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BTNRefresh.Image")));
            this.BTNRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNRefresh.Location = new System.Drawing.Point(4, 2);
            this.BTNRefresh.Name = "BTNRefresh";
            this.BTNRefresh.Size = new System.Drawing.Size(97, 23);
            this.BTNRefresh.TabIndex = 0;
            this.BTNRefresh.Text = "Refresh";
            this.BTNRefresh.UseVisualStyleBackColor = false;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelBTNS);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.barraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskManager";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.barraSuperior.ResumeLayout(false);
            this.barraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barraMenu.ResumeLayout(false);
            this.panelBTNS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Panel barraMenu;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNProcesos;
        private System.Windows.Forms.Button BTNRendimiento;
        private System.Windows.Forms.Panel panelBTNProcesos;
        private System.Windows.Forms.Panel panelBTNRendimiento;
        private System.Windows.Forms.Button BTNMenu;
        private System.Windows.Forms.Panel panelBTNMenu;
        private System.Windows.Forms.Panel panelBTNS;
        private System.Windows.Forms.Button BTNRefresh;
        private System.Windows.Forms.Button BTNEndTask;
        private System.Windows.Forms.Button button1;
    }
}

