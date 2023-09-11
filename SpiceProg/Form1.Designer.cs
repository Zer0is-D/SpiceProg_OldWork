namespace SpiceProg
{
    partial class Form1
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
            this.save_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surname_box = new System.Windows.Forms.TextBox();
            this.vk_name = new System.Windows.Forms.TextBox();
            this.vk_id = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.coment_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.patronymic_box = new System.Windows.Forms.TextBox();
            this.m_group_box = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(183, 415);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(75, 23);
            this.save_but.TabIndex = 0;
            this.save_but.Text = "Добавить";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ВК";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Возраст";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(152, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Коментарий";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // surname_box
            // 
            this.surname_box.Location = new System.Drawing.Point(27, 28);
            this.surname_box.Name = "surname_box";
            this.surname_box.Size = new System.Drawing.Size(128, 20);
            this.surname_box.TabIndex = 6;
            // 
            // vk_name
            // 
            this.vk_name.Location = new System.Drawing.Point(26, 178);
            this.vk_name.Name = "vk_name";
            this.vk_name.Size = new System.Drawing.Size(186, 20);
            this.vk_name.TabIndex = 7;
            // 
            // vk_id
            // 
            this.vk_id.Location = new System.Drawing.Point(26, 204);
            this.vk_id.Name = "vk_id";
            this.vk_id.Size = new System.Drawing.Size(186, 20);
            this.vk_id.TabIndex = 8;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(81, 240);
            this.age.MaxLength = 2;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(26, 20);
            this.age.TabIndex = 9;
            this.age.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_KeyPress_1);
            // 
            // coment_box
            // 
            this.coment_box.Location = new System.Drawing.Point(27, 297);
            this.coment_box.Multiline = true;
            this.coment_box.Name = "coment_box";
            this.coment_box.Size = new System.Drawing.Size(228, 99);
            this.coment_box.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Отчество";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(26, 72);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(129, 20);
            this.name_box.TabIndex = 14;
            // 
            // patronymic_box
            // 
            this.patronymic_box.Location = new System.Drawing.Point(27, 122);
            this.patronymic_box.Name = "patronymic_box";
            this.patronymic_box.Size = new System.Drawing.Size(128, 20);
            this.patronymic_box.TabIndex = 15;
            this.patronymic_box.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // m_group_box
            // 
            this.m_group_box.Location = new System.Drawing.Point(213, 239);
            this.m_group_box.Mask = "??-99";
            this.m_group_box.Name = "m_group_box";
            this.m_group_box.Size = new System.Drawing.Size(35, 20);
            this.m_group_box.TabIndex = 16;
            this.m_group_box.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.m_group_box_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 450);
            this.Controls.Add(this.m_group_box);
            this.Controls.Add(this.patronymic_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.coment_box);
            this.Controls.Add(this.age);
            this.Controls.Add(this.vk_id);
            this.Controls.Add(this.vk_name);
            this.Controls.Add(this.surname_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surname_box;
        private System.Windows.Forms.TextBox vk_name;
        private System.Windows.Forms.TextBox vk_id;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox coment_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox patronymic_box;
        private System.Windows.Forms.MaskedTextBox m_group_box;
    }
}

