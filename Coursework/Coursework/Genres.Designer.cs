namespace Coursework
{
    partial class Genres
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
            this.genren = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagenres = new System.Windows.Forms.DataGridView();
            this.ggenres = new System.Windows.Forms.Button();
            this.editge = new System.Windows.Forms.Button();
            this.delge = new System.Windows.Forms.Button();
            this.gadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagenres)).BeginInit();
            this.SuspendLayout();
            // 
            // genren
            // 
            this.genren.Location = new System.Drawing.Point(57, 82);
            this.genren.Multiline = true;
            this.genren.Name = "genren";
            this.genren.Size = new System.Drawing.Size(243, 39);
            this.genren.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(127, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "Жанри";
            // 
            // datagenres
            // 
            this.datagenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagenres.Location = new System.Drawing.Point(57, 398);
            this.datagenres.Name = "datagenres";
            this.datagenres.RowTemplate.Height = 25;
            this.datagenres.Size = new System.Drawing.Size(478, 189);
            this.datagenres.TabIndex = 27;
            this.datagenres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagenres_CellContentClick);
            // 
            // ggenres
            // 
            this.ggenres.AccessibleDescription = "";
            this.ggenres.Location = new System.Drawing.Point(392, 234);
            this.ggenres.Name = "ggenres";
            this.ggenres.Size = new System.Drawing.Size(143, 46);
            this.ggenres.TabIndex = 26;
            this.ggenres.Text = "Головне меню";
            this.ggenres.UseVisualStyleBackColor = true;
            this.ggenres.Click += new System.EventHandler(this.ggenres_Click);
            // 
            // editge
            // 
            this.editge.AccessibleDescription = "";
            this.editge.Location = new System.Drawing.Point(392, 165);
            this.editge.Name = "editge";
            this.editge.Size = new System.Drawing.Size(143, 46);
            this.editge.TabIndex = 25;
            this.editge.Text = "Замiнити";
            this.editge.UseVisualStyleBackColor = true;
            // 
            // delge
            // 
            this.delge.Location = new System.Drawing.Point(392, 93);
            this.delge.Name = "delge";
            this.delge.Size = new System.Drawing.Size(143, 46);
            this.delge.TabIndex = 24;
            this.delge.Text = "Видалити";
            this.delge.UseVisualStyleBackColor = true;
            // 
            // gadd
            // 
            this.gadd.Location = new System.Drawing.Point(392, 24);
            this.gadd.Name = "gadd";
            this.gadd.Size = new System.Drawing.Size(143, 46);
            this.gadd.TabIndex = 23;
            this.gadd.Text = "Додати";
            this.gadd.UseVisualStyleBackColor = true;
            // 
            // Genres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(26)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(593, 607);
            this.Controls.Add(this.genren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagenres);
            this.Controls.Add(this.ggenres);
            this.Controls.Add(this.editge);
            this.Controls.Add(this.delge);
            this.Controls.Add(this.gadd);
            this.Name = "Genres";
            this.Text = "Genres";
            ((System.ComponentModel.ISupportInitialize)(this.datagenres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox genren;
        private Label label1;
        private DataGridView datagenres;
        private Button ggenres;
        private Button editge;
        private Button delge;
        private Button gadd;
    }
}