namespace SML_serialTest
{
    partial class IO_control_form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DBox = new System.Windows.Forms.ComboBox();
            this.PWM_Box = new System.Windows.Forms.TextBox();
            this.D_PWM_button = new System.Windows.Forms.Button();
            this.D_HIGH_button = new System.Windows.Forms.Button();
            this.D_LOW_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.05634F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.94366F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.DBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PWM_Box, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.D_PWM_button, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.D_HIGH_button, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.D_LOW_button, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.37288F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.62712F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(575, 86);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // DBox
            // 
            this.DBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DBox.FormattingEnabled = true;
            this.DBox.Items.AddRange(new object[] {
            "D2",
            "D3",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "D10",
            "D11",
            "D12",
            "D13"});
            this.DBox.Location = new System.Drawing.Point(3, 3);
            this.DBox.Name = "DBox";
            this.DBox.Size = new System.Drawing.Size(102, 28);
            this.DBox.TabIndex = 0;
            this.DBox.SelectedIndexChanged += new System.EventHandler(this.DBox_SelectedIndexChanged);
            // 
            // PWM_Box
            // 
            this.PWM_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PWM_Box.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PWM_Box.Location = new System.Drawing.Point(111, 3);
            this.PWM_Box.Name = "PWM_Box";
            this.PWM_Box.Size = new System.Drawing.Size(81, 30);
            this.PWM_Box.TabIndex = 1;
            // 
            // D_PWM_button
            // 
            this.D_PWM_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.D_PWM_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.D_PWM_button.Location = new System.Drawing.Point(198, 3);
            this.D_PWM_button.Name = "D_PWM_button";
            this.D_PWM_button.Size = new System.Drawing.Size(116, 30);
            this.D_PWM_button.TabIndex = 2;
            this.D_PWM_button.Text = "PWM";
            this.D_PWM_button.UseVisualStyleBackColor = true;
            this.D_PWM_button.Click += new System.EventHandler(this.D_PWM_button_Click);
            // 
            // D_HIGH_button
            // 
            this.D_HIGH_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.D_HIGH_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.D_HIGH_button.Location = new System.Drawing.Point(320, 3);
            this.D_HIGH_button.Name = "D_HIGH_button";
            this.D_HIGH_button.Size = new System.Drawing.Size(116, 30);
            this.D_HIGH_button.TabIndex = 3;
            this.D_HIGH_button.Text = "HIGH";
            this.D_HIGH_button.UseVisualStyleBackColor = true;
            this.D_HIGH_button.Click += new System.EventHandler(this.D_HIGH_button_Click);
            // 
            // D_LOW_button
            // 
            this.D_LOW_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.D_LOW_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.D_LOW_button.Location = new System.Drawing.Point(442, 3);
            this.D_LOW_button.Name = "D_LOW_button";
            this.D_LOW_button.Size = new System.Drawing.Size(130, 30);
            this.D_LOW_button.TabIndex = 4;
            this.D_LOW_button.Text = "LOW";
            this.D_LOW_button.UseVisualStyleBackColor = true;
            this.D_LOW_button.Click += new System.EventHandler(this.D_LOW_button_Click);
            // 
            // IO_control_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 124);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IO_control_form";
            this.Text = "IO_control_form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox DBox;
        private System.Windows.Forms.TextBox PWM_Box;
        private System.Windows.Forms.Button D_PWM_button;
        private System.Windows.Forms.Button D_HIGH_button;
        private System.Windows.Forms.Button D_LOW_button;
    }
}