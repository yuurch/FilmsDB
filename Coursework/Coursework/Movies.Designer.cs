namespace Coursework
{
    partial class Movies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movieexit = new System.Windows.Forms.Button();
            this.genre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.film = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datafilm = new System.Windows.Forms.DataGridView();
            this.editmovie = new System.Windows.Forms.Button();
            this.delmovie = new System.Windows.Forms.Button();
            this.movieadd = new System.Windows.Forms.Button();
            this.actorname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datafilm)).BeginInit();
            this.SuspendLayout();
            // 
            // movieexit
            // 
            this.movieexit.AccessibleDescription = "";
            this.movieexit.Location = new System.Drawing.Point(514, 532);
            this.movieexit.Name = "movieexit";
            this.movieexit.Size = new System.Drawing.Size(143, 46);
            this.movieexit.TabIndex = 23;
            this.movieexit.Text = "Головне Меню";
            this.movieexit.UseVisualStyleBackColor = true;
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(35, 168);
            this.genre.Multiline = true;
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(243, 39);
            this.genre.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(74, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 38);
            this.label2.TabIndex = 21;
            this.label2.Text = "Дата Релiзу";
            // 
            // film
            // 
            this.film.Location = new System.Drawing.Point(35, 67);
            this.film.Multiline = true;
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(243, 39);
            this.film.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Заголовок";
            // 
            // datafilm
            // 
            this.datafilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datafilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datafilm.Location = new System.Drawing.Point(47, 484);
            this.datafilm.Name = "datafilm";
            this.datafilm.RowTemplate.Height = 25;
            this.datafilm.Size = new System.Drawing.Size(692, 203);
            this.datafilm.TabIndex = 18;
            // 
            // editmovie
            // 
            this.editmovie.AccessibleDescription = "";
            this.editmovie.Location = new System.Drawing.Point(618, 204);
            this.editmovie.Name = "editmovie";
            this.editmovie.Size = new System.Drawing.Size(143, 46);
            this.editmovie.TabIndex = 17;
            this.editmovie.Text = "Замiнити";
            this.editmovie.UseVisualStyleBackColor = true;
            // 
            // delmovie
            // 
            this.delmovie.Location = new System.Drawing.Point(618, 130);
            this.delmovie.Name = "delmovie";
            this.delmovie.Size = new System.Drawing.Size(143, 46);
            this.delmovie.TabIndex = 16;
            this.delmovie.Text = "Видалити";
            this.delmovie.UseVisualStyleBackColor = true;
            // 
            // movieadd
            // 
            this.movieadd.Location = new System.Drawing.Point(618, 60);
            this.movieadd.Name = "movieadd";
            this.movieadd.Size = new System.Drawing.Size(143, 46);
            this.movieadd.TabIndex = 15;
            this.movieadd.Text = "Додати";
            this.movieadd.UseVisualStyleBackColor = true;
            // 
            // actorname
            // 
            this.actorname.Location = new System.Drawing.Point(305, 168);
            this.actorname.Multiline = true;
            this.actorname.Name = "actorname";
            this.actorname.Size = new System.Drawing.Size(243, 39);
            this.actorname.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(396, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "Опис";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 39);
            this.textBox1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(376, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 38);
            this.label4.TabIndex = 26;
            this.label4.Text = "Рейтинг";
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(618, 282);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(143, 46);
            this.menu.TabIndex = 28;
            this.menu.Text = "Головне Меню";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(26)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 729);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.actorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.film);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datafilm);
            this.Controls.Add(this.editmovie);
            this.Controls.Add(this.delmovie);
            this.Controls.Add(this.movieadd);
            this.Controls.Add(this.movieexit);
            this.Name = "Movies";
            this.Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)(this.datafilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button menu;
        private TextBox genre;
        private Label label2;
        private TextBox film;
        private Label label1;
        private DataGridView dataGridView1;
        private Button editmovie;
        private Button delmovie;
        private Button movieadd;
        private Button movieexit;
        private DataGridView datafilm;
        private TextBox actorname;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
    }
}