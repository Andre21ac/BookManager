namespace BookManagerWinFormsApp
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            BookList = new ListBox();
            btn_AdicionarLivro = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            tbl_titulo = new DataGridViewTextBoxColumn();
            tbl_autor = new DataGridViewTextBoxColumn();
            tbl_genero = new DataGridViewTextBoxColumn();
            lbl_pesquisaTitulo = new Label();
            textBox1 = new TextBox();
            btn_Buscar = new Button();
            groupBox2 = new GroupBox();
            lbl_AnoPublicacao = new Label();
            lbl_AutorLivro = new Label();
            lbl_TituloLivro = new Label();
            label3 = new Label();
            label2 = new Label();
            lbl2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BookList
            // 
            BookList.FormattingEnabled = true;
            BookList.ItemHeight = 15;
            BookList.Location = new Point(12, 27);
            BookList.Name = "BookList";
            BookList.Size = new Size(221, 529);
            BookList.TabIndex = 0;
            // 
            // btn_AdicionarLivro
            // 
            btn_AdicionarLivro.BackColor = SystemColors.Control;
            btn_AdicionarLivro.Location = new Point(25, 49);
            btn_AdicionarLivro.Name = "btn_AdicionarLivro";
            btn_AdicionarLivro.Size = new Size(190, 39);
            btn_AdicionarLivro.TabIndex = 2;
            btn_AdicionarLivro.Text = "Adicionar Livro";
            btn_AdicionarLivro.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(250, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 496);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de livros";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tbl_titulo, tbl_autor, tbl_genero });
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 452);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tbl_titulo
            // 
            tbl_titulo.HeaderText = "Título";
            tbl_titulo.Name = "tbl_titulo";
            tbl_titulo.ReadOnly = true;
            // 
            // tbl_autor
            // 
            tbl_autor.HeaderText = "Autor";
            tbl_autor.Name = "tbl_autor";
            tbl_autor.ReadOnly = true;
            // 
            // tbl_genero
            // 
            tbl_genero.HeaderText = "Gênero";
            tbl_genero.Name = "tbl_genero";
            tbl_genero.ReadOnly = true;
            // 
            // lbl_pesquisaTitulo
            // 
            lbl_pesquisaTitulo.AutoSize = true;
            lbl_pesquisaTitulo.Location = new Point(250, 35);
            lbl_pesquisaTitulo.Name = "lbl_pesquisaTitulo";
            lbl_pesquisaTitulo.Size = new Size(140, 15);
            lbl_pesquisaTitulo.TabIndex = 4;
            lbl_pesquisaTitulo.Text = "Procurar por título/autor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(441, 23);
            textBox1.TabIndex = 5;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.White;
            btn_Buscar.Location = new Point(856, 32);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 6;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbl_AnoPublicacao);
            groupBox2.Controls.Add(lbl_AutorLivro);
            groupBox2.Controls.Add(lbl_TituloLivro);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lbl2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(615, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 494);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalhes do livro";
            // 
            // lbl_AnoPublicacao
            // 
            lbl_AnoPublicacao.AutoSize = true;
            lbl_AnoPublicacao.Location = new Point(78, 362);
            lbl_AnoPublicacao.Name = "lbl_AnoPublicacao";
            lbl_AnoPublicacao.Size = new Size(16, 15);
            lbl_AnoPublicacao.TabIndex = 6;
            lbl_AnoPublicacao.Text = "...";
            lbl_AnoPublicacao.Click += lbl_AnoPublicacao_Click;
            // 
            // lbl_AutorLivro
            // 
            lbl_AutorLivro.AutoSize = true;
            lbl_AutorLivro.Location = new Point(70, 332);
            lbl_AutorLivro.Name = "lbl_AutorLivro";
            lbl_AutorLivro.Size = new Size(16, 15);
            lbl_AutorLivro.TabIndex = 5;
            lbl_AutorLivro.Text = "...";
            lbl_AutorLivro.Click += lbl_AutorLivro_Click;
            // 
            // lbl_TituloLivro
            // 
            lbl_TituloLivro.AutoSize = true;
            lbl_TituloLivro.Location = new Point(71, 303);
            lbl_TituloLivro.Name = "lbl_TituloLivro";
            lbl_TituloLivro.Size = new Size(16, 15);
            lbl_TituloLivro.TabIndex = 4;
            lbl_TituloLivro.Text = "...";
            lbl_TituloLivro.Click += lbl_TituloLivro_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 362);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 3;
            label3.Text = "Gênero:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 332);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Autor:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(27, 303);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(40, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "Título:";
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://carrefourbr.vtexassets.com/arquivos/ids/145472507/d9f39c167c0b4d3ea251a68e644e7890.jpg?v=638510692154200000";
            pictureBox1.Location = new Point(21, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(963, 570);
            Controls.Add(groupBox2);
            Controls.Add(btn_Buscar);
            Controls.Add(textBox1);
            Controls.Add(lbl_pesquisaTitulo);
            Controls.Add(groupBox1);
            Controls.Add(btn_AdicionarLivro);
            Controls.Add(BookList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox BookList;
        private Button btn_AdicionarLivro;
        private GroupBox groupBox1;
        private Label lbl_pesquisaTitulo;
        private TextBox textBox1;
        private Button btn_Buscar;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label lbl2;
        private Label lbl_AnoPublicacao;
        private Label lbl_AutorLivro;
        private Label lbl_TituloLivro;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tbl_titulo;
        private DataGridViewTextBoxColumn tbl_autor;
        private DataGridViewTextBoxColumn tbl_genero;
    }
}
