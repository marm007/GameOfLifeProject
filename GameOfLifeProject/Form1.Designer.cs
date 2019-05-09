namespace GameOfLifeProject
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
            this.startStateGroupBox = new System.Windows.Forms.GroupBox();
            this.queenBee = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.oscliatorButton = new System.Windows.Forms.Button();
            this.gliderButton = new System.Windows.Forms.Button();
            this.immutableButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.speedTracBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cellSizeTracBar = new System.Windows.Forms.TrackBar();
            this.applySettings = new System.Windows.Forms.Button();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.startStateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTracBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTracBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startStateGroupBox
            // 
            this.startStateGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startStateGroupBox.Controls.Add(this.queenBee);
            this.startStateGroupBox.Controls.Add(this.randomButton);
            this.startStateGroupBox.Controls.Add(this.oscliatorButton);
            this.startStateGroupBox.Controls.Add(this.gliderButton);
            this.startStateGroupBox.Controls.Add(this.immutableButton);
            this.startStateGroupBox.Location = new System.Drawing.Point(672, 12);
            this.startStateGroupBox.Name = "startStateGroupBox";
            this.startStateGroupBox.Size = new System.Drawing.Size(200, 178);
            this.startStateGroupBox.TabIndex = 0;
            this.startStateGroupBox.TabStop = false;
            this.startStateGroupBox.Text = "Wybierz stan poczatkowy";
            // 
            // queenBee
            // 
            this.queenBee.Location = new System.Drawing.Point(63, 137);
            this.queenBee.Name = "queenBee";
            this.queenBee.Size = new System.Drawing.Size(75, 23);
            this.queenBee.TabIndex = 5;
            this.queenBee.Text = "Queen bee shuttle";
            this.queenBee.UseVisualStyleBackColor = true;
            this.queenBee.Click += new System.EventHandler(this.queenBee_Click);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(63, 107);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(75, 23);
            this.randomButton.TabIndex = 4;
            this.randomButton.Text = "Losowy";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // oscliatorButton
            // 
            this.oscliatorButton.Location = new System.Drawing.Point(63, 78);
            this.oscliatorButton.Name = "oscliatorButton";
            this.oscliatorButton.Size = new System.Drawing.Size(75, 23);
            this.oscliatorButton.TabIndex = 3;
            this.oscliatorButton.Text = "Oscylator";
            this.oscliatorButton.UseVisualStyleBackColor = true;
            this.oscliatorButton.Click += new System.EventHandler(this.oscliatorButton_Click);
            // 
            // gliderButton
            // 
            this.gliderButton.Location = new System.Drawing.Point(63, 49);
            this.gliderButton.Name = "gliderButton";
            this.gliderButton.Size = new System.Drawing.Size(75, 23);
            this.gliderButton.TabIndex = 1;
            this.gliderButton.Text = "Glider";
            this.gliderButton.UseVisualStyleBackColor = true;
            this.gliderButton.Click += new System.EventHandler(this.gliderButton_Click);
            // 
            // immutableButton
            // 
            this.immutableButton.Location = new System.Drawing.Point(63, 19);
            this.immutableButton.Name = "immutableButton";
            this.immutableButton.Size = new System.Drawing.Size(75, 23);
            this.immutableButton.TabIndex = 0;
            this.immutableButton.Text = "Niezmienny";
            this.immutableButton.UseVisualStyleBackColor = true;
            this.immutableButton.Click += new System.EventHandler(this.immutableButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 537);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.speedTracBar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cellSizeTracBar);
            this.groupBox1.Controls.Add(this.applySettings);
            this.groupBox1.Controls.Add(this.heightBox);
            this.groupBox1.Controls.Add(this.widthBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(673, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane wejsciowe";
            // 
            // speedTracBar
            // 
            this.speedTracBar.Location = new System.Drawing.Point(62, 169);
            this.speedTracBar.Maximum = 200;
            this.speedTracBar.Name = "speedTracBar";
            this.speedTracBar.Size = new System.Drawing.Size(132, 45);
            this.speedTracBar.TabIndex = 8;
            this.speedTracBar.Value = 10;
            this.speedTracBar.Scroll += new System.EventHandler(this.speedTracBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cell size";
            // 
            // cellSizeTracBar
            // 
            this.cellSizeTracBar.LargeChange = 0;
            this.cellSizeTracBar.Location = new System.Drawing.Point(62, 118);
            this.cellSizeTracBar.Minimum = 1;
            this.cellSizeTracBar.Name = "cellSizeTracBar";
            this.cellSizeTracBar.Size = new System.Drawing.Size(132, 45);
            this.cellSizeTracBar.TabIndex = 5;
            this.cellSizeTracBar.Value = 5;
            this.cellSizeTracBar.Scroll += new System.EventHandler(this.cellSizeTracBar_Scroll);
            this.cellSizeTracBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cellSizeTrackBar_MouseDown);
            this.cellSizeTracBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cellSizeTrackBar_MouseUp);
            // 
            // applySettings
            // 
            this.applySettings.Location = new System.Drawing.Point(59, 76);
            this.applySettings.Name = "applySettings";
            this.applySettings.Size = new System.Drawing.Size(75, 23);
            this.applySettings.TabIndex = 4;
            this.applySettings.Text = "Zastosuj";
            this.applySettings.UseVisualStyleBackColor = true;
            this.applySettings.Click += new System.EventHandler(this.applySettings_Click);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(59, 49);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 3;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(59, 21);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.stopButton);
            this.groupBox2.Controls.Add(this.startButton);
            this.groupBox2.Location = new System.Drawing.Point(673, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrola symulacji";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(62, 79);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(62, 49);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(62, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startStateGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.startStateGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTracBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTracBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox startStateGroupBox;
        private System.Windows.Forms.Button immutableButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button oscliatorButton;
        private System.Windows.Forms.Button gliderButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button applySettings;
        private System.Windows.Forms.Button queenBee;
        private System.Windows.Forms.TrackBar cellSizeTracBar;
        private System.Windows.Forms.TrackBar speedTracBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

