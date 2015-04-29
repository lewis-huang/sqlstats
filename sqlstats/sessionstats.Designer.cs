namespace sqlstats
{
    partial class sessionstats
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
            this.txtinstance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvsessionstats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsessionstats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sql server instance";
            // 
            // txtinstance
            // 
            this.txtinstance.Location = new System.Drawing.Point(124, 10);
            this.txtinstance.Name = "txtinstance";
            this.txtinstance.Size = new System.Drawing.Size(100, 20);
            this.txtinstance.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvsessionstats
            // 
            this.dgvsessionstats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsessionstats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsessionstats.Location = new System.Drawing.Point(1, 76);
            this.dgvsessionstats.Name = "dgvsessionstats";
            this.dgvsessionstats.Size = new System.Drawing.Size(860, 295);
            this.dgvsessionstats.TabIndex = 3;
            // 
            // sessionstats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 372);
            this.Controls.Add(this.dgvsessionstats);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtinstance);
            this.Controls.Add(this.label1);
            this.Name = "sessionstats";
            this.Text = "sessionstats";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsessionstats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinstance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvsessionstats;
    }
}