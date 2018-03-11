namespace Demo.WindowsForms
{
   partial class StaticImage
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
         if(disposing && (components != null))
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
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxWorldFile = new System.Windows.Forms.CheckBox();
            this.checkBoxRoutes = new System.Windows.Forms.CheckBox();
            this.checkBoxKMZ = new System.Windows.Forms.CheckBox();
            this.textBoxSizeFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBoxSaveAs = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(366, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(6, 6);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(353, 93);
            this.progressBar1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(404, 6);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(366, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zoom:";
            // 
            // checkBoxWorldFile
            // 
            this.checkBoxWorldFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWorldFile.AutoSize = true;
            this.checkBoxWorldFile.Checked = true;
            this.checkBoxWorldFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWorldFile.Location = new System.Drawing.Point(189, 115);
            this.checkBoxWorldFile.Name = "checkBoxWorldFile";
            this.checkBoxWorldFile.Size = new System.Drawing.Size(67, 17);
            this.checkBoxWorldFile.TabIndex = 6;
            this.checkBoxWorldFile.Text = "Worldfile";
            this.checkBoxWorldFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxRoutes
            // 
            this.checkBoxRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxRoutes.AutoSize = true;
            this.checkBoxRoutes.Location = new System.Drawing.Point(7, 115);
            this.checkBoxRoutes.Name = "checkBoxRoutes";
            this.checkBoxRoutes.Size = new System.Drawing.Size(147, 17);
            this.checkBoxRoutes.TabIndex = 7;
            this.checkBoxRoutes.Text = "Use area of routes in map";
            this.checkBoxRoutes.UseVisualStyleBackColor = true;
            // 
            // checkBoxKMZ
            // 
            this.checkBoxKMZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxKMZ.AutoSize = true;
            this.checkBoxKMZ.Location = new System.Drawing.Point(291, 115);
            this.checkBoxKMZ.Name = "checkBoxKMZ";
            this.checkBoxKMZ.Size = new System.Drawing.Size(49, 17);
            this.checkBoxKMZ.TabIndex = 8;
            this.checkBoxKMZ.Text = "KMZ";
            this.checkBoxKMZ.UseVisualStyleBackColor = true;
            // 
            // textBoxSizeFile
            // 
            this.textBoxSizeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSizeFile.Location = new System.Drawing.Point(422, 113);
            this.textBoxSizeFile.MaxLength = 2;
            this.textBoxSizeFile.Name = "textBoxSizeFile";
            this.textBoxSizeFile.Size = new System.Drawing.Size(28, 20);
            this.textBoxSizeFile.TabIndex = 9;
            this.textBoxSizeFile.Text = "10";
            this.textBoxSizeFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Size (Mo):";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.Filter = "png|*.png";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save as";
            // 
            // textBoxSaveAs
            // 
            this.textBoxSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSaveAs.Location = new System.Drawing.Point(7, 139);
            this.textBoxSaveAs.Name = "textBoxSaveAs";
            this.textBoxSaveAs.ReadOnly = true;
            this.textBoxSaveAs.Size = new System.Drawing.Size(352, 20);
            this.textBoxSaveAs.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(366, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Set file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StaticImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 173);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxSaveAs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSizeFile);
            this.Controls.Add(this.checkBoxKMZ);
            this.Controls.Add(this.checkBoxRoutes);
            this.Controls.Add(this.checkBoxWorldFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(16, 164);
            this.Name = "StaticImage";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Static Map maker";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.ProgressBar progressBar1;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.CheckBox checkBoxWorldFile;
      private System.Windows.Forms.CheckBox checkBoxRoutes;
      private System.Windows.Forms.CheckBox checkBoxKMZ;
        private System.Windows.Forms.TextBox textBoxSizeFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBoxSaveAs;
        private System.Windows.Forms.Button btnSave;
    }
}