namespace Civ6IconCreator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.generateButton = new System.Windows.Forms.Button();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.outputDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.inputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.texConvDirDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.sedDirDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(435, 6);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(75, 19);
            this.inputButton.TabIndex = 5;
            this.inputButton.Text = "開く";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(54, 6);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(375, 19);
            this.inputTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 56);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 16);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Leader";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(71, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 16);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Civilization";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(156, 56);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 16);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "UnitFlags";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "OutPut";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(54, 31);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(375, 19);
            this.outputTextBox.TabIndex = 7;
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(435, 31);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 19);
            this.outputButton.TabIndex = 8;
            this.outputButton.Text = "開く";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(234, 56);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(88, 16);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.Text = "UnitPortraits";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(331, 56);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(70, 16);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.Text = "Buildings";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Enabled = false;
            this.generateButton.Location = new System.Drawing.Point(519, 6);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(105, 44);
            this.generateButton.TabIndex = 17;
            this.generateButton.Text = "生成";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(407, 56);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(67, 16);
            this.radioButton6.TabIndex = 14;
            this.radioButton6.Text = "Districts";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(480, 56);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(94, 16);
            this.radioButton7.TabIndex = 15;
            this.radioButton7.Text = "Improvements";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Preview";
            // 
            // outputDirDialog
            // 
            this.outputDirDialog.Description = "出力先を選択";
            // 
            // inputFileDialog
            // 
            this.inputFileDialog.FileName = "inputFileDialog";
            this.inputFileDialog.Filter = "PNGファイル(*.png)|*.png";
            // 
            // texConvDirDialog
            // 
            this.texConvDirDialog.FileName = "texConvDirDialog";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 379);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inputTextBox);
            this.tabPage1.Controls.Add(this.inputButton);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.outputButton);
            this.tabPage1.Controls.Add(this.radioButton7);
            this.tabPage1.Controls.Add(this.outputTextBox);
            this.tabPage1.Controls.Add(this.radioButton6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.radioButton5);
            this.tabPage1.Controls.Add(this.generateButton);
            this.tabPage1.Controls.Add(this.radioButton4);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton3);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "メイン";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Civ6IconCreator.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(8, 91);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(256, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ResetButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "前回の場所を消去";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(110, 11);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(53, 23);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "クリア";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // sedDirDialog
            // 
            this.sedDirDialog.FileName = "sedDirDialog";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(636, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 17);
            this.toolStripStatusLabel1.Text = "アプリケーションを起動しました。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 400);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Civ6 Icon Creator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog outputDirDialog;
        private System.Windows.Forms.OpenFileDialog inputFileDialog;
        private System.Windows.Forms.OpenFileDialog texConvDirDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog sedDirDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

