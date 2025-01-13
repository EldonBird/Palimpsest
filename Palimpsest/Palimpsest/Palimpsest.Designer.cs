namespace Palimpsest;

partial class Palimpsest {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        filesettings = new System.Windows.Forms.GroupBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        filesettings.SuspendLayout();
        SuspendLayout();
        //
        // label1
        //
        label1.Location = new System.Drawing.Point(23, 34);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(103, 49);
        label1.TabIndex = 0;
        label1.Text = "Input Path (file or folder)";
        label1.Click += label1_Click_1;
        //
        // label2
        //
        label2.Location = new System.Drawing.Point(23, 83);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(103, 22);
        label2.TabIndex = 1;
        label2.Text = "Output Path";
        //
        // textBox1
        //
        textBox1.Location = new System.Drawing.Point(140, 37);
        textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(586, 26);
        textBox1.TabIndex = 3;
        //
        // textBox2
        //
        textBox2.Location = new System.Drawing.Point(138, 82);
        textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(588, 26);
        textBox2.TabIndex = 4;
        //
        // filesettings
        //
        filesettings.Controls.Add(textBox2);
        filesettings.Controls.Add(label1);
        filesettings.Controls.Add(label2);
        filesettings.Controls.Add(textBox1);
        filesettings.Location = new System.Drawing.Point(15, 25);
        filesettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        filesettings.Name = "filesettings";
        filesettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
        filesettings.Size = new System.Drawing.Size(931, 158);
        filesettings.TabIndex = 6;
        filesettings.TabStop = false;
        filesettings.Text = "File Settings";
        //
        // groupBox1
        //
        groupBox1.Location = new System.Drawing.Point(23, 232);
        groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
        groupBox1.Size = new System.Drawing.Size(986, 232);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "Encryption and Decryption";
        //
        // Palimpsest
        //
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.MenuHighlight;
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        ClientSize = new System.Drawing.Size(1209, 516);
        Controls.Add(groupBox1);
        Controls.Add(filesettings);
        Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        HelpButton = true;
        Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        RightToLeft = System.Windows.Forms.RightToLeft.No;
        Text = "Palimpsest";
        filesettings.ResumeLayout(false);
        filesettings.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.GroupBox filesettings;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}