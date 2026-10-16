namespace QeydlerDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            lblCharCount.Text = "Simvol sayı: " + rtbText.Text.Length;
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sriftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbText.Font = fontDialog1.Font;
            }
        }

        private void rengToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbText.ForeColor = colorDialog1.Color;
            }
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbText.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void saxlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, rtbText.Text);
            }
        }

        private void yeniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        private void cixisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
