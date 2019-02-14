namespace KelimeEzberle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblReadly = new System.Windows.Forms.Label();
            this.lblTurkish = new System.Windows.Forms.Label();
            this.btnDinle = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.BackColor = System.Drawing.Color.Transparent;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnglish.ForeColor = System.Drawing.Color.Black;
            this.lblEnglish.Location = new System.Drawing.Point(120, 12);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(85, 29);
            this.lblEnglish.TabIndex = 0;
            this.lblEnglish.Text = "label1";
            // 
            // lblReadly
            // 
            this.lblReadly.AutoSize = true;
            this.lblReadly.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReadly.Location = new System.Drawing.Point(10, 146);
            this.lblReadly.Name = "lblReadly";
            this.lblReadly.Size = new System.Drawing.Size(24, 7);
            this.lblReadly.TabIndex = 1;
            this.lblReadly.Text = "label2";
            // 
            // lblTurkish
            // 
            this.lblTurkish.AutoSize = true;
            this.lblTurkish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkish.Location = new System.Drawing.Point(120, 57);
            this.lblTurkish.Name = "lblTurkish";
            this.lblTurkish.Size = new System.Drawing.Size(70, 25);
            this.lblTurkish.TabIndex = 2;
            this.lblTurkish.Text = "label3";
            // 
            // btnDinle
            // 
            this.btnDinle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDinle.Location = new System.Drawing.Point(12, 12);
            this.btnDinle.Name = "btnDinle";
            this.btnDinle.Size = new System.Drawing.Size(75, 23);
            this.btnDinle.TabIndex = 3;
            this.btnDinle.Text = "Listen";
            this.btnDinle.UseVisualStyleBackColor = true;
            this.btnDinle.Click += new System.EventHandler(this.btnDinle_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Memorize Words";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 41);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Pause";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(584, 162);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnDinle);
            this.Controls.Add(this.lblTurkish);
            this.Controls.Add(this.lblReadly);
            this.Controls.Add(this.lblEnglish);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::KelimeEzberle.Properties.Settings.Default, "deneme", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::KelimeEzberle.Properties.Settings.Default.deneme;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Memorize Words";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblReadly;
        private System.Windows.Forms.Label lblTurkish;
        private System.Windows.Forms.Button btnDinle;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button1;
    }
}

