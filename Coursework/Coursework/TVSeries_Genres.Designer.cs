namespace Coursework
{
    partial class TVSeries_Genres
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
            this.surnameactor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.actorname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deletebutton2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tvdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameactor
            // 
            this.surnameactor.Location = new System.Drawing.Point(31, 172);
            this.surnameactor.Multiline = true;
            this.surnameactor.Name = "surnameactor";
            this.surnameactor.Size = new System.Drawing.Size(243, 39);
            this.surnameactor.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(112, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 38);
            this.label2.TabIndex = 20;
            this.label2.Text = "Жанр";
            // 
            // actorname
            // 
            this.actorname.Location = new System.Drawing.Point(31, 73);
            this.actorname.Multiline = true;
            this.actorname.Name = "actorname";
            this.actorname.Size = new System.Drawing.Size(243, 39);
            this.actorname.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(98, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Серiал";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(366, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 46);
            this.button4.TabIndex = 17;
            this.button4.Text = "Головне меню";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 46);
            this.button3.TabIndex = 16;
            this.button3.Text = "Замiнити";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // deletebutton2
            // 
            this.deletebutton2.Location = new System.Drawing.Point(366, 112);
            this.deletebutton2.Name = "deletebutton2";
            this.deletebutton2.Size = new System.Drawing.Size(143, 46);
            this.deletebutton2.TabIndex = 15;
            this.deletebutton2.Text = "Видалити";
            this.deletebutton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tvdata
            // 
            this.tvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvdata.Location = new System.Drawing.Point(31, 369);
            this.tvdata.Name = "tvdata";
            this.tvdata.RowTemplate.Height = 25;
            this.tvdata.Size = new System.Drawing.Size(478, 189);
            this.tvdata.TabIndex = 13;
            this.tvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tvdata_CellContentClick);
            // 
            // TVSeries_Genres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(26)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(534, 601);
            this.Controls.Add(this.surnameactor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actorname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deletebutton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tvdata);
            this.Name = "TVSeries_Genres";
            this.Text = "TVSeries_Genres";
            ((System.ComponentModel.ISupportInitialize)(this.tvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox surnameactor;
        private Label label2;
        private TextBox actorname;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button deletebutton2;
        private Button button1;
        private DataGridView tvdata;
    }
}