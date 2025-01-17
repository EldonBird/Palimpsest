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
        filesettings = new System.Windows.Forms.GroupBox();
        selectedfiletb = new System.Windows.Forms.TextBox();
        fileselectbutton = new System.Windows.Forms.Button();
        groupBox1 = new System.Windows.Forms.GroupBox();
        keyvalue = new System.Windows.Forms.TextBox();
        keyoption = new System.Windows.Forms.CheckBox();
        encryptradio = new System.Windows.Forms.RadioButton();
        decryptradio = new System.Windows.Forms.RadioButton();
        gobutton = new System.Windows.Forms.Button();
        saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        filesettings.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // filesettings
        // 
        filesettings.BackColor = System.Drawing.SystemColors.MenuBar;
        filesettings.Controls.Add(selectedfiletb);
        filesettings.Controls.Add(fileselectbutton);
        filesettings.Location = new System.Drawing.Point(19, 33);
        filesettings.Margin = new System.Windows.Forms.Padding(162, 140, 162, 140);
        filesettings.Name = "filesettings";
        filesettings.Padding = new System.Windows.Forms.Padding(162, 140, 162, 140);
        filesettings.Size = new System.Drawing.Size(427, 82);
        filesettings.TabIndex = 6;
        filesettings.TabStop = false;
        filesettings.Text = "File Settings";
        // 
        // selectedfiletb
        // 
        selectedfiletb.Location = new System.Drawing.Point(138, 35);
        selectedfiletb.Margin = new System.Windows.Forms.Padding(5);
        selectedfiletb.Name = "selectedfiletb";
        selectedfiletb.Size = new System.Drawing.Size(268, 22);
        selectedfiletb.TabIndex = 3;
        // 
        // fileselectbutton
        // 
        fileselectbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        fileselectbutton.Location = new System.Drawing.Point(27, 35);
        fileselectbutton.Margin = new System.Windows.Forms.Padding(6);
        fileselectbutton.Name = "fileselectbutton";
        fileselectbutton.Size = new System.Drawing.Size(100, 22);
        fileselectbutton.TabIndex = 2;
        fileselectbutton.Text = "Select File";
        fileselectbutton.UseVisualStyleBackColor = true;
        fileselectbutton.Click += fileselectbutton_Click;
        // 
        // groupBox1
        // 
        groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
        groupBox1.Controls.Add(keyvalue);
        groupBox1.Controls.Add(decryptradio);
        groupBox1.Controls.Add(keyoption);
        groupBox1.Controls.Add(encryptradio);
        groupBox1.Location = new System.Drawing.Point(19, 133);
        groupBox1.Margin = new System.Windows.Forms.Padding(162, 140, 162, 140);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new System.Windows.Forms.Padding(162, 140, 162, 140);
        groupBox1.Size = new System.Drawing.Size(231, 137);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "Encryption and Decryption";
        // 
        // keyvalue
        // 
        keyvalue.Location = new System.Drawing.Point(80, 34);
        keyvalue.Name = "keyvalue";
        keyvalue.Size = new System.Drawing.Size(138, 22);
        keyvalue.TabIndex = 6;
        // 
        // keyoption
        // 
        keyoption.Location = new System.Drawing.Point(11, 34);
        keyoption.Name = "keyoption";
        keyoption.Size = new System.Drawing.Size(122, 22);
        keyoption.TabIndex = 4;
        keyoption.Text = "Key";
        keyoption.UseVisualStyleBackColor = true;
        keyoption.CheckedChanged += offsetoption_CheckedChanged;
        // 
        // encryptradio
        // 
        encryptradio.Location = new System.Drawing.Point(27, 76);
        encryptradio.Name = "encryptradio";
        encryptradio.Size = new System.Drawing.Size(79, 34);
        encryptradio.TabIndex = 4;
        encryptradio.TabStop = true;
        encryptradio.Text = "Encrypt";
        encryptradio.UseVisualStyleBackColor = true;
        encryptradio.CheckedChanged += encryptradio_CheckedChanged;
        // 
        // decryptradio
        // 
        decryptradio.Location = new System.Drawing.Point(128, 76);
        decryptradio.Name = "decryptradio";
        decryptradio.Size = new System.Drawing.Size(71, 34);
        decryptradio.TabIndex = 5;
        decryptradio.TabStop = true;
        decryptradio.Text = "Decrypt";
        decryptradio.UseVisualStyleBackColor = true;
        decryptradio.CheckedChanged += decryptradio_CheckedChanged;
        // 
        // gobutton
        // 
        gobutton.Location = new System.Drawing.Point(279, 195);
        gobutton.Name = "gobutton";
        gobutton.Size = new System.Drawing.Size(146, 62);
        gobutton.TabIndex = 6;
        gobutton.Text = "Start";
        gobutton.UseVisualStyleBackColor = true;
        gobutton.Click += Begin;
        // 
        // saveFileDialog
        // 
        saveFileDialog.FileName = "output";
        saveFileDialog.Filter = "Text File|*.txt";
        // 
        // Palimpsest
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Window;
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        ClientSize = new System.Drawing.Size(469, 295);
        Controls.Add(gobutton);
        Controls.Add(groupBox1);
        Controls.Add(filesettings);
        Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        HelpButton = true;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        RightToLeft = System.Windows.Forms.RightToLeft.No;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Palimpsest";
        filesettings.ResumeLayout(false);
        filesettings.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.SaveFileDialog saveFileDialog;

    private System.Windows.Forms.CheckBox keyoption;
    private System.Windows.Forms.Button gobutton;

    private System.Windows.Forms.RadioButton encryptradio;
    private System.Windows.Forms.RadioButton decryptradio;

    private System.Windows.Forms.TextBox selectedfiletb;

    private System.Windows.Forms.TextBox keyvalue;

    private System.Windows.Forms.Button fileselectbutton;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.GroupBox filesettings;

    private System.Windows.Forms.Panel panel1;

    #endregion
}