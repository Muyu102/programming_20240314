using System;

namespace _20240314
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.but_plus = new System.Windows.Forms.Button();
            this.but_minus = new System.Windows.Forms.Button();
            this.but_times = new System.Windows.Forms.Button();
            this.but_division = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.but_7 = new System.Windows.Forms.Button();
            this.but_8 = new System.Windows.Forms.Button();
            this.but_9 = new System.Windows.Forms.Button();
            this.but_6 = new System.Windows.Forms.Button();
            this.but_5 = new System.Windows.Forms.Button();
            this.but_4 = new System.Windows.Forms.Button();
            this.but_3 = new System.Windows.Forms.Button();
            this.but_2 = new System.Windows.Forms.Button();
            this.but_1 = new System.Windows.Forms.Button();
            this.but_0 = new System.Windows.Forms.Button();
            this.but_equals = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_plus
            // 
            this.but_plus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.but_plus.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.but_plus.Location = new System.Drawing.Point(446, 186);
            this.but_plus.Name = "but_plus";
            this.but_plus.Size = new System.Drawing.Size(118, 162);
            this.but_plus.TabIndex = 0;
            this.but_plus.Text = "+";
            this.but_plus.UseVisualStyleBackColor = false;
            this.but_plus.Click += new System.EventHandler(this.func_press);
            // 
            // but_minus
            // 
            this.but_minus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.but_minus.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_minus.Location = new System.Drawing.Point(446, 94);
            this.but_minus.Name = "but_minus";
            this.but_minus.Size = new System.Drawing.Size(118, 64);
            this.but_minus.TabIndex = 1;
            this.but_minus.Text = "-";
            this.but_minus.UseVisualStyleBackColor = false;
            this.but_minus.Click += new System.EventHandler(this.func_press);
            // 
            // but_times
            // 
            this.but_times.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.but_times.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_times.Location = new System.Drawing.Point(306, 94);
            this.but_times.Name = "but_times";
            this.but_times.Size = new System.Drawing.Size(118, 64);
            this.but_times.TabIndex = 2;
            this.but_times.Text = "*";
            this.but_times.UseVisualStyleBackColor = false;
            this.but_times.Click += new System.EventHandler(this.func_press);
            // 
            // but_division
            // 
            this.but_division.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.but_division.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_division.Location = new System.Drawing.Point(167, 94);
            this.but_division.Name = "but_division";
            this.but_division.Size = new System.Drawing.Size(118, 64);
            this.but_division.TabIndex = 3;
            this.but_division.Text = "/";
            this.but_division.UseVisualStyleBackColor = false;
            this.but_division.Click += new System.EventHandler(this.func_press);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(28, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(536, 43);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // but_7
            // 
            this.but_7.Location = new System.Drawing.Point(28, 186);
            this.but_7.Name = "but_7";
            this.but_7.Size = new System.Drawing.Size(118, 64);
            this.but_7.TabIndex = 5;
            this.but_7.Text = "7";
            this.but_7.UseVisualStyleBackColor = true;
            this.but_7.Click += new System.EventHandler(this.num_press);
            // 
            // but_8
            // 
            this.but_8.Location = new System.Drawing.Point(167, 186);
            this.but_8.Name = "but_8";
            this.but_8.Size = new System.Drawing.Size(118, 64);
            this.but_8.TabIndex = 6;
            this.but_8.Text = "8";
            this.but_8.UseVisualStyleBackColor = true;
            this.but_8.Click += new System.EventHandler(this.num_press);
            // 
            // but_9
            // 
            this.but_9.Location = new System.Drawing.Point(306, 186);
            this.but_9.Name = "but_9";
            this.but_9.Size = new System.Drawing.Size(118, 64);
            this.but_9.TabIndex = 7;
            this.but_9.Text = "9";
            this.but_9.UseVisualStyleBackColor = true;
            this.but_9.Click += new System.EventHandler(this.num_press);
            // 
            // but_6
            // 
            this.but_6.Location = new System.Drawing.Point(306, 284);
            this.but_6.Name = "but_6";
            this.but_6.Size = new System.Drawing.Size(118, 64);
            this.but_6.TabIndex = 10;
            this.but_6.Text = "6";
            this.but_6.UseVisualStyleBackColor = true;
            this.but_6.Click += new System.EventHandler(this.num_press);
            // 
            // but_5
            // 
            this.but_5.Location = new System.Drawing.Point(167, 284);
            this.but_5.Name = "but_5";
            this.but_5.Size = new System.Drawing.Size(118, 64);
            this.but_5.TabIndex = 9;
            this.but_5.Text = "5";
            this.but_5.UseVisualStyleBackColor = true;
            this.but_5.Click += new System.EventHandler(this.num_press);
            // 
            // but_4
            // 
            this.but_4.Location = new System.Drawing.Point(28, 284);
            this.but_4.Name = "but_4";
            this.but_4.Size = new System.Drawing.Size(118, 64);
            this.but_4.TabIndex = 8;
            this.but_4.Text = "4";
            this.but_4.UseVisualStyleBackColor = true;
            this.but_4.Click += new System.EventHandler(this.num_press);
            // 
            // but_3
            // 
            this.but_3.Location = new System.Drawing.Point(306, 374);
            this.but_3.Name = "but_3";
            this.but_3.Size = new System.Drawing.Size(118, 64);
            this.but_3.TabIndex = 13;
            this.but_3.Text = "3";
            this.but_3.UseVisualStyleBackColor = true;
            this.but_3.Click += new System.EventHandler(this.num_press);
            // 
            // but_2
            // 
            this.but_2.Location = new System.Drawing.Point(167, 374);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(118, 64);
            this.but_2.TabIndex = 12;
            this.but_2.Text = "2";
            this.but_2.UseVisualStyleBackColor = true;
            this.but_2.Click += new System.EventHandler(this.num_press);
            // 
            // but_1
            // 
            this.but_1.Location = new System.Drawing.Point(28, 374);
            this.but_1.Name = "but_1";
            this.but_1.Size = new System.Drawing.Size(118, 64);
            this.but_1.TabIndex = 11;
            this.but_1.Text = "1";
            this.but_1.UseVisualStyleBackColor = true;
            this.but_1.Click += new System.EventHandler(this.num_press);
            // 
            // but_0
            // 
            this.but_0.Location = new System.Drawing.Point(28, 466);
            this.but_0.Name = "but_0";
            this.but_0.Size = new System.Drawing.Size(257, 64);
            this.but_0.TabIndex = 14;
            this.but_0.Text = "0";
            this.but_0.UseVisualStyleBackColor = true;
            this.but_0.Click += new System.EventHandler(this.num_press);
            // 
            // but_equals
            // 
            this.but_equals.BackColor = System.Drawing.Color.PaleTurquoise;
            this.but_equals.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.but_equals.Location = new System.Drawing.Point(446, 374);
            this.but_equals.Name = "but_equals";
            this.but_equals.Size = new System.Drawing.Size(118, 156);
            this.but_equals.TabIndex = 16;
            this.but_equals.Text = "=";
            this.but_equals.UseVisualStyleBackColor = false;
            this.but_equals.Click += new System.EventHandler(this.process_press);
            // 
            // but_del
            // 
            this.but_del.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.but_del.Location = new System.Drawing.Point(306, 466);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(118, 64);
            this.but_del.TabIndex = 17;
            this.but_del.Text = ".";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.btn_point_Clink);
            // 
            // but_clear
            // 
            this.but_clear.BackColor = System.Drawing.Color.LightCoral;
            this.but_clear.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_clear.Location = new System.Drawing.Point(28, 94);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(118, 64);
            this.but_clear.TabIndex = 18;
            this.but_clear.Text = "clear";
            this.but_clear.UseVisualStyleBackColor = false;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 556);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_equals);
            this.Controls.Add(this.but_0);
            this.Controls.Add(this.but_3);
            this.Controls.Add(this.but_2);
            this.Controls.Add(this.but_1);
            this.Controls.Add(this.but_6);
            this.Controls.Add(this.but_5);
            this.Controls.Add(this.but_4);
            this.Controls.Add(this.but_9);
            this.Controls.Add(this.but_8);
            this.Controls.Add(this.but_7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.but_division);
            this.Controls.Add(this.but_times);
            this.Controls.Add(this.but_minus);
            this.Controls.Add(this.but_plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_plus;
        private System.Windows.Forms.Button but_minus;
        private System.Windows.Forms.Button but_times;
        private System.Windows.Forms.Button but_division;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button but_7;
        private System.Windows.Forms.Button but_8;
        private System.Windows.Forms.Button but_9;
        private System.Windows.Forms.Button but_6;
        private System.Windows.Forms.Button but_5;
        private System.Windows.Forms.Button but_4;
        private System.Windows.Forms.Button but_3;
        private System.Windows.Forms.Button but_2;
        private System.Windows.Forms.Button but_1;
        private System.Windows.Forms.Button but_0;
        private System.Windows.Forms.Button but_equals;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_clear;
    }
}

