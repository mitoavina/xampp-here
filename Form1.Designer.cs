namespace Xamp_Here
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
            this.buttonDocRoot = new System.Windows.Forms.Button();
            this.textBoxDocRoot = new System.Windows.Forms.TextBox();
            this.groupBoxDocRoot = new System.Windows.Forms.GroupBox();
            this.groupBoxDefault = new System.Windows.Forms.GroupBox();
            this.textBoxDefault = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBrowseDefault = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDocRoot.SuspendLayout();
            this.groupBoxDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDocRoot
            // 
            this.buttonDocRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDocRoot.Location = new System.Drawing.Point(251, 17);
            this.buttonDocRoot.Name = "buttonDocRoot";
            this.buttonDocRoot.Size = new System.Drawing.Size(75, 23);
            this.buttonDocRoot.TabIndex = 0;
            this.buttonDocRoot.Text = "Change";
            this.buttonDocRoot.UseVisualStyleBackColor = true;
            this.buttonDocRoot.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDocRoot
            // 
            this.textBoxDocRoot.Enabled = false;
            this.textBoxDocRoot.Location = new System.Drawing.Point(6, 19);
            this.textBoxDocRoot.Name = "textBoxDocRoot";
            this.textBoxDocRoot.Size = new System.Drawing.Size(239, 20);
            this.textBoxDocRoot.TabIndex = 1;
            this.textBoxDocRoot.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxDocRoot
            // 
            this.groupBoxDocRoot.Controls.Add(this.textBoxDocRoot);
            this.groupBoxDocRoot.Controls.Add(this.buttonDocRoot);
            this.groupBoxDocRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDocRoot.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDocRoot.Name = "groupBoxDocRoot";
            this.groupBoxDocRoot.Size = new System.Drawing.Size(332, 52);
            this.groupBoxDocRoot.TabIndex = 3;
            this.groupBoxDocRoot.TabStop = false;
            this.groupBoxDocRoot.Text = "Current Document Root";
            this.groupBoxDocRoot.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxDefault
            // 
            this.groupBoxDefault.Controls.Add(this.buttonBrowseDefault);
            this.groupBoxDefault.Controls.Add(this.textBoxDefault);
            this.groupBoxDefault.Controls.Add(this.buttonReset);
            this.groupBoxDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDefault.Location = new System.Drawing.Point(12, 70);
            this.groupBoxDefault.Name = "groupBoxDefault";
            this.groupBoxDefault.Size = new System.Drawing.Size(332, 52);
            this.groupBoxDefault.TabIndex = 4;
            this.groupBoxDefault.TabStop = false;
            this.groupBoxDefault.Text = "Default";
            // 
            // textBoxDefault
            // 
            this.textBoxDefault.Enabled = false;
            this.textBoxDefault.Location = new System.Drawing.Point(6, 19);
            this.textBoxDefault.Name = "textBoxDefault";
            this.textBoxDefault.Size = new System.Drawing.Size(207, 20);
            this.textBoxDefault.TabIndex = 1;
            this.textBoxDefault.TextChanged += new System.EventHandler(this.textBoxDefault_TextChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(251, 17);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseDefault
            // 
            this.buttonBrowseDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseDefault.Location = new System.Drawing.Point(219, 17);
            this.buttonBrowseDefault.Name = "buttonBrowseDefault";
            this.buttonBrowseDefault.Size = new System.Drawing.Size(26, 23);
            this.buttonBrowseDefault.TabIndex = 2;
            this.buttonBrowseDefault.Text = "...";
            this.buttonBrowseDefault.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "©️ XAMPP Here by mitoavina.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 152);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDefault);
            this.Controls.Add(this.groupBoxDocRoot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XAMPP Here";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDocRoot.ResumeLayout(false);
            this.groupBoxDocRoot.PerformLayout();
            this.groupBoxDefault.ResumeLayout(false);
            this.groupBoxDefault.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDocRoot;
        private System.Windows.Forms.TextBox textBoxDocRoot;
        private System.Windows.Forms.GroupBox groupBoxDocRoot;
        private System.Windows.Forms.GroupBox groupBoxDefault;
        private System.Windows.Forms.Button buttonBrowseDefault;
        private System.Windows.Forms.TextBox textBoxDefault;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
    }
}

