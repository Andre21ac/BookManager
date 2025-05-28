using BookManagerConsoleApp.Entities;
using BookManagerConsoleApp.Infraestructure;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Diagnostics;

namespace BookManagerWinFormsApp
{
    public partial class Frm_Principal : Form
    {

        public Frm_Principal()
        {
            InitializeComponent();

            using var dbContext = new SqliteDbContext();
            dbContext.Database.EnsureCreated();

            CarregarLivros();
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
            lbl_AnoPublicacao.Text = "Fantasia";
            lbl_AutorLivro.Text = "J.K. Rowling";
            pictureBox1.ImageLocation = "https://a-static.mlcdn.com.br/1500x1500/livro-harry-potter-e-a-pedra-filosofal/magazineluiza/223260000/5e0050418707cbd107d78d3af402b1c0.jpg";
        }

        private void lbl_AnoPublicacao_Click(object sender, EventArgs e)
        {

        }

        private void CarregarLivros()
        {
            using var context = new SqliteDbContext();
            var listaLivros = context.Books.ToList();

            //int i = 0;

            foreach (var book in listaLivros)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = book.Title;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = book.Author;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = book.Genre;
                //dataGridView1.Rows.Add(); 
                Debug.WriteLine(dataGridView1.Rows.Count);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
