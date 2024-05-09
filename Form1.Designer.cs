namespace TestSQLConnection
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
      dgvData = new DataGridView();
      txtQuery = new TextBox();
      btnExecute = new Button();
      ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
      SuspendLayout();
      // 
      // dgvData
      // 
      dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgvData.Location = new Point(23, 150);
      dgvData.Name = "dgvData";
      dgvData.Size = new Size(765, 288);
      dgvData.TabIndex = 0;
      // 
      // txtQuery
      // 
      txtQuery.Font = new Font("Segoe UI", 15F);
      txtQuery.Location = new Point(32, 12);
      txtQuery.Multiline = true;
      txtQuery.Name = "txtQuery";
      txtQuery.Size = new Size(655, 132);
      txtQuery.TabIndex = 1;
      // 
      // btnExecute
      // 
      btnExecute.Font = new Font("Segoe UI", 15F);
      btnExecute.Location = new Point(693, 12);
      btnExecute.Name = "btnExecute";
      btnExecute.Size = new Size(95, 132);
      btnExecute.TabIndex = 2;
      btnExecute.Text = "Execute";
      btnExecute.UseVisualStyleBackColor = true;
      btnExecute.Click += btnExecute_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(btnExecute);
      Controls.Add(txtQuery);
      Controls.Add(dgvData);
      Name = "Form1";
      Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private DataGridView dgvData;
    private TextBox txtQuery;
    private Button btnExecute;
  }
}
