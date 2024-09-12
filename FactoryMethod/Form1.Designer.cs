namespace FactoryMethod
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
            this.btnGetDB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSQL = new System.Windows.Forms.RadioButton();
            this.radOle = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetDB
            // 
            this.btnGetDB.Location = new System.Drawing.Point(323, 190);
            this.btnGetDB.Name = "btnGetDB";
            this.btnGetDB.Size = new System.Drawing.Size(185, 56);
            this.btnGetDB.TabIndex = 0;
            this.btnGetDB.Text = "Get Database";
            this.btnGetDB.UseVisualStyleBackColor = true;
            this.btnGetDB.Click += new System.EventHandler(this.btnGetDB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOle);
            this.groupBox1.Controls.Add(this.radSQL);
            this.groupBox1.Location = new System.Drawing.Point(44, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radSQL
            // 
            this.radSQL.AutoSize = true;
            this.radSQL.Location = new System.Drawing.Point(33, 62);
            this.radSQL.Name = "radSQL";
            this.radSQL.Size = new System.Drawing.Size(140, 24);
            this.radSQL.TabIndex = 0;
            this.radSQL.TabStop = true;
            this.radSQL.Text = "SQL Database";
            this.radSQL.UseVisualStyleBackColor = true;
            // 
            // radOle
            // 
            this.radOle.AutoSize = true;
            this.radOle.Location = new System.Drawing.Point(33, 117);
            this.radOle.Name = "radOle";
            this.radOle.Size = new System.Drawing.Size(132, 24);
            this.radOle.TabIndex = 1;
            this.radOle.TabStop = true;
            this.radOle.Text = "Ole Database";
            this.radOle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOle;
        private System.Windows.Forms.RadioButton radSQL;
    }
}

