
namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Q_button = new System.Windows.Forms.Button();
            this.W_button = new System.Windows.Forms.Button();
            this.E_button = new System.Windows.Forms.Button();
            this.R_button = new System.Windows.Forms.Button();
            this.T_button = new System.Windows.Forms.Button();
            this.Y_button = new System.Windows.Forms.Button();
            this.U_button = new System.Windows.Forms.Button();
            this.I_button = new System.Windows.Forms.Button();
            this.O_button = new System.Windows.Forms.Button();
            this.P_button = new System.Windows.Forms.Button();
            this.Background_color_button = new System.Windows.Forms.Button();
            this.plates_color_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Location = new System.Drawing.Point(235, 88);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(167, 25);
            this.Start.TabIndex = 0;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Q_button
            // 
            this.Q_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Q_button.Location = new System.Drawing.Point(9, 337);
            this.Q_button.Margin = new System.Windows.Forms.Padding(2);
            this.Q_button.Name = "Q_button";
            this.Q_button.Size = new System.Drawing.Size(56, 19);
            this.Q_button.TabIndex = 2;
            this.Q_button.Text = "Q";
            this.Q_button.UseVisualStyleBackColor = true;
            this.Q_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // W_button
            // 
            this.W_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.W_button.Location = new System.Drawing.Point(70, 337);
            this.W_button.Margin = new System.Windows.Forms.Padding(2);
            this.W_button.Name = "W_button";
            this.W_button.Size = new System.Drawing.Size(56, 19);
            this.W_button.TabIndex = 3;
            this.W_button.Text = "W";
            this.W_button.UseVisualStyleBackColor = true;
            this.W_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // E_button
            // 
            this.E_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.E_button.Location = new System.Drawing.Point(130, 337);
            this.E_button.Margin = new System.Windows.Forms.Padding(2);
            this.E_button.Name = "E_button";
            this.E_button.Size = new System.Drawing.Size(56, 19);
            this.E_button.TabIndex = 4;
            this.E_button.Text = "E";
            this.E_button.UseVisualStyleBackColor = true;
            this.E_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // R_button
            // 
            this.R_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.R_button.Location = new System.Drawing.Point(191, 337);
            this.R_button.Margin = new System.Windows.Forms.Padding(2);
            this.R_button.Name = "R_button";
            this.R_button.Size = new System.Drawing.Size(56, 19);
            this.R_button.TabIndex = 5;
            this.R_button.Text = "R";
            this.R_button.UseVisualStyleBackColor = true;
            this.R_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // T_button
            // 
            this.T_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.T_button.Location = new System.Drawing.Point(252, 337);
            this.T_button.Margin = new System.Windows.Forms.Padding(2);
            this.T_button.Name = "T_button";
            this.T_button.Size = new System.Drawing.Size(56, 19);
            this.T_button.TabIndex = 6;
            this.T_button.Text = "T";
            this.T_button.UseVisualStyleBackColor = true;
            this.T_button.Click += new System.EventHandler(this.T_button_Click);
            // 
            // Y_button
            // 
            this.Y_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Y_button.Location = new System.Drawing.Point(313, 337);
            this.Y_button.Margin = new System.Windows.Forms.Padding(2);
            this.Y_button.Name = "Y_button";
            this.Y_button.Size = new System.Drawing.Size(56, 19);
            this.Y_button.TabIndex = 7;
            this.Y_button.Text = "Y";
            this.Y_button.UseVisualStyleBackColor = true;
            this.Y_button.Click += new System.EventHandler(this.Y_button_Click);
            // 
            // U_button
            // 
            this.U_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.U_button.Location = new System.Drawing.Point(374, 337);
            this.U_button.Margin = new System.Windows.Forms.Padding(2);
            this.U_button.Name = "U_button";
            this.U_button.Size = new System.Drawing.Size(56, 19);
            this.U_button.TabIndex = 8;
            this.U_button.Text = "U";
            this.U_button.UseVisualStyleBackColor = true;
            this.U_button.Click += new System.EventHandler(this.U_button_Click);
            // 
            // I_button
            // 
            this.I_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.I_button.Location = new System.Drawing.Point(435, 337);
            this.I_button.Margin = new System.Windows.Forms.Padding(2);
            this.I_button.Name = "I_button";
            this.I_button.Size = new System.Drawing.Size(56, 19);
            this.I_button.TabIndex = 9;
            this.I_button.Text = "I";
            this.I_button.UseVisualStyleBackColor = true;
            this.I_button.Click += new System.EventHandler(this.I_button_Click);
            // 
            // O_button
            // 
            this.O_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.O_button.Location = new System.Drawing.Point(496, 337);
            this.O_button.Margin = new System.Windows.Forms.Padding(2);
            this.O_button.Name = "O_button";
            this.O_button.Size = new System.Drawing.Size(56, 19);
            this.O_button.TabIndex = 10;
            this.O_button.Text = "O";
            this.O_button.UseVisualStyleBackColor = true;
            this.O_button.Click += new System.EventHandler(this.O_button_Click);
            // 
            // P_button
            // 
            this.P_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.P_button.Location = new System.Drawing.Point(557, 337);
            this.P_button.Margin = new System.Windows.Forms.Padding(2);
            this.P_button.Name = "P_button";
            this.P_button.Size = new System.Drawing.Size(56, 19);
            this.P_button.TabIndex = 11;
            this.P_button.Text = "P";
            this.P_button.UseVisualStyleBackColor = true;
            this.P_button.Click += new System.EventHandler(this.P_button_Click);
            // 
            // Background_color_button
            // 
            this.Background_color_button.BackColor = System.Drawing.Color.Turquoise;
            this.Background_color_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Background_color_button.Location = new System.Drawing.Point(130, 132);
            this.Background_color_button.Name = "Background_color_button";
            this.Background_color_button.Size = new System.Drawing.Size(56, 54);
            this.Background_color_button.TabIndex = 12;
            this.Background_color_button.Text = "Цвет фона";
            this.Background_color_button.UseVisualStyleBackColor = false;
            this.Background_color_button.Click += new System.EventHandler(this.Background_color_button_Click);
            // 
            // plates_color_button
            // 
            this.plates_color_button.BackColor = System.Drawing.Color.Turquoise;
            this.plates_color_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plates_color_button.Location = new System.Drawing.Point(435, 132);
            this.plates_color_button.Name = "plates_color_button";
            this.plates_color_button.Size = new System.Drawing.Size(56, 54);
            this.plates_color_button.TabIndex = 13;
            this.plates_color_button.Text = "Цвет плиток";
            this.plates_color_button.UseVisualStyleBackColor = false;
            this.plates_color_button.Click += new System.EventHandler(this.plates_color_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 366);
            this.Controls.Add(this.plates_color_button);
            this.Controls.Add(this.Background_color_button);
            this.Controls.Add(this.P_button);
            this.Controls.Add(this.O_button);
            this.Controls.Add(this.I_button);
            this.Controls.Add(this.U_button);
            this.Controls.Add(this.Y_button);
            this.Controls.Add(this.T_button);
            this.Controls.Add(this.R_button);
            this.Controls.Add(this.E_button);
            this.Controls.Add(this.W_button);
            this.Controls.Add(this.Q_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Start);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Q_button;
        private System.Windows.Forms.Button W_button;
        private System.Windows.Forms.Button E_button;
        private System.Windows.Forms.Button R_button;
        private System.Windows.Forms.Button T_button;
        private System.Windows.Forms.Button Y_button;
        private System.Windows.Forms.Button U_button;
        private System.Windows.Forms.Button I_button;
        private System.Windows.Forms.Button O_button;
        private System.Windows.Forms.Button P_button;
        private System.Windows.Forms.Button Background_color_button;
        private System.Windows.Forms.Button plates_color_button;
    }
}

