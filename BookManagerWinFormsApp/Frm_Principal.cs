namespace BookManagerWinFormsApp
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_AutorLivro_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TituloLivro_Click(object sender, EventArgs e)
        {
            lbl_TituloLivro.Text = "Harry Potter e a pedra filosofal";
            lbl_AnoPublicacao.Text = "1997";
            lbl_AutorLivro.Text = "J.K. Rowling";
            pictureBox1.ImageLocation = "https://a-static.mlcdn.com.br/1500x1500/livro-harry-potter-e-a-pedra-filosofal/magazineluiza/223260000/5e0050418707cbd107d78d3af402b1c0.jpg";
        }
    }
}
