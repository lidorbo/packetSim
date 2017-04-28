namespace packetSimulator
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
            this.packetTxt = new System.Windows.Forms.TextBox();
            this.packetLen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.portText = new System.Windows.Forms.TextBox();
            this.conncectBtn = new System.Windows.Forms.Button();
            this.numOfMsg = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOfMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // packetTxt
            // 
            this.packetTxt.Location = new System.Drawing.Point(12, 151);
            this.packetTxt.Multiline = true;
            this.packetTxt.Name = "packetTxt";
            this.packetTxt.Size = new System.Drawing.Size(388, 243);
            this.packetTxt.TabIndex = 3;
            // 
            // packetLen
            // 
            this.packetLen.Location = new System.Drawing.Point(106, 76);
            this.packetLen.Name = "packetLen";
            this.packetLen.Size = new System.Drawing.Size(129, 20);
            this.packetLen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Packet Length";
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(271, 76);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(129, 23);
            this.genBtn.TabIndex = 6;
            this.genBtn.Text = "Generete";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(156, 400);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(129, 23);
            this.sendBtn.TabIndex = 7;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "IP";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(106, 12);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(129, 20);
            this.ipText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port";
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(106, 38);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(129, 20);
            this.portText.TabIndex = 10;
            // 
            // conncectBtn
            // 
            this.conncectBtn.Location = new System.Drawing.Point(271, 38);
            this.conncectBtn.Name = "conncectBtn";
            this.conncectBtn.Size = new System.Drawing.Size(129, 23);
            this.conncectBtn.TabIndex = 12;
            this.conncectBtn.Text = "Connect";
            this.conncectBtn.UseVisualStyleBackColor = true;
            this.conncectBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // numOfMsg
            // 
            this.numOfMsg.Location = new System.Drawing.Point(106, 115);
            this.numOfMsg.Name = "numOfMsg";
            this.numOfMsg.Size = new System.Drawing.Size(129, 20);
            this.numOfMsg.TabIndex = 13;
            this.numOfMsg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Times";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 435);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOfMsg);
            this.Controls.Add(this.conncectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packetLen);
            this.Controls.Add(this.packetTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numOfMsg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox packetTxt;
        private System.Windows.Forms.TextBox packetLen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.Button conncectBtn;
        private System.Windows.Forms.NumericUpDown numOfMsg;
        private System.Windows.Forms.Label label4;
    }
}

