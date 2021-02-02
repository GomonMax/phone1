
namespace TelephoneBook
{
    public partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataPerson = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxTel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxState = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerson)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPerson
            // 
            this.dataPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.colTelNummer,
            this.colGender});
            this.dataPerson.Location = new System.Drawing.Point(10, 52);
            this.dataPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPerson.Name = "dataPerson";
            this.dataPerson.RowHeadersWidth = 51;
            this.dataPerson.RowTemplate.Height = 29;
            this.dataPerson.Size = new System.Drawing.Size(591, 211);
            this.dataPerson.TabIndex = 0;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.Width = 50;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Ім\'я";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            // 
            // colTelNummer
            // 
            this.colTelNummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTelNummer.HeaderText = "Телефонний номер";
            this.colTelNummer.MinimumWidth = 6;
            this.colTelNummer.Name = "colTelNummer";
            // 
            // colGender
            // 
            this.colGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGender.HeaderText = "Стать";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(10, 265);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(118, 33);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Всього: 0";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(10, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 22);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Користувачі:";
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuFilter});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(697, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "Головне меню";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuExit});
            this.toolStripMenuFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuFile.Text = "Файл";
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuExit.Text = "Вийти";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // toolStripMenuFilter
            // 
            this.toolStripMenuFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxName,
            this.toolStripSeparator1,
            this.toolStripTextBoxTel,
            this.toolStripSeparator2,
            this.toolStripComboBoxState,
            this.toolStripSeparator3,
            this.toolStripMenuButton});
            this.toolStripMenuFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuFilter.Name = "toolStripMenuFilter";
            this.toolStripMenuFilter.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuFilter.Text = "Фільтр";
            // 
            // toolStripTextBoxName
            // 
            this.toolStripTextBoxName.AutoSize = false;
            this.toolStripTextBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripTextBoxName.Name = "toolStripTextBoxName";
            this.toolStripTextBoxName.Size = new System.Drawing.Size(165, 34);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // toolStripTextBoxTel
            // 
            this.toolStripTextBoxTel.AutoSize = false;
            this.toolStripTextBoxTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripTextBoxTel.Name = "toolStripTextBoxTel";
            this.toolStripTextBoxTel.Size = new System.Drawing.Size(165, 34);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // toolStripComboBoxState
            // 
            this.toolStripComboBoxState.AutoSize = false;
            this.toolStripComboBoxState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripComboBoxState.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча"});
            this.toolStripComboBoxState.Name = "toolStripComboBoxState";
            this.toolStripComboBoxState.Size = new System.Drawing.Size(165, 36);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
            // 
            // toolStripMenuButton
            // 
            this.toolStripMenuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuButton.Name = "toolStripMenuButton";
            this.toolStripMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuButton.Size = new System.Drawing.Size(225, 26);
            this.toolStripMenuButton.Text = "Фільтрувати";
            this.toolStripMenuButton.Click += new System.EventHandler(this.toolStripMenuButton_Click);
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Location = new System.Drawing.Point(468, 26);
            this.comboBoxCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(133, 23);
            this.comboBoxCount.TabIndex = 5;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Location = new System.Drawing.Point(35, 304);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxButtons.Size = new System.Drawing.Size(545, 51);
            this.groupBoxButtons.TabIndex = 7;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Enter += new System.EventHandler(this.groupBoxButtons_Enter);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(586, 321);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(18, 22);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(10, 321);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(18, 22);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(613, 365);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.comboBoxCount);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dataPerson);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Телефонний довідник";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPerson)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFilter;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxTel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.ComboBox comboBoxCount;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
    }
}