namespace WinForms_240111_animacjaPictureBox_LeftTop
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.buttonLewo = new System.Windows.Forms.Button();
      this.buttonGora = new System.Windows.Forms.Button();
      this.buttonDol = new System.Windows.Forms.Button();
      this.buttonPrawo = new System.Windows.Forms.Button();
      this.buttonPoczatek = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(109, 36);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(124, 68);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
      // 
      // buttonLewo
      // 
      this.buttonLewo.Location = new System.Drawing.Point(81, 374);
      this.buttonLewo.Name = "buttonLewo";
      this.buttonLewo.Size = new System.Drawing.Size(75, 23);
      this.buttonLewo.TabIndex = 1;
      this.buttonLewo.Text = "lewo";
      this.buttonLewo.UseVisualStyleBackColor = true;
      this.buttonLewo.Click += new System.EventHandler(this.buttonLewo_Click);
      // 
      // buttonGora
      // 
      this.buttonGora.Location = new System.Drawing.Point(196, 337);
      this.buttonGora.Name = "buttonGora";
      this.buttonGora.Size = new System.Drawing.Size(75, 23);
      this.buttonGora.TabIndex = 2;
      this.buttonGora.Text = "góra";
      this.buttonGora.UseVisualStyleBackColor = true;
      this.buttonGora.Click += new System.EventHandler(this.buttonGora_Click);
      // 
      // buttonDol
      // 
      this.buttonDol.Location = new System.Drawing.Point(196, 415);
      this.buttonDol.Name = "buttonDol";
      this.buttonDol.Size = new System.Drawing.Size(75, 23);
      this.buttonDol.TabIndex = 3;
      this.buttonDol.Text = "dół";
      this.buttonDol.UseVisualStyleBackColor = true;
      this.buttonDol.Click += new System.EventHandler(this.buttonDol_Click);
      // 
      // buttonPrawo
      // 
      this.buttonPrawo.Location = new System.Drawing.Point(304, 374);
      this.buttonPrawo.Name = "buttonPrawo";
      this.buttonPrawo.Size = new System.Drawing.Size(75, 23);
      this.buttonPrawo.TabIndex = 4;
      this.buttonPrawo.Text = "prawo";
      this.buttonPrawo.UseVisualStyleBackColor = true;
      this.buttonPrawo.Click += new System.EventHandler(this.buttonPrawo_Click);
      // 
      // buttonPoczatek
      // 
      this.buttonPoczatek.Location = new System.Drawing.Point(196, 374);
      this.buttonPoczatek.Name = "buttonPoczatek";
      this.buttonPoczatek.Size = new System.Drawing.Size(75, 23);
      this.buttonPoczatek.TabIndex = 5;
      this.buttonPoczatek.Text = "początek";
      this.buttonPoczatek.UseVisualStyleBackColor = true;
      this.buttonPoczatek.Click += new System.EventHandler(this.buttonPoczatek_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(638, 450);
      this.Controls.Add(this.buttonPoczatek);
      this.Controls.Add(this.buttonPrawo);
      this.Controls.Add(this.buttonDol);
      this.Controls.Add(this.buttonGora);
      this.Controls.Add(this.buttonLewo);
      this.Controls.Add(this.pictureBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private PictureBox pictureBox1;
    private Button buttonLewo;
    private Button buttonGora;
    private Button buttonDol;
    private Button buttonPrawo;
    private Button buttonPoczatek;
  }
}