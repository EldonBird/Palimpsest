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
        inputpathdir = new System.Windows.Forms.TextBox();
        outputpathdir = new System.Windows.Forms.TextBox();
        filesettings = new System.Windows.Forms.GroupBox();
        label3 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        lastgroup = new System.Windows.Forms.GroupBox();
        encryptbutton = new System.Windows.Forms.Button();
        filesettings.SuspendLayout();
        lastgroup.SuspendLayout();
        SuspendLayout();
        //
        // label1
        //
        label1.Location = new System.Drawing.Point(43, 43);
        label1.Margin = new System.Windows.Forms.Padding(46, 0, 46, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(124, 50);
        label1.TabIndex = 0;
        label1.Text = "Input Path (file or folder)";
        label1.Click += label1_Click_1;
        //
        // label2
        //
        label2.Location = new System.Drawing.Point(43, 134);
        label2.Margin = new System.Windows.Forms.Padding(46, 0, 46, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(124, 27);
        label2.TabIndex = 1;
        label2.Text = "Output Path";
        //
        // inputpathdir
        //
        inputpathdir.Location = new System.Drawing.Point(202, 40);
        inputpathdir.Margin = new System.Windows.Forms.Padding(46, 24, 46, 24);
        inputpathdir.Name = "inputpathdir";
        inputpathdir.Size = new System.Drawing.Size(405, 26);
        inputpathdir.TabIndex = 3;
        //
        // outputpathdir
        //
        outputpathdir.Location = new System.Drawing.Point(202, 131);
        outputpathdir.Margin = new System.Windows.Forms.Padding(46, 24, 46, 24);
        outputpathdir.Name = "outputpathdir";
        outputpathdir.Size = new System.Drawing.Size(405, 26);
        outputpathdir.TabIndex = 4;
        //
        // filesettings
        //
        filesettings.BackColor = System.Drawing.SystemColors.MenuBar;
        filesettings.Controls.Add(label3);
        filesettings.Controls.Add(textBox3);
        filesettings.Controls.Add(outputpathdir);
        filesettings.Controls.Add(label1);
        filesettings.Controls.Add(label2);
        filesettings.Controls.Add(inputpathdir);
        filesettings.Location = new System.Drawing.Point(44, 33);
        filesettings.Margin = new System.Windows.Forms.Padding(46, 24, 46, 24);
        filesettings.Name = "filesettings";
        filesettings.Padding = new System.Windows.Forms.Padding(46, 24, 46, 24);
        filesettings.Size = new System.Drawing.Size(859, 207);
        filesettings.TabIndex = 6;
        filesettings.TabStop = false;
        filesettings.Text = "File Settings";
        //
        // label3
        //
        label3.Location = new System.Drawing.Point(661, 40);
        label3.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(150, 39);
        label3.TabIndex = 6;
        label3.Text = "Extention";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label3.Click += label3_Click;
        //
        // textBox3
        //
        textBox3.Location = new System.Drawing.Point(661, 128);
        textBox3.Margin = new System.Windows.Forms.Padding(46, 24, 46, 24);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(150, 26);
        textBox3.TabIndex = 5;
        textBox3.Text = ".txt";
        //
        // groupBox1
        //
        groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
        groupBox1.Location = new System.Drawing.Point(44, 257);
        groupBox1.Margin = new System.Windows.Forms.Padding(46, 24, 46, 24);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new System.Windows.Forms.Padding(46, 24, 46, 24);
        groupBox1.Size = new System.Drawing.Size(607, 272);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "Encryption and Decryption";
        //
        // lastgroup
        //
        lastgroup.BackColor = System.Drawing.SystemColors.MenuBar;
        lastgroup.Controls.Add(encryptbutton);
        lastgroup.Location = new System.Drawing.Point(680, 257);
        lastgroup.Margin = new System.Windows.Forms.Padding(46, 24, 46, 24);
        lastgroup.Name = "lastgroup";
        lastgroup.Padding = new System.Windows.Forms.Padding(46, 24, 46, 24);
        lastgroup.Size = new System.Drawing.Size(223, 272);
        lastgroup.TabIndex = 8;
        lastgroup.TabStop = false;
        lastgroup.Text = "Last Step";
        //
        // encryptbutton
        //
        encryptbutton.Location = new System.Drawing.Point(25, 206);
        encryptbutton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
        encryptbutton.Name = "encryptbutton";
        encryptbutton.Size = new System.Drawing.Size(154, 35);
        encryptbutton.TabIndex = 1;
        encryptbutton.Text = "Encrypt";
        encryptbutton.UseVisualStyleBackColor = true;
        encryptbutton.Click += encryptbutton_Click;
        //
        // Palimpsest
        //
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Window;
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        ClientSize = new System.Drawing.Size(944, 541);
        Controls.Add(lastgroup);
        Controls.Add(groupBox1);
        Controls.Add(filesettings);
        Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        HelpButton = true;
        Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        RightToLeft = System.Windows.Forms.RightToLeft.No;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Palimpsest";
        filesettings.ResumeLayout(false);
        filesettings.PerformLayout();
        lastgroup.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button encryptbutton;

    private System.Windows.Forms.GroupBox lastgroup;

    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.GroupBox filesettings;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TextBox inputpathdir;
    private System.Windows.Forms.TextBox outputpathdir;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}