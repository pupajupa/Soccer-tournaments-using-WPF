namespace Foutball_Tournament
{
    partial class TournamentDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTournaments = new System.Windows.Forms.DataGridView();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnEditTournament = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTournaments
            // 
            this.dataGridViewTournaments.AllowUserToAddRows = false;
            this.dataGridViewTournaments.AllowUserToDeleteRows = false;
            this.dataGridViewTournaments.AllowUserToResizeColumns = false;
            this.dataGridViewTournaments.AllowUserToResizeRows = false;
            this.dataGridViewTournaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTournaments.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTournaments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTournaments.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTournaments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTournaments.Location = new System.Drawing.Point(3, 158);
            this.dataGridViewTournaments.MaximumSize = new System.Drawing.Size(795, 240);
            this.dataGridViewTournaments.MinimumSize = new System.Drawing.Size(795, 240);
            this.dataGridViewTournaments.Name = "dataGridViewTournaments";
            this.dataGridViewTournaments.ReadOnly = true;
            this.dataGridViewTournaments.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTournaments.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTournaments.RowTemplate.Height = 24;
            this.dataGridViewTournaments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTournaments.Size = new System.Drawing.Size(795, 240);
            this.dataGridViewTournaments.TabIndex = 0;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.BackColor = System.Drawing.Color.Transparent;
            this.lblTournamentName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTournamentName.ForeColor = System.Drawing.Color.Wheat;
            this.lblTournamentName.Location = new System.Drawing.Point(347, 9);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(99, 39);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "label1";
            this.lblTournamentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYear.ForeColor = System.Drawing.Color.Wheat;
            this.lblYear.Location = new System.Drawing.Point(163, 100);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(69, 29);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "label2";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLocation.ForeColor = System.Drawing.Color.Wheat;
            this.lblLocation.Location = new System.Drawing.Point(551, 100);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 29);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "label3";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditTournament
            // 
            this.btnEditTournament.BackColor = System.Drawing.Color.Bisque;
            this.btnEditTournament.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTournament.Location = new System.Drawing.Point(556, 417);
            this.btnEditTournament.Name = "btnEditTournament";
            this.btnEditTournament.Size = new System.Drawing.Size(229, 52);
            this.btnEditTournament.TabIndex = 4;
            this.btnEditTournament.Text = "Редактировать";
            this.btnEditTournament.UseVisualStyleBackColor = false;
            this.btnEditTournament.Click += new System.EventHandler(this.btnEditTournament_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Bisque;
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 417);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(229, 52);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TournamentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Foutball_Tournament.Properties.Resources.TournamentBg;
            this.ClientSize = new System.Drawing.Size(797, 490);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.btnEditTournament);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.dataGridViewTournaments);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 537);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(815, 537);
            this.Name = "TournamentDetailForm";
            this.Text = "TournamentDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTournaments;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnEditTournament;
        private System.Windows.Forms.Button backButton;
    }
}