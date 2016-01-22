namespace TargetFramework
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearSequence = new System.Windows.Forms.Button();
            this.runSequence = new System.Windows.Forms.Button();
            this.addDelayToSequenceBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addTargetArrayToSequenceBtn = new System.Windows.Forms.Button();
            this.saveSeq = new System.Windows.Forms.Button();
            this.loadSeq = new System.Windows.Forms.Button();
            this.T1 = new TargetFramework.ThreeWayTarget();
            this.T2 = new TargetFramework.ThreeWayTarget();
            this.T8 = new TargetFramework.ThreeWayTarget();
            this.T7 = new TargetFramework.ThreeWayTarget();
            this.T3 = new TargetFramework.ThreeWayTarget();
            this.T4 = new TargetFramework.ThreeWayTarget();
            this.T5 = new TargetFramework.ThreeWayTarget();
            this.T6 = new TargetFramework.ThreeWayTarget();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.saveSeq);
            this.groupBox1.Controls.Add(this.loadSeq);
            this.groupBox1.Controls.Add(this.serialPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clearSequence);
            this.groupBox1.Controls.Add(this.runSequence);
            this.groupBox1.Controls.Add(this.addDelayToSequenceBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.delay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 353);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Array Sequence";
            // 
            // serialPort
            // 
            this.serialPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serialPort.Location = new System.Drawing.Point(945, 112);
            this.serialPort.Name = "serialPort";
            this.serialPort.Size = new System.Drawing.Size(82, 20);
            this.serialPort.TabIndex = 22;
            this.serialPort.Text = "COM1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(905, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Port";
            // 
            // clearSequence
            // 
            this.clearSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSequence.Location = new System.Drawing.Point(905, 138);
            this.clearSequence.Name = "clearSequence";
            this.clearSequence.Size = new System.Drawing.Size(157, 23);
            this.clearSequence.TabIndex = 20;
            this.clearSequence.Text = "Clear Sequence";
            this.clearSequence.UseVisualStyleBackColor = true;
            this.clearSequence.Click += new System.EventHandler(this.clearSequence_Click);
            // 
            // runSequence
            // 
            this.runSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runSequence.Location = new System.Drawing.Point(905, 167);
            this.runSequence.Name = "runSequence";
            this.runSequence.Size = new System.Drawing.Size(157, 23);
            this.runSequence.TabIndex = 19;
            this.runSequence.Text = "Run Sequence";
            this.runSequence.UseVisualStyleBackColor = true;
            this.runSequence.Click += new System.EventHandler(this.runSequence_Click);
            // 
            // addDelayToSequenceBtn
            // 
            this.addDelayToSequenceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addDelayToSequenceBtn.Location = new System.Drawing.Point(905, 42);
            this.addDelayToSequenceBtn.Name = "addDelayToSequenceBtn";
            this.addDelayToSequenceBtn.Size = new System.Drawing.Size(157, 23);
            this.addDelayToSequenceBtn.TabIndex = 18;
            this.addDelayToSequenceBtn.Text = "< Add Delay To Sequence";
            this.addDelayToSequenceBtn.UseVisualStyleBackColor = true;
            this.addDelayToSequenceBtn.Click += new System.EventHandler(this.addDelayToSequenceBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1033, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "sec";
            // 
            // delay
            // 
            this.delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delay.Location = new System.Drawing.Point(945, 15);
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(82, 20);
            this.delay.TabIndex = 16;
            this.delay.Text = "1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Delay";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(893, 328);
            this.dataGridView1.TabIndex = 7;
            // 
            // addTargetArrayToSequenceBtn
            // 
            this.addTargetArrayToSequenceBtn.Location = new System.Drawing.Point(371, 322);
            this.addTargetArrayToSequenceBtn.Name = "addTargetArrayToSequenceBtn";
            this.addTargetArrayToSequenceBtn.Size = new System.Drawing.Size(226, 23);
            this.addTargetArrayToSequenceBtn.TabIndex = 9;
            this.addTargetArrayToSequenceBtn.Text = "V Add Target Array To Sequence V";
            this.addTargetArrayToSequenceBtn.UseVisualStyleBackColor = true;
            this.addTargetArrayToSequenceBtn.Click += new System.EventHandler(this.addTargetArrayToSequenceBtn_Click);
            // 
            // saveSeq
            // 
            this.saveSeq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSeq.Location = new System.Drawing.Point(905, 295);
            this.saveSeq.Name = "saveSeq";
            this.saveSeq.Size = new System.Drawing.Size(157, 23);
            this.saveSeq.TabIndex = 24;
            this.saveSeq.Text = "Save Sequence To Disk";
            this.saveSeq.UseVisualStyleBackColor = true;
            this.saveSeq.Click += new System.EventHandler(this.saveSeq_Click);
            // 
            // loadSeq
            // 
            this.loadSeq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadSeq.Location = new System.Drawing.Point(905, 324);
            this.loadSeq.Name = "loadSeq";
            this.loadSeq.Size = new System.Drawing.Size(157, 23);
            this.loadSeq.TabIndex = 23;
            this.loadSeq.Text = "Load Sequence";
            this.loadSeq.UseVisualStyleBackColor = true;
            this.loadSeq.Click += new System.EventHandler(this.loadSeq_Click);
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(693, 238);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(221, 107);
            this.T1.TabIndex = 7;
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(693, 125);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(221, 107);
            this.T2.TabIndex = 6;
            // 
            // T8
            // 
            this.T8.Location = new System.Drawing.Point(12, 238);
            this.T8.Name = "T8";
            this.T8.Size = new System.Drawing.Size(221, 107);
            this.T8.TabIndex = 5;
            // 
            // T7
            // 
            this.T7.Location = new System.Drawing.Point(12, 125);
            this.T7.Name = "T7";
            this.T7.Size = new System.Drawing.Size(221, 107);
            this.T7.TabIndex = 4;
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(693, 12);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(221, 107);
            this.T3.TabIndex = 3;
            // 
            // T4
            // 
            this.T4.Location = new System.Drawing.Point(466, 12);
            this.T4.Name = "T4";
            this.T4.Size = new System.Drawing.Size(221, 107);
            this.T4.TabIndex = 2;
            // 
            // T5
            // 
            this.T5.Location = new System.Drawing.Point(239, 12);
            this.T5.Name = "T5";
            this.T5.Size = new System.Drawing.Size(221, 107);
            this.T5.TabIndex = 1;
            // 
            // T6
            // 
            this.T6.Location = new System.Drawing.Point(12, 12);
            this.T6.Name = "T6";
            this.T6.Size = new System.Drawing.Size(221, 107);
            this.T6.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 716);
            this.Controls.Add(this.addTargetArrayToSequenceBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T8);
            this.Controls.Add(this.T7);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T4);
            this.Controls.Add(this.T5);
            this.Controls.Add(this.T6);
            this.Name = "Form2";
            this.Text = "Target Framework";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ThreeWayTarget T6;
        private ThreeWayTarget T5;
        private ThreeWayTarget T4;
        private ThreeWayTarget T3;
        private ThreeWayTarget T7;
        private ThreeWayTarget T8;
        private ThreeWayTarget T2;
        private ThreeWayTarget T1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addTargetArrayToSequenceBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox serialPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearSequence;
        private System.Windows.Forms.Button runSequence;
        private System.Windows.Forms.Button addDelayToSequenceBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox delay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveSeq;
        private System.Windows.Forms.Button loadSeq;
    }
}