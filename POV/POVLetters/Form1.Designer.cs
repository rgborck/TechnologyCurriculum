namespace POVLetters
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
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnPrev = new System.Windows.Forms.Button();
      this.btnNext = new System.Windows.Forms.Button();
      this.txtLetterName = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnImport = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtOutput
      // 
      this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtOutput.Location = new System.Drawing.Point(12, 617);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ReadOnly = true;
      this.txtOutput.Size = new System.Drawing.Size(784, 156);
      this.txtOutput.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(102, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "LetterName:";
      // 
      // btnPrev
      // 
      this.btnPrev.Location = new System.Drawing.Point(12, 9);
      this.btnPrev.Name = "btnPrev";
      this.btnPrev.Size = new System.Drawing.Size(75, 23);
      this.btnPrev.TabIndex = 2;
      this.btnPrev.Text = "<";
      this.btnPrev.UseVisualStyleBackColor = true;
      this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
      // 
      // btnNext
      // 
      this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnNext.Location = new System.Drawing.Point(721, 6);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(75, 23);
      this.btnNext.TabIndex = 3;
      this.btnNext.Text = ">";
      this.btnNext.UseVisualStyleBackColor = true;
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // txtLetterName
      // 
      this.txtLetterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtLetterName.Location = new System.Drawing.Point(204, 9);
      this.txtLetterName.Name = "txtLetterName";
      this.txtLetterName.Size = new System.Drawing.Size(499, 22);
      this.txtLetterName.TabIndex = 4;
      this.txtLetterName.TextChanged += new System.EventHandler(this.txtLetterName_TextChanged);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(721, 109);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "Export";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnImport
      // 
      this.btnImport.Location = new System.Drawing.Point(721, 80);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new System.Drawing.Size(75, 23);
      this.btnImport.TabIndex = 6;
      this.btnImport.Text = "Import";
      this.btnImport.UseVisualStyleBackColor = true;
      this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(721, 36);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 7;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(808, 785);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnImport);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtLetterName);
      this.Controls.Add(this.btnNext);
      this.Controls.Add(this.btnPrev);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtOutput);
      this.MinimumSize = new System.Drawing.Size(826, 832);
      this.Name = "Form1";
      this.Text = "Letter Creator";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnPrev;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.TextBox txtLetterName;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnImport;
    private System.Windows.Forms.Button btnDelete;



  }
}

