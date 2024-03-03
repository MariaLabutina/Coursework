
namespace Coursework
{
    partial class Palette
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
            this.dataGridSymbols = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSymbols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSymbols
            // 
            this.dataGridSymbols.AllowUserToAddRows = false;
            this.dataGridSymbols.AllowUserToDeleteRows = false;
            this.dataGridSymbols.AllowUserToResizeColumns = false;
            this.dataGridSymbols.AllowUserToResizeRows = false;
            this.dataGridSymbols.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridSymbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSymbols.ColumnHeadersVisible = false;
            this.dataGridSymbols.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridSymbols.EnableHeadersVisualStyles = false;
            this.dataGridSymbols.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridSymbols.Location = new System.Drawing.Point(12, 12);
            this.dataGridSymbols.MultiSelect = false;
            this.dataGridSymbols.Name = "dataGridSymbols";
            this.dataGridSymbols.ReadOnly = true;
            this.dataGridSymbols.RowHeadersWidth = 51;
            this.dataGridSymbols.RowTemplate.Height = 24;
            this.dataGridSymbols.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridSymbols.Size = new System.Drawing.Size(888, 342);
            this.dataGridSymbols.TabIndex = 0;
            this.dataGridSymbols.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSymbols_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 186);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Palette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridSymbols);
            this.Name = "Palette";
            this.Text = "Palette";
            this.Load += new System.EventHandler(this.Palette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSymbols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSymbols;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}