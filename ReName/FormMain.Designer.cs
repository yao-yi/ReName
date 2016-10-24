namespace ReName
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnChose = new System.Windows.Forms.Button();
            this.tbOldName = new System.Windows.Forms.TextBox();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.linkLabHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnChose
            // 
            this.btnChose.Location = new System.Drawing.Point(12, 13);
            this.btnChose.Name = "btnChose";
            this.btnChose.Size = new System.Drawing.Size(75, 23);
            this.btnChose.TabIndex = 0;
            this.btnChose.TabStop = false;
            this.btnChose.Text = "Choose";
            this.btnChose.UseVisualStyleBackColor = true;
            this.btnChose.Click += new System.EventHandler(this.btnChose_Click);
            // 
            // tbOldName
            // 
            this.tbOldName.Location = new System.Drawing.Point(12, 42);
            this.tbOldName.Name = "tbOldName";
            this.tbOldName.ReadOnly = true;
            this.tbOldName.Size = new System.Drawing.Size(197, 20);
            this.tbOldName.TabIndex = 1;
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(12, 68);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(197, 20);
            this.tbNewName.TabIndex = 2;
            this.tbNewName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNewName_KeyPress);
            // 
            // btnRename
            // 
            this.btnRename.Enabled = false;
            this.btnRename.Location = new System.Drawing.Point(12, 94);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 3;
            this.btnRename.TabStop = false;
            this.btnRename.Text = "ReName";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "|*.sln";
            // 
            // linkLabHelp
            // 
            this.linkLabHelp.AutoSize = true;
            this.linkLabHelp.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabHelp.Location = new System.Drawing.Point(179, 99);
            this.linkLabHelp.Name = "linkLabHelp";
            this.linkLabHelp.Size = new System.Drawing.Size(29, 13);
            this.linkLabHelp.TabIndex = 4;
            this.linkLabHelp.Text = "Help";
            this.linkLabHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabHelp_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 133);
            this.Controls.Add(this.linkLabHelp);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.tbOldName);
            this.Controls.Add(this.btnChose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChose;
        private System.Windows.Forms.TextBox tbOldName;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.LinkLabel linkLabHelp;
    }
}

