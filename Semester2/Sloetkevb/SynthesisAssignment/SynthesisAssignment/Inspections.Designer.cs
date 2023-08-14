
namespace SynthesisAssignment
{
    partial class Inspections
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
            this.btnCreateInspection = new System.Windows.Forms.Button();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.lblRentDocID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnDamaged = new System.Windows.Forms.RadioButton();
            this.rbtnNothingDamaged = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDamage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateInspection
            // 
            this.btnCreateInspection.Location = new System.Drawing.Point(67, 373);
            this.btnCreateInspection.Name = "btnCreateInspection";
            this.btnCreateInspection.Size = new System.Drawing.Size(132, 45);
            this.btnCreateInspection.TabIndex = 0;
            this.btnCreateInspection.Text = "Create Inspection";
            this.btnCreateInspection.UseVisualStyleBackColor = true;
            this.btnCreateInspection.Click += new System.EventHandler(this.btnCreateInspection_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbNote.Location = new System.Drawing.Point(67, 116);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(377, 185);
            this.rtbNote.TabIndex = 1;
            this.rtbNote.Text = "";
            // 
            // lblRentDocID
            // 
            this.lblRentDocID.AutoSize = true;
            this.lblRentDocID.Location = new System.Drawing.Point(67, 30);
            this.lblRentDocID.Name = "lblRentDocID";
            this.lblRentDocID.Size = new System.Drawing.Size(50, 20);
            this.lblRentDocID.TabIndex = 2;
            this.lblRentDocID.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note:";
            // 
            // rbtnDamaged
            // 
            this.rbtnDamaged.AutoSize = true;
            this.rbtnDamaged.Location = new System.Drawing.Point(482, 149);
            this.rbtnDamaged.Name = "rbtnDamaged";
            this.rbtnDamaged.Size = new System.Drawing.Size(167, 24);
            this.rbtnDamaged.TabIndex = 4;
            this.rbtnDamaged.TabStop = true;
            this.rbtnDamaged.Text = "Damaged item/boat";
            this.rbtnDamaged.UseVisualStyleBackColor = true;
            // 
            // rbtnNothingDamaged
            // 
            this.rbtnNothingDamaged.AutoSize = true;
            this.rbtnNothingDamaged.Location = new System.Drawing.Point(482, 277);
            this.rbtnNothingDamaged.Name = "rbtnNothingDamaged";
            this.rbtnNothingDamaged.Size = new System.Drawing.Size(154, 24);
            this.rbtnNothingDamaged.TabIndex = 5;
            this.rbtnNothingDamaged.TabStop = true;
            this.rbtnNothingDamaged.Text = "Nothing Damaged";
            this.rbtnNothingDamaged.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Write the cost of the damage:";
            // 
            // tbDamage
            // 
            this.tbDamage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDamage.Location = new System.Drawing.Point(482, 212);
            this.tbDamage.Name = "tbDamage";
            this.tbDamage.Size = new System.Drawing.Size(206, 30);
            this.tbDamage.TabIndex = 7;
            // 
            // Inspections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.tbDamage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnNothingDamaged);
            this.Controls.Add(this.rbtnDamaged);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRentDocID);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.btnCreateInspection);
            this.Name = "Inspections";
            this.Text = "Inspection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateInspection;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblRentDocID;
        private System.Windows.Forms.RadioButton rbtnDamaged;
        private System.Windows.Forms.RadioButton rbtnNothingDamaged;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDamage;
    }
}