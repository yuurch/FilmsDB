namespace Coursework
{
    partial class TVSeries_Actors
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
            this.actor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.series = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datatv = new System.Windows.Forms.DataGridView();
            this.gtv = new System.Windows.Forms.Button();
            this.edittv = new System.Windows.Forms.Button();
            this.deltv = new System.Windows.Forms.Button();
            this.tvadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datatv)).BeginInit();
            this.SuspendLayout();
            // 
            // actor
            // 
            this.actor.Location = new System.Drawing.Point(40, 194);
            this.actor.Multiline = true;
            this.actor.Name = "actor";
            this.actor.Size = new System.Drawing.Size(243, 39);
            this.actor.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(116, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 38);
            this.label2.TabIndex = 21;
            this.label2.Text = "Актор";
            // 
            // series
            // 
            this.series.Location = new System.Drawing.Point(40, 77);
            this.series.Multiline = true;
            this.series.Name = "series";
            this.series.Size = new System.Drawing.Size(243, 39);
            this.series.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(110, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Серiал";
            // 
            // datatv
            // 
            this.datatv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datatv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatv.Location = new System.Drawing.Point(40, 414);
            this.datatv.Name = "datatv";
            this.datatv.RowTemplate.Height = 25;
            this.datatv.Size = new System.Drawing.Size(478, 189);
            this.datatv.TabIndex = 18;
            // 
            // gtv
            // 
            this.gtv.AccessibleDescription = "";
            this.gtv.Location = new System.Drawing.Point(375, 250);
            this.gtv.Name = "gtv";
            this.gtv.Size = new System.Drawing.Size(143, 46);
            this.gtv.TabIndex = 17;
            this.gtv.Text = "Головне меню";
            this.gtv.UseVisualStyleBackColor = true;
            this.gtv.Click += new System.EventHandler(this.gtv_Click);
            // 
            // edittv
            // 
            this.edittv.AccessibleDescription = "";
            this.edittv.Location = new System.Drawing.Point(375, 181);
            this.edittv.Name = "edittv";
            this.edittv.Size = new System.Drawing.Size(143, 46);
            this.edittv.TabIndex = 16;
            this.edittv.Text = "Замiнити";
            this.edittv.UseVisualStyleBackColor = true;
            // 
            // deltv
            // 
            this.deltv.Location = new System.Drawing.Point(375, 109);
            this.deltv.Name = "deltv";
            this.deltv.Size = new System.Drawing.Size(143, 46);
            this.deltv.TabIndex = 15;
            this.deltv.Text = "Видалити";
            this.deltv.UseVisualStyleBackColor = true;
            // 
            // tvadd
            // 
            this.tvadd.Location = new System.Drawing.Point(375, 40);
            this.tvadd.Name = "tvadd";
            this.tvadd.Size = new System.Drawing.Size(143, 46);
            this.tvadd.TabIndex = 14;
            this.tvadd.Text = "Додати";
            this.tvadd.UseVisualStyleBackColor = true;
            // 
            // TVSeries_Actors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(26)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(557, 642);
            this.Controls.Add(this.actor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.series);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datatv);
            this.Controls.Add(this.gtv);
            this.Controls.Add(this.edittv);
            this.Controls.Add(this.deltv);
            this.Controls.Add(this.tvadd);
            this.Name = "TVSeries_Actors";
            this.Text = "TVSeries_Actors";
            ((System.ComponentModel.ISupportInitialize)(this.datatv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox actor;
        private Label label2;
        private TextBox series;
        private Label label1;
        private DataGridView datatv;
        private Button gtv;
        private Button edittv;
        private Button deltv;
        private Button tvadd;
    }
}