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
            lbl_pesquisaTitulo = new Label();
            textBox1 = new TextBox();
            btn_Buscar = new Button();
            groupBox2 = new GroupBox();
            lbl2 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            lbl_TituloLivro = new Label();
            lbl_AutorLivro = new Label();
            lbl_AnoPublicacao = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BookList
            // 
            BookList.FormattingEnabled = true;
            BookList.Location = new Point(14, 36);
            BookList.Margin = new Padding(3, 4, 3, 4);
            BookList.Name = "BookList";
            BookList.Size = new Size(252, 704);
            BookList.TabIndex = 0;
            // 
            // btn_AdicionarLivro
            // 
            btn_AdicionarLivro.BackColor = SystemColors.Control;
            btn_AdicionarLivro.Location = new Point(29, 65);
            btn_AdicionarLivro.Margin = new Padding(3, 4, 3, 4);
            btn_AdicionarLivro.Name = "btn_AdicionarLivro";
            btn_AdicionarLivro.Size = new Size(217, 52);
            btn_AdicionarLivro.TabIndex = 2;
            btn_AdicionarLivro.Text = "Adicionar Livro";
            btn_AdicionarLivro.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(286, 79);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(400, 661);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lbl_pesquisaTitulo
            // 
            lbl_pesquisaTitulo.AutoSize = true;
            lbl_pesquisaTitulo.Location = new Point(286, 47);
            lbl_pesquisaTitulo.Name = "lbl_pesquisaTitulo";
            lbl_pesquisaTitulo.Size = new Size(174, 20);
            lbl_pesquisaTitulo.TabIndex = 4;
            lbl_pesquisaTitulo.Text = "Procurar por título/autor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(453, 43);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(503, 27);
            textBox1.TabIndex = 5;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.White;
            btn_Buscar.Location = new Point(978, 43);
            btn_Buscar.Margin = new Padding(3, 4, 3, 4);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(86, 31);
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
            groupBox2.Location = new Point(703, 81);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(371, 659);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(31, 404);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(50, 20);
            lbl2.TabIndex = 1;
            lbl2.Text = "Título:";
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://carrefourbr.vtexassets.com/arquivos/ids/145472507/d9f39c167c0b4d3ea251a68e644e7890.jpg?v=638510692154200000";
            pictureBox1.Location = new Point(24, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 442);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 482);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 3;
            label3.Text = "Ano de publicação:";
            label3.Click += label3_Click;
            // 
            // lbl_TituloLivro
            // 
            lbl_TituloLivro.AutoSize = true;
            lbl_TituloLivro.Location = new Point(87, 404);
            lbl_TituloLivro.Name = "lbl_TituloLivro";
            lbl_TituloLivro.Size = new Size(18, 20);
            lbl_TituloLivro.TabIndex = 4;
            lbl_TituloLivro.Text = "...";
            lbl_TituloLivro.Click += lbl_TituloLivro_Click;
            // 
            // lbl_AutorLivro
            // 
            lbl_AutorLivro.AutoSize = true;
            lbl_AutorLivro.Location = new Point(83, 442);
            lbl_AutorLivro.Name = "lbl_AutorLivro";
            lbl_AutorLivro.Size = new Size(18, 20);
            lbl_AutorLivro.TabIndex = 5;
            lbl_AutorLivro.Text = "...";
            lbl_AutorLivro.Click += lbl_AutorLivro_Click;
            // 
            // lbl_AnoPublicacao
            // 
            lbl_AnoPublicacao.AutoSize = true;
            lbl_AnoPublicacao.Location = new Point(166, 482);
            lbl_AnoPublicacao.Name = "lbl_AnoPublicacao";
            lbl_AnoPublicacao.Size = new Size(18, 20);
            lbl_AnoPublicacao.TabIndex = 6;
            lbl_AnoPublicacao.Text = "...";
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1101, 760);
            Controls.Add(groupBox2);
            Controls.Add(btn_Buscar);
            Controls.Add(textBox1);
            Controls.Add(lbl_pesquisaTitulo);
            Controls.Add(groupBox1);
            Controls.Add(btn_AdicionarLivro);
            Controls.Add(BookList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
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
    }
}
