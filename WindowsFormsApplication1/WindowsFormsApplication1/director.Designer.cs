namespace WindowsFormsApplication1
{
    partial class director
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
            this.button_dollars = new System.Windows.Forms.Button();
            this.button_fire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_reward = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_dollars
            // 
            this.button_dollars.Location = new System.Drawing.Point(139, 12);
            this.button_dollars.Name = "button_dollars";
            this.button_dollars.Size = new System.Drawing.Size(93, 23);
            this.button_dollars.TabIndex = 0;
            this.button_dollars.Text = "Дать зарплату";
            this.button_dollars.UseVisualStyleBackColor = true;
            this.button_dollars.Click += new System.EventHandler(this.button_dollars_Click);
            // 
            // button_fire
            // 
            this.button_fire.Location = new System.Drawing.Point(238, 12);
            this.button_fire.Name = "button_fire";
            this.button_fire.Size = new System.Drawing.Size(93, 23);
            this.button_fire.TabIndex = 1;
            this.button_fire.Text = "Уволить";
            this.button_fire.UseVisualStyleBackColor = true;
            this.button_fire.Click += new System.EventHandler(this.button_fire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "шо";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "каво";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox_reward
            // 
            this.checkBox_reward.AutoSize = true;
            this.checkBox_reward.Location = new System.Drawing.Point(139, 44);
            this.checkBox_reward.Name = "checkBox_reward";
            this.checkBox_reward.Size = new System.Drawing.Size(80, 17);
            this.checkBox_reward.TabIndex = 4;
            this.checkBox_reward.Text = "Похвалить";
            this.checkBox_reward.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Щищарин",
            "Сраколовский",
            "Старыйстенок",
            "Некрассовкин",
            "Беспалкин",
            "Автоботов",
            "Мразин",
            "К♂стрик♂в"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(256, 40);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 70);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox_reward);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_fire);
            this.Controls.Add(this.button_dollars);
            this.Name = "director";
            this.Text = "director";
            this.Load += new System.EventHandler(this.director_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_dollars;
        private System.Windows.Forms.Button button_fire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_reward;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_back;
    }
}