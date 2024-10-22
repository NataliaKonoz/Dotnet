namespace task_3
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();

            // tableLayoutPanel
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtName, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.lblPhone, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtPhone, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.lblEmail, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txtEmail, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.lblBirthDate, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.dtpBirthDate, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.btnSubmit, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.btnReset, 2, 4);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.Size = new System.Drawing.Size(400, 200);
            this.tableLayoutPanel.TabIndex = 0;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Text = "Ім'я:";
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;

            // txtName
            this.txtName.Location = new System.Drawing.Point(3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 1;

            // lblPhone 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Text = "Телефон:";
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(3, 33);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 22);
            this.txtPhone.TabIndex = 3;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Text = "Поштова скринька:";
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;

            // txtEmail 
            this.txtEmail.Location = new System.Drawing.Point(3, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmail.TabIndex = 5;

            // lblBirthDate
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Text = "Дата народження:";
            this.lblBirthDate.Anchor = System.Windows.Forms.AnchorStyles.Right;

            // dtpBirthDate
            this.dtpBirthDate.Location = new System.Drawing.Point(3, 93);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(150, 22);
            this.dtpBirthDate.TabIndex = 7;

            // btnSubmit 
            this.btnSubmit.Location = new System.Drawing.Point(3, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 30);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Відіслати";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // btnReset 
            this.btnReset.Location = new System.Drawing.Point(3, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 30);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Скинути";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(420, 250);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Form1";
            this.Text = "Реєстраційна форма";
            this.ResumeLayout(false);
        }
    }
}
