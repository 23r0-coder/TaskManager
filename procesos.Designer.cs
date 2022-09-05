namespace TaskManager
{
    partial class panelProcesos
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
            this.listBoxProcesos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxProcesos
            // 
            this.listBoxProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.listBoxProcesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProcesos.FormattingEnabled = true;
            this.listBoxProcesos.Location = new System.Drawing.Point(1, 27);
            this.listBoxProcesos.Name = "listBoxProcesos";
            this.listBoxProcesos.Size = new System.Drawing.Size(652, 364);
            this.listBoxProcesos.TabIndex = 2;
            // 
            // panelProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(655, 396);
            this.Controls.Add(this.listBoxProcesos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelProcesos";
            this.Text = "procesos";
            this.Load += new System.EventHandler(this.panelProcesos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcesos;
    }
}