namespace Palimpsest;

public partial class Palimpsest : Form {
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
        throw new System.NotImplementedException();
    }

    private void button1_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void encryptbutton_Click(object sender, EventArgs e) {

        string inputdir = inputpathdir.Text;
        string outputdir = outputpathdir.Text;

        Methods method = new Methods();

        method.BeginEncryption(inputdir, outputdir, 1);



    }
}