namespace Foutball_Tournament
{
    partial class TournamentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTournaments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTournaments
            // 
            this.dataGridViewTournaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTournaments.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dataGridViewTournaments.ColumnHeadersHeight = 50;
            this.dataGridViewTournaments.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTournaments.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTournaments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTournaments.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTournaments.Name = "dataGridViewTournaments";
            this.dataGridViewTournaments.ReadOnly = true;
            this.dataGridViewTournaments.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTournaments.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTournaments.RowTemplate.Height = 24;
            this.dataGridViewTournaments.RowTemplate.ReadOnly = true;
            this.dataGridViewTournaments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTournaments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTournaments.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewTournaments.TabIndex = 0;
            this.dataGridViewTournaments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTournaments_CellDoubleClick);
            // 
            // TournamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTournaments);
            this.Name = "TournamentsForm";
            this.Text = "TournamentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTournaments;
    }
}