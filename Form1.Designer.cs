namespace bai_3_pheptinhcoban
{
    partial class Form1
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
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trbSo1 = new System.Windows.Forms.TrackBar();
            this.trbSo2 = new System.Windows.Forms.TrackBar();
            this.txtSo4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSo3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtkqluythua = new System.Windows.Forms.TextBox();
            this.btnbang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbSo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSo2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(78, 86);
            this.txtso1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(126, 26);
            this.txtso1.TabIndex = 1;
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(78, 124);
            this.txtso2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(126, 26);
            this.txtso2.TabIndex = 1;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(78, 162);
            this.txtketqua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(126, 26);
            this.txtketqua.TabIndex = 1;
            this.txtketqua.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng";
            // 
            // btncong
            // 
            this.btncong.Location = new System.Drawing.Point(105, 211);
            this.btncong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(147, 48);
            this.btncong.TabIndex = 3;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(305, 211);
            this.btntru.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(147, 48);
            this.btntru.TabIndex = 3;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(105, 282);
            this.btnnhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(147, 48);
            this.btnnhan.TabIndex = 3;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(305, 282);
            this.btnchia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(147, 48);
            this.btnchia.TabIndex = 3;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CHƯƠNG TRÌNH PHÉP TOÁN CƠ BẢN ";
            // 
            // trbSo1
            // 
            this.trbSo1.LargeChange = 2;
            this.trbSo1.Location = new System.Drawing.Point(211, 86);
            this.trbSo1.Maximum = 50;
            this.trbSo1.Minimum = -50;
            this.trbSo1.Name = "trbSo1";
            this.trbSo1.Size = new System.Drawing.Size(305, 45);
            this.trbSo1.TabIndex = 5;
            this.trbSo1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trbSo2
            // 
            this.trbSo2.LargeChange = 2;
            this.trbSo2.Location = new System.Drawing.Point(211, 124);
            this.trbSo2.Maximum = 50;
            this.trbSo2.Minimum = -50;
            this.trbSo2.Name = "trbSo2";
            this.trbSo2.Size = new System.Drawing.Size(305, 45);
            this.trbSo2.TabIndex = 6;
            this.trbSo2.Scroll += new System.EventHandler(this.trbSo2_Scroll);
            // 
            // txtSo4
            // 
            this.txtSo4.Location = new System.Drawing.Point(670, 138);
            this.txtSo4.Name = "txtSo4";
            this.txtSo4.Size = new System.Drawing.Size(133, 26);
            this.txtSo4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "số mũ";
            // 
            // txtSo3
            // 
            this.txtSo3.Location = new System.Drawing.Point(670, 89);
            this.txtSo3.Name = "txtSo3";
            this.txtSo3.Size = new System.Drawing.Size(133, 26);
            this.txtSo3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(599, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kết quả";
            // 
            // Txtkqluythua
            // 
            this.Txtkqluythua.Location = new System.Drawing.Point(669, 186);
            this.Txtkqluythua.Name = "Txtkqluythua";
            this.Txtkqluythua.Size = new System.Drawing.Size(133, 26);
            this.Txtkqluythua.TabIndex = 7;
            this.Txtkqluythua.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnbang
            // 
            this.btnbang.Location = new System.Drawing.Point(838, 141);
            this.btnbang.Name = "btnbang";
            this.btnbang.Size = new System.Drawing.Size(75, 23);
            this.btnbang.TabIndex = 9;
            this.btnbang.Text = "=";
            this.btnbang.UseVisualStyleBackColor = true;
            this.btnbang.Click += new System.EventHandler(this.btnbang_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSo3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtkqluythua);
            this.Controls.Add(this.txtSo4);
            this.Controls.Add(this.trbSo2);
            this.Controls.Add(this.trbSo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbSo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trbSo1;
        private System.Windows.Forms.TrackBar trbSo2;
        private System.Windows.Forms.TextBox txtSo4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSo3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtkqluythua;
        private System.Windows.Forms.Button btnbang;
        private System.Windows.Forms.Button button1;
    }
}

