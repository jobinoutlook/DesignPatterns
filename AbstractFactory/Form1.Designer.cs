namespace AbstractFactory
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
            this.radSQL = new System.Windows.Forms.RadioButton();
            this.radOle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetDB = new System.Windows.Forms.Button();
            this.radOrcl = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radSQL
            // 
            this.radSQL.AutoSize = true;
            this.radSQL.Location = new System.Drawing.Point(32, 63);
            this.radSQL.Name = "radSQL";
            this.radSQL.Size = new System.Drawing.Size(151, 24);
            this.radSQL.TabIndex = 0;
            this.radSQL.TabStop = true;
            this.radSQL.Text = "SQL Connection";
            this.radSQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radSQL.UseVisualStyleBackColor = true;
            // 
            // radOle
            // 
            this.radOle.AutoSize = true;
            this.radOle.Location = new System.Drawing.Point(32, 113);
            this.radOle.Name = "radOle";
            this.radOle.Size = new System.Drawing.Size(166, 24);
            this.radOle.TabIndex = 1;
            this.radOle.TabStop = true;
            this.radOle.Text = "OleDB Connection";
            this.radOle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOrcl);
            this.groupBox1.Controls.Add(this.radSQL);
            this.groupBox1.Controls.Add(this.radOle);
            this.groupBox1.Location = new System.Drawing.Point(66, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnGetDB
            // 
            this.btnGetDB.Location = new System.Drawing.Point(399, 147);
            this.btnGetDB.Name = "btnGetDB";
            this.btnGetDB.Size = new System.Drawing.Size(138, 50);
            this.btnGetDB.TabIndex = 3;
            this.btnGetDB.Text = "Get DB";
            this.btnGetDB.UseVisualStyleBackColor = true;
            this.btnGetDB.Click += new System.EventHandler(this.btnGetDB_Click);
            // 
            // radOrcl
            // 
            this.radOrcl.AutoSize = true;
            this.radOrcl.Location = new System.Drawing.Point(32, 167);
            this.radOrcl.Name = "radOrcl";
            this.radOrcl.Size = new System.Drawing.Size(165, 24);
            this.radOrcl.TabIndex = 2;
            this.radOrcl.TabStop = true;
            this.radOrcl.Text = "Oracle Connection";
            this.radOrcl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetDB);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radSQL;
        private System.Windows.Forms.RadioButton radOle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetDB;
        private System.Windows.Forms.RadioButton radOrcl;
    }
}

