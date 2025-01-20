using System.Text;

namespace Palimpsest;

public partial class Palimpsest : Form {

    private String SelectedFile = "";

    public Palimpsest() {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void label1_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void Palimpsest_Load(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void label1_Click_1(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void label3_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e) {
        //throw new System.NotImplementedException();
    }

    private void decryptradio_CheckedChanged(object sender, EventArgs e) {

    }

    private void fileselectbutton_Click(object sender, EventArgs e) {

        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Select a file";
        //openFileDialog.InitialDirectory = "c:\\";
        openFileDialog.Filter = "All files (*.*)|*.*";
        openFileDialog.FilterIndex = 1;
        openFileDialog.ShowDialog();
        if (openFileDialog.FileName != "") {
            selectedfiletb.Text = openFileDialog.FileName;
            SelectedFile = openFileDialog.FileName;
        }
        else {
        }
    }

    private void WritetoFile(String dir, String output) {

        using (Stream s = File.Open(dir, FileMode.Create))
        using (StreamWriter sw = new StreamWriter(s)) {
            sw.Write(output);
        }

    }


    private void Begin(object sender, EventArgs e) {

        if (encryptradio.Checked) {
            saveFileDialog.Filter = "Encrypted File Format|*.palm";
        }


        if (saveFileDialog.ShowDialog() == DialogResult.OK) {


            if (decryptradio.Checked) {

                String tmp = Methods.BeginDecryption(SelectedFile, int.Parse(keyvalue.Text), true);
                WritetoFile(saveFileDialog.FileName, tmp);


            }

            if (encryptradio.Checked) {

                String tmp = Methods.Encrypt(SelectedFile, "Temp");
                WritetoFile(saveFileDialog.FileName, tmp);

            }

        }
    }

    private void offsetoption_CheckedChanged(object sender, EventArgs e) {
        //throw new System.NotImplementedException();
    }

    private void encryptradio_CheckedChanged(object sender, EventArgs e) {
        //throw new System.NotImplementedException();
    }
}