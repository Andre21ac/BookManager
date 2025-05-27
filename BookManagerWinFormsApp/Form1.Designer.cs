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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // BookList
            // 
            BookList.FormattingEnabled = true;
            BookList.ItemHeight = 15;
            BookList.Location = new Point(12, 12);
            BookList.Name = "BookList";
            BookList.Size = new Size(221, 544);
            BookList.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(22, 35);
            button1.Name = "button1";
            button1.Size = new Size(190, 39);
            button1.TabIndex = 1;
            button1.Text = "Listar Livros";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(22, 95);
            button2.Name = "button2";
            button2.Size = new Size(190, 39);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 570);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BookList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            ResumeLayout(false);
        }

        #endregion

        private ListBox BookList;
        private Button button1;
        private Button button2;
    }
}
