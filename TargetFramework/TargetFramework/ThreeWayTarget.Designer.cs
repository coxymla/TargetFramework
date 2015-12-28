namespace TargetFramework
{
    partial class ThreeWayTarget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shoot = new System.Windows.Forms.RadioButton();
            this.edgeOn = new System.Windows.Forms.RadioButton();
            this.noShoot = new System.Windows.Forms.RadioButton();
            this.t1_s_btn = new System.Windows.Forms.Button();
            this.t1_ns_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.t1_s_btn);
            this.groupBox1.Controls.Add(this.t1_ns_btn);
            this.groupBox1.Controls.Add(this.noShoot);
            this.groupBox1.Controls.Add(this.edgeOn);
            this.groupBox1.Controls.Add(this.shoot);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // shoot
            // 
            this.shoot.AutoSize = true;
            this.shoot.Location = new System.Drawing.Point(6, 71);
            this.shoot.Name = "shoot";
            this.shoot.Size = new System.Drawing.Size(53, 17);
            this.shoot.TabIndex = 0;
            this.shoot.Text = "Shoot";
            this.shoot.UseVisualStyleBackColor = true;
            // 
            // edgeOn
            // 
            this.edgeOn.AutoSize = true;
            this.edgeOn.Checked = true;
            this.edgeOn.Location = new System.Drawing.Point(65, 71);
            this.edgeOn.Name = "edgeOn";
            this.edgeOn.Size = new System.Drawing.Size(67, 17);
            this.edgeOn.TabIndex = 1;
            this.edgeOn.TabStop = true;
            this.edgeOn.Text = "Edge-On";
            this.edgeOn.UseVisualStyleBackColor = true;
            // 
            // noShoot
            // 
            this.noShoot.AutoSize = true;
            this.noShoot.Location = new System.Drawing.Point(138, 71);
            this.noShoot.Name = "noShoot";
            this.noShoot.Size = new System.Drawing.Size(70, 17);
            this.noShoot.TabIndex = 2;
            this.noShoot.Text = "No Shoot";
            this.noShoot.UseVisualStyleBackColor = true;
            // 
            // t1_s_btn
            // 
            this.t1_s_btn.Enabled = false;
            this.t1_s_btn.Location = new System.Drawing.Point(6, 19);
            this.t1_s_btn.Name = "t1_s_btn";
            this.t1_s_btn.Size = new System.Drawing.Size(53, 46);
            this.t1_s_btn.TabIndex = 3;
            this.t1_s_btn.Text = "S";
            this.t1_s_btn.UseVisualStyleBackColor = true;
            // 
            // t1_ns_btn
            // 
            this.t1_ns_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.t1_ns_btn.Enabled = false;
            this.t1_ns_btn.Location = new System.Drawing.Point(138, 19);
            this.t1_ns_btn.Name = "t1_ns_btn";
            this.t1_ns_btn.Size = new System.Drawing.Size(46, 46);
            this.t1_ns_btn.TabIndex = 4;
            this.t1_ns_btn.Text = "NS";
            this.t1_ns_btn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(95, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 46);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ThreeWayTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ThreeWayTarget";
            this.Size = new System.Drawing.Size(221, 107);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton noShoot;
        private System.Windows.Forms.RadioButton edgeOn;
        private System.Windows.Forms.RadioButton shoot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button t1_s_btn;
        private System.Windows.Forms.Button t1_ns_btn;
    }
}
