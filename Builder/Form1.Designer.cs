namespace Builder
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
            this.radOleDb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetDB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radSQL
            // 
            this.radSQL.AutoSize = true;
            this.radSQL.Checked = true;
            this.radSQL.Location = new System.Drawing.Point(73, 58);
            this.radSQL.Name = "radSQL";
            this.radSQL.Size = new System.Drawing.Size(116, 24);
            this.radSQL.TabIndex = 0;
            this.radSQL.TabStop = true;
            this.radSQL.Text = "SQL Server";
            this.radSQL.UseVisualStyleBackColor = true;
            // 
            // radOleDb
            // 
            this.radOleDb.AutoSize = true;
            this.radOleDb.Location = new System.Drawing.Point(73, 110);
            this.radOleDb.Name = "radOleDb";
            this.radOleDb.Size = new System.Drawing.Size(79, 24);
            this.radOleDb.TabIndex = 1;
            this.radOleDb.Text = "OleDb";
            this.radOleDb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSQL);
            this.groupBox1.Controls.Add(this.radOleDb);
            this.groupBox1.Location = new System.Drawing.Point(43, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnGetDB
            // 
            this.btnGetDB.Location = new System.Drawing.Point(423, 124);
            this.btnGetDB.Name = "btnGetDB";
            this.btnGetDB.Size = new System.Drawing.Size(170, 51);
            this.btnGetDB.TabIndex = 3;
            this.btnGetDB.Text = "GetDatabase";
            this.btnGetDB.UseVisualStyleBackColor = true;
            this.btnGetDB.Click += new System.EventHandler(this.btnGetDB_Click);
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
        private System.Windows.Forms.RadioButton radOleDb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetDB;
    }
}

