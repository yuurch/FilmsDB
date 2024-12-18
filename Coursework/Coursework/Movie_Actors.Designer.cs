namespace Coursework
{
    partial class Movie_Actors
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
            this.actoadd = new System.Windows.Forms.Button();
            this.delac = new System.Windows.Forms.Button();
            this.editac = new System.Windows.Forms.Button();
            this.menum = new System.Windows.Forms.Button();
            this.magrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.actorbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.magrid)).BeginInit();
            this.SuspendLayout();
            // 
            // actoadd
            // 
            this.actoadd.Location = new System.Drawing.Point(391, 31);
            this.actoadd.Name = "actoadd";
            this.actoadd.Size = new System.Drawing.Size(139, 58);
            this.actoadd.TabIndex = 0;
            this.actoadd.Text = "Додати";
            this.actoadd.UseVisualStyleBackColor = true;
            this.actoadd.Click += new System.EventHandler(this.actoadd_Click);
            // 
            // delac
            // 
            this.delac.Location = new System.Drawing.Point(391, 114);
            this.delac.Name = "delac";
            this.delac.Size = new System.Drawing.Size(139, 58);
            this.delac.TabIndex = 1;
            this.delac.Text = "Видалити";
            this.delac.UseVisualStyleBackColor = true;
            // 
            // editac
            // 
            this.editac.Location = new System.Drawing.Point(391, 197);
            this.editac.Name = "editac";
            this.editac.Size = new System.Drawing.Size(139, 58);
            this.editac.TabIndex = 2;
            this.editac.Text = "Замiнити";
            this.editac.UseVisualStyleBackColor = true;
            // 
            // menum
            // 
            this.menum.Location = new System.Drawing.Point(391, 280);
            this.menum.Name = "menum";
            this.menum.Size = new System.Drawing.Size(139, 58);
            this.menum.TabIndex = 3;
            this.menum.Text = "Головне меню";
            this.menum.UseVisualStyleBackColor = true;
            this.menum.Click += new System.EventHandler(this.menum_Click);
            // 
            // magrid
            // 
            this.magrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.magrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.magrid.Location = new System.Drawing.Point(13, 357);
            this.magrid.Name = "magrid";
            this.magrid.RowTemplate.Height = 25;
            this.magrid.Size = new System.Drawing.Size(518, 231);
            this.magrid.TabIndex = 4;
            this.magrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.magrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(68, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Актор";
            // 
            // actorbox
            // 
            this.actorbox.Location = new System.Drawing.Point(13, 92);
            this.actorbox.Multiline = true;
            this.actorbox.Name = "actorbox";
            this.actorbox.Size = new System.Drawing.Size(220, 62);
            this.actorbox.TabIndex = 8;
            // 
            // Movie_Actors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(26)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(543, 611);
            this.Controls.Add(this.actorbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.magrid);
            this.Controls.Add(this.menum);
            this.Controls.Add(this.editac);
            this.Controls.Add(this.delac);
            this.Controls.Add(this.actoadd);
            this.Name = "Movie_Actors";
            this.Text = "Movie_Actors";
            ((System.ComponentModel.ISupportInitialize)(this.magrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button actoadd;
        private Button delac;
        private Button editac;
        private Button menum;
        private DataGridView magrid;
        private Label label1;
        private Label label2;
        private TextBox moviebox;
        private TextBox actorbox;
    }
}