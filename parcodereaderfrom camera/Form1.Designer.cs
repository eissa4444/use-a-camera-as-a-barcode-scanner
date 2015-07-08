namespace parcodereaderfrom_camera
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
            this.txtDecoderType = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.txtDecoderContent = new System.Windows.Forms.TextBox();
            this.generatebtn = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.brousebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDecoderType
            // 
            this.txtDecoderType.Location = new System.Drawing.Point(22, 12);
            this.txtDecoderType.Name = "txtDecoderType";
            this.txtDecoderType.Size = new System.Drawing.Size(266, 20);
            this.txtDecoderType.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(326, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(91, 328);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCameras.TabIndex = 4;
            // 
            // txtDecoderContent
            // 
            this.txtDecoderContent.Location = new System.Drawing.Point(22, 38);
            this.txtDecoderContent.Name = "txtDecoderContent";
            this.txtDecoderContent.Size = new System.Drawing.Size(266, 20);
            this.txtDecoderContent.TabIndex = 5;
            this.txtDecoderContent.TextChanged += new System.EventHandler(this.txtDecoderContent_TextChanged);
            // 
            // generatebtn
            // 
            this.generatebtn.Location = new System.Drawing.Point(316, 24);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(75, 23);
            this.generatebtn.TabIndex = 6;
            this.generatebtn.Text = "generate";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(436, 24);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(75, 23);
            this.insertbtn.TabIndex = 7;
            this.insertbtn.Text = "insert";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(672, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 193);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // brousebtn
            // 
            this.brousebtn.Location = new System.Drawing.Point(719, 304);
            this.brousebtn.Name = "brousebtn";
            this.brousebtn.Size = new System.Drawing.Size(75, 23);
            this.brousebtn.TabIndex = 9;
            this.brousebtn.Text = "brouse";
            this.brousebtn.UseVisualStyleBackColor = true;
            this.brousebtn.Click += new System.EventHandler(this.brousebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 399);
            this.Controls.Add(this.brousebtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.txtDecoderContent);
            this.Controls.Add(this.comboBoxCameras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDecoderType);
            this.Name = "Form1";
            this.Text = "parcode from camera EISSA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecoderType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.TextBox txtDecoderContent;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button brousebtn;
    }
}

