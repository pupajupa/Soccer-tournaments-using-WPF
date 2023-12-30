namespace Foutball_Tournament
{
    partial class EditMatchesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMatchesForm));
            this.dataGridViewMatches = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.changeCellBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatches
            // 
            this.dataGridViewMatches.AllowUserToAddRows = false;
            this.dataGridViewMatches.AllowUserToDeleteRows = false;
            this.dataGridViewMatches.AllowUserToResizeColumns = false;
            this.dataGridViewMatches.AllowUserToResizeRows = false;
            this.dataGridViewMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMatches.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMatches.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMatches.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridViewMatches.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMatches.MultiSelect = false;
            this.dataGridViewMatches.Name = "dataGridViewMatches";
            this.dataGridViewMatches.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMatches.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMatches.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMatches.RowTemplate.Height = 24;
            this.dataGridViewMatches.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMatches.Size = new System.Drawing.Size(783, 412);
            this.dataGridViewMatches.TabIndex = 0;
            this.dataGridViewMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatches_CellClick);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Bisque;
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backButton.Location = new System.Drawing.Point(559, 431);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(236, 46);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // changeCellBtn
            // 
            this.changeCellBtn.BackColor = System.Drawing.Color.Bisque;
            this.changeCellBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeCellBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changeCellBtn.Location = new System.Drawing.Point(12, 431);
            this.changeCellBtn.Name = "changeCellBtn";
            this.changeCellBtn.Size = new System.Drawing.Size(236, 46);
            this.changeCellBtn.TabIndex = 2;
            this.changeCellBtn.Text = "Измененить ячейку";
            this.changeCellBtn.UseVisualStyleBackColor = false;
            this.changeCellBtn.Click += new System.EventHandler(this.changeCellBtn_Click);
            // 
            // EditMatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Foutball_Tournament.Properties.Resources.TournamentBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 489);
            this.Controls.Add(this.changeCellBtn);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridViewMatches);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMatchesForm";
            this.Text = "EditMatchesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridViewMatches;
        private System.Windows.Forms.Button changeCellBtn;
    }
}