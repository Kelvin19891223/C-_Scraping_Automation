namespace XBot
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.btn_open_main = new System.Windows.Forms.Button();
            this.txt_main_csv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_remain = new System.Windows.Forms.Label();
            this.lab_status1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_status = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.grid_main = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RSI_30_MIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day_Change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wk_high = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wk_Low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_RSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bind_main = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_tbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_open_main
            // 
            this.btn_open_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open_main.BackgroundImage = global::XBot.Properties.Resources.Open_52px;
            this.btn_open_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_open_main.FlatAppearance.BorderSize = 0;
            this.btn_open_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_main.Location = new System.Drawing.Point(1187, 16);
            this.btn_open_main.Name = "btn_open_main";
            this.btn_open_main.Size = new System.Drawing.Size(28, 23);
            this.btn_open_main.TabIndex = 2;
            this.btn_open_main.UseVisualStyleBackColor = true;
            this.btn_open_main.Click += new System.EventHandler(this.btn_open_main_Click);
            // 
            // txt_main_csv
            // 
            this.txt_main_csv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_main_csv.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_main_csv.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_main_csv.Location = new System.Drawing.Point(88, 16);
            this.txt_main_csv.Name = "txt_main_csv";
            this.txt_main_csv.Size = new System.Drawing.Size(1092, 23);
            this.txt_main_csv.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lab_remain);
            this.panel2.Controls.Add(this.lab_status1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 699);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1229, 30);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(91, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 22;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(1084, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Remaining";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_remain
            // 
            this.lab_remain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lab_remain.AutoSize = true;
            this.lab_remain.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_remain.ForeColor = System.Drawing.Color.Red;
            this.lab_remain.Location = new System.Drawing.Point(1170, -1);
            this.lab_remain.Name = "lab_remain";
            this.lab_remain.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lab_remain.Size = new System.Drawing.Size(48, 32);
            this.lab_remain.TabIndex = 8;
            this.lab_remain.Text = "0";
            this.lab_remain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_status1
            // 
            this.lab_status1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lab_status1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lab_status1.Location = new System.Drawing.Point(0, 0);
            this.lab_status1.Name = "lab_status1";
            this.lab_status1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lab_status1.Size = new System.Drawing.Size(91, 30);
            this.lab_status1.TabIndex = 1;
            this.lab_status1.Text = "Last Update";
            this.lab_status1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Excel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lab_status);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_open_main);
            this.panel1.Controls.Add(this.txt_main_csv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 112);
            this.panel1.TabIndex = 0;
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_status.Location = new System.Drawing.Point(991, 82);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(0, 17);
            this.lab_status.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(550, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 25);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(429, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Interval Time (min)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(147, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "During Time (s)";
            // 
            // panel_tbl
            // 
            this.panel_tbl.ColumnCount = 1;
            this.panel_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_tbl.Controls.Add(this.grid_main, 0, 1);
            this.panel_tbl.Controls.Add(this.panel1, 0, 0);
            this.panel_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tbl.Location = new System.Drawing.Point(0, 0);
            this.panel_tbl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_tbl.Name = "panel_tbl";
            this.panel_tbl.RowCount = 2;
            this.panel_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panel_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_tbl.Size = new System.Drawing.Size(1229, 729);
            this.panel_tbl.TabIndex = 3;
            // 
            // grid_main
            // 
            this.grid_main.AllowUserToAddRows = false;
            this.grid_main.AllowUserToDeleteRows = false;
            this.grid_main.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Name,
            this.RSI_30_MIN,
            this.Last_Price,
            this.Day_Change,
            this.wk_high,
            this.wk_Low,
            this.G_Last,
            this.G_RSI});
            this.grid_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_main.Location = new System.Drawing.Point(3, 123);
            this.grid_main.Name = "grid_main";
            this.grid_main.ReadOnly = true;
            this.grid_main.RowHeadersVisible = false;
            this.grid_main.RowTemplate.Height = 30;
            this.grid_main.Size = new System.Drawing.Size(1223, 603);
            this.grid_main.TabIndex = 1;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 50;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // RSI_30_MIN
            // 
            this.RSI_30_MIN.HeaderText = "RSI 30 MIN";
            this.RSI_30_MIN.Name = "RSI_30_MIN";
            this.RSI_30_MIN.ReadOnly = true;
            // 
            // Last_Price
            // 
            this.Last_Price.HeaderText = "Last Price";
            this.Last_Price.Name = "Last_Price";
            this.Last_Price.ReadOnly = true;
            // 
            // Day_Change
            // 
            this.Day_Change.HeaderText = "Day Change(%)";
            this.Day_Change.Name = "Day_Change";
            this.Day_Change.ReadOnly = true;
            this.Day_Change.Width = 150;
            // 
            // wk_high
            // 
            this.wk_high.HeaderText = "52wk High";
            this.wk_high.Name = "wk_high";
            this.wk_high.ReadOnly = true;
            this.wk_high.Width = 90;
            // 
            // wk_Low
            // 
            this.wk_Low.HeaderText = "52wk Low";
            this.wk_Low.Name = "wk_Low";
            this.wk_Low.ReadOnly = true;
            this.wk_Low.Width = 90;
            // 
            // G_Last
            // 
            this.G_Last.HeaderText = "G=(52wk High minus Last Price) / Last Price";
            this.G_Last.Name = "G_Last";
            this.G_Last.ReadOnly = true;
            this.G_Last.Width = 200;
            // 
            // G_RSI
            // 
            this.G_RSI.HeaderText = "G/RSI 30";
            this.G_RSI.Name = "G_RSI";
            this.G_RSI.ReadOnly = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1229, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_tbl);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_tbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_open_main;
        private System.Windows.Forms.TextBox txt_main_csv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_status1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel panel_tbl;
        private System.Windows.Forms.DataGridView grid_main;
        private System.Windows.Forms.BindingSource bind_main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RSI_30_MIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day_Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn wk_high;
        private System.Windows.Forms.DataGridViewTextBoxColumn wk_Low;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_RSI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_remain;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_status;
    }
}

