namespace Coursework
{
    partial class TVSeries
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
            this.label1 = new System.Windows.Forms.Label();
            this.movieadd = new System.Windows.Forms.Button();
            this.delmovie = new System.Windows.Forms.Button();
            this.editmovie = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.film = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.TextBox();
            this.sdata = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(87, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Заголовок";
            // 
            // movieadd
            // 
            this.movieadd.Location = new System.Drawing.Point(346, 63);
            this.movieadd.Name = "movieadd";
            this.movieadd.Size = new System.Drawing.Size(143, 46);
            this.movieadd.TabIndex = 15;
            this.movieadd.Text = "Додати";
            this.movieadd.UseVisualStyleBackColor = true;
            // 
            // delmovie
            // 
            this.delmovie.Location = new System.Drawing.Point(346, 132);
            this.delmovie.Name = "delmovie";
            this.delmovie.Size = new System.Drawing.Size(143, 46);
            this.delmovie.TabIndex = 16;
            this.delmovie.Text = "Видалити";
            this.delmovie.UseVisualStyleBackColor = true;
            // 
            // editmovie
            // 
            this.editmovie.AccessibleDescription = "";
            this.editmovie.Location = new System.Drawing.Point(346, 204);
            this.editmovie.Name = "editmovie";
            this.editmovie.Size = new System.Drawing.Size(143, 46);
            this.editmovie.TabIndex = 17;
            this.editmovie.Text = "Замiнити";
            this.editmovie.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.AccessibleDescription = "";
            this.menu.Location = new System.Drawing.Point(346, 281);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(143, 46);
            this.menu.TabIndex = 23;
            this.menu.Text = "Головне Меню";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // film
            // 
            this.film.Location = new System.Drawing.Point(31, 63);
            this.film.Multiline = true;
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(243, 39);
            this.film.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(74, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 38);
            this.label2.TabIndex = 21;
            this.label2.Text = "Дата Релiзу";
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(31, 161);
            this.genre.Multiline = true;
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(243, 39);
            this.genre.TabIndex = 22;
            // 
            // sdata
            // 
            this.sdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sdata.Location = new System.Drawing.Point(31, 487);
            this.sdata.Name = "sdata";
            this.sdata.RowTemplate.Height = 25;
            this.sdata.Size = new System.Drawing.Size(478, 189);
            this.sdata.TabIndex = 18;
            this.sdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sdata_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 370);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 39);
            this.textBox1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(107, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "Опис";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 257);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 39);
            this.textBox2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(107, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 38);
            this.label4.TabIndex = 26;
            this.label4.Text = "Сезон";
            // 
            // TVSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(26)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(549, 738);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.film);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdata);
            this.Controls.Add(this.editmovie);
            this.Controls.Add(this.delmovie);
            this.Controls.Add(this.movieadd);
            this.Name = "TVSeries";
            this.Text = "TVSeries";
            ((System.ComponentModel.ISupportInitialize)(this.sdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button movieadd;
        private Button delmovie;
        private Button editmovie;
        private Button menu;
        private TextBox film;
        private Label label2;
        private TextBox genre;
        private DataGridView sdata;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}