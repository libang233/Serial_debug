namespace SML_serialTest
{
    partial class translate_form
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
            this.choose_file = new System.Windows.Forms.Button();
            this.prefile_textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trans_button = new System.Windows.Forms.Button();
            this.translated_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // choose_file
            // 
            this.choose_file.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choose_file.Location = new System.Drawing.Point(465, 40);
            this.choose_file.Name = "choose_file";
            this.choose_file.Size = new System.Drawing.Size(88, 34);
            this.choose_file.TabIndex = 0;
            this.choose_file.Text = "选择";
            this.choose_file.UseVisualStyleBackColor = true;
            this.choose_file.Click += new System.EventHandler(this.choose_file_Click);
            // 
            // prefile_textBox
            // 
            this.prefile_textBox.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prefile_textBox.Location = new System.Drawing.Point(45, 40);
            this.prefile_textBox.Name = "prefile_textBox";
            this.prefile_textBox.Size = new System.Drawing.Size(343, 34);
            this.prefile_textBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trans_button
            // 
            this.trans_button.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trans_button.Location = new System.Drawing.Point(465, 117);
            this.trans_button.Name = "trans_button";
            this.trans_button.Size = new System.Drawing.Size(88, 35);
            this.trans_button.TabIndex = 2;
            this.trans_button.Text = "编译";
            this.trans_button.UseVisualStyleBackColor = true;
            // 
            // translated_Text
            // 
            this.translated_Text.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.translated_Text.Location = new System.Drawing.Point(45, 117);
            this.translated_Text.Multiline = true;
            this.translated_Text.Name = "translated_Text";
            this.translated_Text.Size = new System.Drawing.Size(343, 265);
            this.translated_Text.TabIndex = 3;
            // 
            // translate_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 451);
            this.Controls.Add(this.translated_Text);
            this.Controls.Add(this.trans_button);
            this.Controls.Add(this.prefile_textBox);
            this.Controls.Add(this.choose_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "translate_form";
            this.Text = "i/";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choose_file;
        private System.Windows.Forms.TextBox prefile_textBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button trans_button;
        private System.Windows.Forms.TextBox translated_Text;
    }
}