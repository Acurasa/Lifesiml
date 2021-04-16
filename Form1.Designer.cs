
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.stopButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.setDens = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.setRes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.screen1 = new System.Windows.Forms.PictureBox();
            this.screen2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setDens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen2)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.stopButton);
            this.splitContainer1.Panel1.Controls.Add(this.runButton);
            this.splitContainer1.Panel1.Controls.Add(this.setDens);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.setRes);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.screen2);
            this.splitContainer1.Panel2.Controls.Add(this.screen1);
            this.splitContainer1.Panel2.Controls.Add(this.screen);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 651);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 0;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(32, 179);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(30, 140);
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
            this.screen.Location = new System.Drawing.Point(-7, -2);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(382, 406);
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // screen1
            // 
            this.screen1.Location = new System.Drawing.Point(381, -2);
            this.screen1.Name = "screen1";
            this.screen1.Size = new System.Drawing.Size(371, 406);
            this.screen1.TabIndex = 1;
            this.screen1.TabStop = false;
            // 
            // screen2
            // 
            this.screen2.Location = new System.Drawing.Point(3, 410);
            this.screen2.Name = "screen2";
            this.screen2.Size = new System.Drawing.Size(744, 227);
            this.screen2.TabIndex = 2;
            this.screen2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 651);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setDens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen2)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox screen1;
        private System.Windows.Forms.PictureBox screen2;
    }
}

