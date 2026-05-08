namespace FileCountReporter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            browseButton = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            filePathLabel = new Label();
            countButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // browseButton
            // 
            browseButton.Location = new Point(52, 31);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(107, 23);
            browseButton.TabIndex = 1;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(349, 207);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 2;
            // 
            // filePathLabel
            // 
            filePathLabel.AutoSize = true;
            filePathLabel.Location = new Point(32, 78);
            filePathLabel.Name = "filePathLabel";
            filePathLabel.Size = new Size(55, 15);
            filePathLabel.TabIndex = 3;
            filePathLabel.Text = "File Path:";
            // 
            // countButton
            // 
            countButton.Location = new Point(240, 31);
            countButton.Name = "countButton";
            countButton.Size = new Size(114, 23);
            countButton.TabIndex = 3;
            countButton.Text = "Count";
            countButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 348);
            Controls.Add(countButton);
            Controls.Add(filePathLabel);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(browseButton);
            Name = "Form1";
            Text = "File Count Reporter";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseButton;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label filePathLabel;
        private Button countButton;
    }
}
