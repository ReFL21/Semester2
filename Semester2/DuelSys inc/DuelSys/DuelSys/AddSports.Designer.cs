
namespace DuelSys
{
    partial class AddSports
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
            this.btnAddSport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.tbSWinningP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSport
            // 
            this.btnAddSport.Location = new System.Drawing.Point(111, 315);
            this.btnAddSport.Name = "btnAddSport";
            this.btnAddSport.Size = new System.Drawing.Size(132, 44);
            this.btnAddSport.TabIndex = 0;
            this.btnAddSport.Text = "Add";
            this.btnAddSport.UseVisualStyleBackColor = true;
            this.btnAddSport.Click += new System.EventHandler(this.btnAddSport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(314, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbSName
            // 
            this.tbSName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSName.Location = new System.Drawing.Point(246, 103);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(234, 30);
            this.tbSName.TabIndex = 2;
            // 
            // tbSWinningP
            // 
            this.tbSWinningP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSWinningP.Location = new System.Drawing.Point(246, 192);
            this.tbSWinningP.Name = "tbSWinningP";
            this.tbSWinningP.Size = new System.Drawing.Size(234, 30);
            this.tbSWinningP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(111, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Winning Points:";
            // 
            // AddSports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSWinningP);
            this.Controls.Add(this.tbSName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddSport);
            this.Name = "AddSports";
            this.Text = "AddSports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.TextBox tbSWinningP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}