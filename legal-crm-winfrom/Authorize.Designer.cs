namespace legal_crm_winfrom
{
    partial class Authorize
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
            this.authBtn = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPswd = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.pswdTB = new System.Windows.Forms.TextBox();
            this.imgLock = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // authBtn
            // 
            this.authBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authBtn.Location = new System.Drawing.Point(106, 169);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(108, 35);
            this.authBtn.TabIndex = 0;
            this.authBtn.Text = "Войти";
            this.authBtn.UseVisualStyleBackColor = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogin.Location = new System.Drawing.Point(69, 28);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(64, 24);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // labelPswd
            // 
            this.labelPswd.AutoSize = true;
            this.labelPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPswd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPswd.Location = new System.Drawing.Point(69, 96);
            this.labelPswd.Name = "labelPswd";
            this.labelPswd.Size = new System.Drawing.Size(76, 24);
            this.labelPswd.TabIndex = 2;
            this.labelPswd.Text = "Пароль";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(73, 55);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(211, 20);
            this.loginTB.TabIndex = 3;
            // 
            // pswdTB
            // 
            this.pswdTB.Location = new System.Drawing.Point(73, 123);
            this.pswdTB.Name = "pswdTB";
            this.pswdTB.Size = new System.Drawing.Size(211, 20);
            this.pswdTB.TabIndex = 4;
            // 
            // imgLock
            // 
            this.imgLock.Image = global::legal_crm_winfrom.Properties.Resources.lock_32;
            this.imgLock.InitialImage = global::legal_crm_winfrom.Properties.Resources._lock;
            this.imgLock.Location = new System.Drawing.Point(31, 108);
            this.imgLock.Name = "imgLock";
            this.imgLock.Size = new System.Drawing.Size(32, 35);
            this.imgLock.TabIndex = 6;
            this.imgLock.TabStop = false;
            // 
            // imgUser
            // 
            this.imgUser.Image = global::legal_crm_winfrom.Properties.Resources.user_shape_32;
            this.imgUser.InitialImage = global::legal_crm_winfrom.Properties.Resources._lock;
            this.imgUser.Location = new System.Drawing.Point(31, 40);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(32, 35);
            this.imgUser.TabIndex = 7;
            this.imgUser.TabStop = false;
            // 
            // Authorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(317, 227);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.imgLock);
            this.Controls.Add(this.pswdTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.labelPswd);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.authBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Authorize";
            this.Text = "Аутентификация";
            this.Load += new System.EventHandler(this.Authorize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPswd;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox pswdTB;
        private System.Windows.Forms.PictureBox imgLock;
        private System.Windows.Forms.PictureBox imgUser;
    }
}

