namespace WinFormsApp1
{
    partial class RegisterForm
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToLoginButton = new System.Windows.Forms.Label();
            this.dataRegField = new System.Windows.Forms.MaskedTextBox();
            this.numberRegField = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passRegField = new System.Windows.Forms.TextBox();
            this.emailRegField = new System.Windows.Forms.TextBox();
            this.addresRegField = new System.Windows.Forms.TextBox();
            this.surnameRegField = new System.Windows.Forms.TextBox();
            this.nameRegField = new System.Windows.Forms.TextBox();
            this.loginRegField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Furore", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(200, 660);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(142, 44);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Создать";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.ToLoginButton);
            this.panel1.Controls.Add(this.dataRegField);
            this.panel1.Controls.Add(this.numberRegField);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.passRegField);
            this.panel1.Controls.Add(this.emailRegField);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.addresRegField);
            this.panel1.Controls.Add(this.surnameRegField);
            this.panel1.Controls.Add(this.nameRegField);
            this.panel1.Controls.Add(this.loginRegField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 752);
            this.panel1.TabIndex = 1;
            // 
            // ToLoginButton
            // 
            this.ToLoginButton.AutoSize = true;
            this.ToLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToLoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToLoginButton.ForeColor = System.Drawing.Color.White;
            this.ToLoginButton.Location = new System.Drawing.Point(180, 719);
            this.ToLoginButton.Name = "ToLoginButton";
            this.ToLoginButton.Size = new System.Drawing.Size(183, 21);
            this.ToLoginButton.TabIndex = 7;
            this.ToLoginButton.Text = "Уже зарегистрированы?";
            this.ToLoginButton.Click += new System.EventHandler(this.ToLoginButton_Click);
            // 
            // dataRegField
            // 
            this.dataRegField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataRegField.Location = new System.Drawing.Point(189, 509);
            this.dataRegField.Mask = "00/00/0000";
            this.dataRegField.MaximumSize = new System.Drawing.Size(157, 40);
            this.dataRegField.MinimumSize = new System.Drawing.Size(157, 37);
            this.dataRegField.Name = "dataRegField";
            this.dataRegField.Size = new System.Drawing.Size(157, 40);
            this.dataRegField.TabIndex = 6;
            this.dataRegField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataRegField.ValidatingType = typeof(System.DateTime);
            // 
            // numberRegField
            // 
            this.numberRegField.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberRegField.Location = new System.Drawing.Point(189, 441);
            this.numberRegField.Mask = "+7 (999) 000-00-00";
            this.numberRegField.MaximumSize = new System.Drawing.Size(297, 37);
            this.numberRegField.MinimumSize = new System.Drawing.Size(0, 37);
            this.numberRegField.Name = "numberRegField";
            this.numberRegField.Size = new System.Drawing.Size(241, 37);
            this.numberRegField.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Furore", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 54);
            this.label8.TabIndex = 4;
            this.label8.Text = "Дата\r\nрождения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Furore", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 584);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Furore", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Furore", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Furore", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Furore", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Furore", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Furore", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // passRegField
            // 
            this.passRegField.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passRegField.Location = new System.Drawing.Point(189, 572);
            this.passRegField.MaxLength = 15;
            this.passRegField.Multiline = true;
            this.passRegField.Name = "passRegField";
            this.passRegField.Size = new System.Drawing.Size(320, 37);
            this.passRegField.TabIndex = 2;
            // 
            // emailRegField
            // 
            this.emailRegField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailRegField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailRegField.Location = new System.Drawing.Point(189, 317);
            this.emailRegField.MaximumSize = new System.Drawing.Size(320, 37);
            this.emailRegField.MaxLength = 30;
            this.emailRegField.MinimumSize = new System.Drawing.Size(320, 37);
            this.emailRegField.Name = "emailRegField";
            this.emailRegField.Size = new System.Drawing.Size(320, 37);
            this.emailRegField.TabIndex = 2;
            // 
            // addresRegField
            // 
            this.addresRegField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addresRegField.Location = new System.Drawing.Point(189, 377);
            this.addresRegField.MaxLength = 40;
            this.addresRegField.Multiline = true;
            this.addresRegField.Name = "addresRegField";
            this.addresRegField.Size = new System.Drawing.Size(320, 37);
            this.addresRegField.TabIndex = 2;
            // 
            // surnameRegField
            // 
            this.surnameRegField.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameRegField.Location = new System.Drawing.Point(189, 253);
            this.surnameRegField.MaxLength = 20;
            this.surnameRegField.Multiline = true;
            this.surnameRegField.Name = "surnameRegField";
            this.surnameRegField.Size = new System.Drawing.Size(320, 37);
            this.surnameRegField.TabIndex = 2;
            // 
            // nameRegField
            // 
            this.nameRegField.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameRegField.Location = new System.Drawing.Point(189, 196);
            this.nameRegField.MaxLength = 20;
            this.nameRegField.Multiline = true;
            this.nameRegField.Name = "nameRegField";
            this.nameRegField.Size = new System.Drawing.Size(320, 37);
            this.nameRegField.TabIndex = 2;
            // 
            // loginRegField
            // 
            this.loginRegField.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginRegField.Location = new System.Drawing.Point(189, 138);
            this.loginRegField.MaxLength = 10;
            this.loginRegField.Multiline = true;
            this.loginRegField.Name = "loginRegField";
            this.loginRegField.Size = new System.Drawing.Size(320, 37);
            this.loginRegField.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(533, 112);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(505, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 18);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Furore", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 751);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonRegister;
        private Panel panel1;
        private TextBox loginRegField;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox nameRegField;
        private Label label4;
        private TextBox surnameRegField;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox emailRegField;
        private TextBox addresRegField;
        private Label label8;
        private Label label9;
        private TextBox passRegField;
        private MaskedTextBox numberRegField;
        private MaskedTextBox dataRegField;
        private Label ToLoginButton;
    }
}