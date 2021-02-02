
namespace FilterDialog
{
    public partial class FilterDialog
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTelNummer = new System.Windows.Forms.TextBox();
            this.lblTelNummer = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Location = new System.Drawing.Point(121, 305);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(211, 51);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Фільтрувати";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(105, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 30);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblName.Location = new System.Drawing.Point(100, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Повне ім\'я";
            // 
            // txtTelNummer
            // 
            this.txtTelNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelNummer.Location = new System.Drawing.Point(105, 133);
            this.txtTelNummer.Name = "txtTelNummer";
            this.txtTelNummer.Size = new System.Drawing.Size(246, 30);
            this.txtTelNummer.TabIndex = 1;
            // 
            // lblTelNummer
            // 
            this.lblTelNummer.AutoSize = true;
            this.lblTelNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTelNummer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTelNummer.Location = new System.Drawing.Point(100, 105);
            this.lblTelNummer.Name = "lblTelNummer";
            this.lblTelNummer.Size = new System.Drawing.Size(176, 25);
            this.lblTelNummer.TabIndex = 2;
            this.lblTelNummer.Text = "Номер телефону";
            this.lblTelNummer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblGender.Location = new System.Drawing.Point(100, 201);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 25);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Стать";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genderCB
            // 
            this.genderCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча"});
            this.genderCB.Location = new System.Drawing.Point(105, 230);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(246, 33);
            this.genderCB.TabIndex = 3;
            // 
            // FilterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblTelNummer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtTelNummer);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnFilter);
            this.Name = "FilterDialog";
            this.Size = new System.Drawing.Size(450, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTelNummer;
        private System.Windows.Forms.Label lblTelNummer;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox genderCB;
    }
}
