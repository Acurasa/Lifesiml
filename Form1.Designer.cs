
namespace Lifesiml
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Died = new System.Windows.Forms.Label();
            this.Borned = new System.Windows.Forms.Label();
            this.genLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Speed1 = new System.Windows.Forms.NumericUpDown();
            this.stopButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.setDens = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.setRes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setDens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Lifesiml.Properties.Resources.photo_2021_02_11_19_16_41;
            this.splitContainer1.Panel1.Controls.Add(this.Died);
            this.splitContainer1.Panel1.Controls.Add(this.Borned);
            this.splitContainer1.Panel1.Controls.Add(this.genLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.Speed1);
            this.splitContainer1.Panel1.Controls.Add(this.stopButton);
            this.splitContainer1.Panel1.Controls.Add(this.runButton);
            this.splitContainer1.Panel1.Controls.Add(this.setDens);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.setRes);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.screen);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 651);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 0;
            // 
            // Died
            // 
            this.Died.BackColor = System.Drawing.Color.White;
            this.Died.Location = new System.Drawing.Point(27, 431);
            this.Died.Name = "Died";
            this.Died.Size = new System.Drawing.Size(216, 16);
            this.Died.TabIndex = 10;
            this.Died.Text = "Died :";
            // 
            // Borned
            // 
            this.Borned.BackColor = System.Drawing.Color.White;
            this.Borned.Location = new System.Drawing.Point(27, 395);
            this.Borned.Name = "Borned";
            this.Borned.Size = new System.Drawing.Size(216, 16);
            this.Borned.TabIndex = 9;
            this.Borned.Text = "Borned : ";
            // 
            // genLabel
            // 
            this.genLabel.BackColor = System.Drawing.Color.White;
            this.genLabel.Location = new System.Drawing.Point(28, 363);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(216, 16);
            this.genLabel.TabIndex = 8;
            this.genLabel.Text = "Generation № : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Speed1
            // 
            this.Speed1.Location = new System.Drawing.Point(124, 142);
            this.Speed1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Speed1.Name = "Speed1";
            this.Speed1.Size = new System.Drawing.Size(120, 20);
            this.Speed1.TabIndex = 6;
            this.Speed1.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.Speed1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(137, 324);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(56, 324);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // setDens
            // 
            this.setDens.Location = new System.Drawing.Point(124, 23);
            this.setDens.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.setDens.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.setDens.Name = "setDens";
            this.setDens.Size = new System.Drawing.Size(120, 20);
            this.setDens.TabIndex = 3;
            this.setDens.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Intensivity";
            // 
            // setRes
            // 
            this.setRes.Location = new System.Drawing.Point(124, 83);
            this.setRes.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.setRes.Name = "setRes";
            this.setRes.Size = new System.Drawing.Size(120, 20);
            this.setRes.TabIndex = 1;
            this.setRes.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution\r\n";
            // 
            // screen
            // 
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(750, 647);
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            this.screen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.screen_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1136, 651);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Speed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setDens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown setRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.NumericUpDown setDens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Speed1;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.Label Died;
        private System.Windows.Forms.Label Borned;
    }
}

