namespace GYM_WindowsForms
{
    partial class DashBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonadd_member = new System.Windows.Forms.Button();
            this.buttonadd_trainer = new System.Windows.Forms.Button();
            this.buttonadd_equipment = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DashBoard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonadd_member
            // 
            this.buttonadd_member.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd_member.Location = new System.Drawing.Point(63, 129);
            this.buttonadd_member.Name = "buttonadd_member";
            this.buttonadd_member.Size = new System.Drawing.Size(253, 53);
            this.buttonadd_member.TabIndex = 1;
            this.buttonadd_member.Text = "Add  Member";
            this.buttonadd_member.UseVisualStyleBackColor = true;
            this.buttonadd_member.Click += new System.EventHandler(this.buttonadd_member_Click);
            // 
            // buttonadd_trainer
            // 
            this.buttonadd_trainer.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd_trainer.Location = new System.Drawing.Point(63, 241);
            this.buttonadd_trainer.Name = "buttonadd_trainer";
            this.buttonadd_trainer.Size = new System.Drawing.Size(253, 50);
            this.buttonadd_trainer.TabIndex = 2;
            this.buttonadd_trainer.Text = "Add Trainer";
            this.buttonadd_trainer.UseVisualStyleBackColor = true;
            this.buttonadd_trainer.Click += new System.EventHandler(this.buttonadd_staff_member_Click);
            // 
            // buttonadd_equipment
            // 
            this.buttonadd_equipment.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd_equipment.Location = new System.Drawing.Point(63, 354);
            this.buttonadd_equipment.Name = "buttonadd_equipment";
            this.buttonadd_equipment.Size = new System.Drawing.Size(291, 53);
            this.buttonadd_equipment.TabIndex = 3;
            this.buttonadd_equipment.Text = "Add  Equipment";
            this.buttonadd_equipment.UseVisualStyleBackColor = true;
            this.buttonadd_equipment.Click += new System.EventHandler(this.buttonadd_equipment_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(63, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete  Member";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(63, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(571, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 782);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonadd_equipment);
            this.Controls.Add(this.buttonadd_trainer);
            this.Controls.Add(this.buttonadd_member);
            this.Controls.Add(this.label1);
            this.Name = "DashBoard";
            this.Text = "DashBoard_Form";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonadd_member;
        private System.Windows.Forms.Button buttonadd_trainer;
        private System.Windows.Forms.Button buttonadd_equipment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}