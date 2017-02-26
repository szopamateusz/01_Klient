namespace _01_Klient
{
    partial class Form1
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
            this.btConnect = new System.Windows.Forms.Button();
            this.nrPort = new System.Windows.Forms.NumericUpDown();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lbMessages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nrPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(159, 271);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(154, 41);
            this.btConnect.TabIndex = 11;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // nrPort
            // 
            this.nrPort.Location = new System.Drawing.Point(319, 12);
            this.nrPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nrPort.Name = "nrPort";
            this.nrPort.Size = new System.Drawing.Size(120, 22);
            this.nrPort.TabIndex = 9;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(279, 12);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 17);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(60, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(213, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(9, 12);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 17);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Adres";
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 16;
            this.lbMessages.Location = new System.Drawing.Point(12, 40);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(427, 228);
            this.lbMessages.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 325);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.nrPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Name = "Form1";
            this.Text = "TCP Klient (01)";
            ((System.ComponentModel.ISupportInitialize)(this.nrPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.NumericUpDown nrPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ListBox lbMessages;

    }
}

