namespace iBeaconer
{
    partial class mainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWin));
            this.execute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uuid = new System.Windows.Forms.TextBox();
            this.major = new System.Windows.Forms.TextBox();
            this.minor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomSelect = new System.Windows.Forms.ComboBox();
            this.indicator = new System.Windows.Forms.Label();
            this.helpTip = new System.Windows.Forms.ToolTip(this.components);
            this.stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // execute
            // 
            this.execute.Cursor = System.Windows.Forms.Cursors.Cross;
            this.execute.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.execute.Location = new System.Drawing.Point(38, 117);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(125, 23);
            this.execute.TabIndex = 5;
            this.execute.Text = "Fire!";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anthony\'s iBeacon Broacasting Tool";
            this.helpTip.SetToolTip(this.label1, "Created Oct 2018 by Anthony | v1.1");
            // 
            // uuid
            // 
            this.uuid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uuid.Cursor = System.Windows.Forms.Cursors.Cross;
            this.uuid.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.uuid.Location = new System.Drawing.Point(38, 47);
            this.uuid.MaxLength = 47;
            this.uuid.Name = "uuid";
            this.uuid.Size = new System.Drawing.Size(288, 13);
            this.uuid.TabIndex = 2;
            this.uuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uuid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uuid_KeyPress);
            // 
            // major
            // 
            this.major.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.major.Cursor = System.Windows.Forms.Cursors.Cross;
            this.major.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.major.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.major.Location = new System.Drawing.Point(38, 84);
            this.major.MaxLength = 5;
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(125, 13);
            this.major.TabIndex = 3;
            this.major.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.major.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.major_KeyPress);
            // 
            // minor
            // 
            this.minor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minor.Cursor = System.Windows.Forms.Cursors.Cross;
            this.minor.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.minor.Location = new System.Drawing.Point(201, 84);
            this.minor.MaxLength = 5;
            this.minor.Name = "minor";
            this.minor.Size = new System.Drawing.Size(125, 13);
            this.minor.TabIndex = 4;
            this.minor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "Room UUID";
            this.helpTip.SetToolTip(this.label2, "Click to Paste Clipboard");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "Major Pair                                    Minor Pair";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomSelect
            // 
            this.roomSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.roomSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.roomSelect.Cursor = System.Windows.Forms.Cursors.Cross;
            this.roomSelect.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.roomSelect.FormattingEnabled = true;
            this.roomSelect.Location = new System.Drawing.Point(38, 190);
            this.roomSelect.Name = "roomSelect";
            this.roomSelect.Size = new System.Drawing.Size(288, 24);
            this.roomSelect.TabIndex = 8;
            this.roomSelect.Text = "Beacon Presets";
            this.helpTip.SetToolTip(this.roomSelect, "Presets for the University of Exeter");
            this.roomSelect.SelectedIndexChanged += new System.EventHandler(this.roomSelect_SelectedIndexChanged);
            this.roomSelect.Click += new System.EventHandler(this.roomSelect_Click);
            // 
            // indicator
            // 
            this.indicator.AutoSize = true;
            this.indicator.BackColor = System.Drawing.Color.Transparent;
            this.indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator.ForeColor = System.Drawing.Color.Red;
            this.indicator.Location = new System.Drawing.Point(90, 155);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(188, 16);
            this.indicator.TabIndex = 99;
            this.indicator.Text = "████████████████████";
            this.indicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stop
            // 
            this.stop.Cursor = System.Windows.Forms.Cursors.Cross;
            this.stop.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.stop.Location = new System.Drawing.Point(201, 117);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(125, 23);
            this.stop.TabIndex = 6;
            this.stop.Text = "Cease";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::iBeaconer.Properties.Resources.bgwin;
            this.ClientSize = new System.Drawing.Size(362, 226);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.roomSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minor);
            this.Controls.Add(this.major);
            this.Controls.Add(this.uuid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.execute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iBeaconer by Anthony";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uuid;
        private System.Windows.Forms.TextBox major;
        private System.Windows.Forms.TextBox minor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roomSelect;
        private System.Windows.Forms.Label indicator;
        private System.Windows.Forms.ToolTip helpTip;
        private System.Windows.Forms.Button stop;
    }
}

