namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_direrctor = new System.Windows.Forms.Button();
            this.button_coach = new System.Windows.Forms.Button();
            this.button_manager = new System.Windows.Forms.Button();
            this.button_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_direrctor
            // 
            this.button_direrctor.Location = new System.Drawing.Point(32, 20);
            this.button_direrctor.Name = "button_direrctor";
            this.button_direrctor.Size = new System.Drawing.Size(102, 40);
            this.button_direrctor.TabIndex = 0;
            this.button_direrctor.Text = "Дыректор ♂";
            this.button_direrctor.UseVisualStyleBackColor = true;
            this.button_direrctor.Click += new System.EventHandler(this.button_direrctor_Click);
            // 
            // button_coach
            // 
            this.button_coach.Location = new System.Drawing.Point(32, 66);
            this.button_coach.Name = "button_coach";
            this.button_coach.Size = new System.Drawing.Size(102, 40);
            this.button_coach.TabIndex = 1;
            this.button_coach.Text = "Тренер";
            this.button_coach.UseVisualStyleBackColor = true;
            this.button_coach.Click += new System.EventHandler(this.button_coach_Click);
            // 
            // button_manager
            // 
            this.button_manager.Location = new System.Drawing.Point(32, 112);
            this.button_manager.Name = "button_manager";
            this.button_manager.Size = new System.Drawing.Size(102, 40);
            this.button_manager.TabIndex = 2;
            this.button_manager.Text = "Менегер";
            this.button_manager.UseVisualStyleBackColor = true;
            this.button_manager.Click += new System.EventHandler(this.button_manager_Click);
            // 
            // button_user
            // 
            this.button_user.Location = new System.Drawing.Point(32, 158);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(102, 40);
            this.button_user.TabIndex = 3;
            this.button_user.Text = "Гачибасс♂";
            this.button_user.UseVisualStyleBackColor = true;
            this.button_user.Click += new System.EventHandler(this.button_user_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 210);
            this.Controls.Add(this.button_user);
            this.Controls.Add(this.button_manager);
            this.Controls.Add(this.button_coach);
            this.Controls.Add(this.button_direrctor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_direrctor;
        private System.Windows.Forms.Button button_coach;
        private System.Windows.Forms.Button button_manager;
        private System.Windows.Forms.Button button_user;
    }
}

