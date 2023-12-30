namespace Foutball_Tournament
{
    partial class AddTeamsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeamsForm));
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.generateMatchesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMatches = new System.Windows.Forms.DataGridView();
            this.addTournamentButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Location = new System.Drawing.Point(101, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Добавление команды";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.teamNameTextBox);
            this.panel1.Location = new System.Drawing.Point(108, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 82);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название команды";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTextBox.Location = new System.Drawing.Point(0, 47);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(305, 35);
            this.teamNameTextBox.TabIndex = 0;
            this.teamNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.Wheat;
            this.addTeamButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeamButton.Location = new System.Drawing.Point(108, 153);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(305, 55);
            this.addTeamButton.TabIndex = 11;
            this.addTeamButton.Text = "Добавить команду";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // teamsListBox
            // 
            this.teamsListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 28;
            this.teamsListBox.Location = new System.Drawing.Point(108, 260);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(305, 144);
            this.teamsListBox.TabIndex = 12;
            // 
            // generateMatchesButton
            // 
            this.generateMatchesButton.BackColor = System.Drawing.Color.Wheat;
            this.generateMatchesButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateMatchesButton.Location = new System.Drawing.Point(569, 83);
            this.generateMatchesButton.Name = "generateMatchesButton";
            this.generateMatchesButton.Size = new System.Drawing.Size(305, 55);
            this.generateMatchesButton.TabIndex = 13;
            this.generateMatchesButton.Text = "Сгенерировать матчи";
            this.generateMatchesButton.UseVisualStyleBackColor = false;
            this.generateMatchesButton.Click += new System.EventHandler(this.generateMatchesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(594, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Создание матчей";
            // 
            // dataGridViewMatches
            // 
            this.dataGridViewMatches.AllowUserToAddRows = false;
            this.dataGridViewMatches.AllowUserToDeleteRows = false;
            this.dataGridViewMatches.AllowUserToResizeColumns = false;
            this.dataGridViewMatches.AllowUserToResizeRows = false;
            this.dataGridViewMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMatches.ColumnHeadersHeight = 50;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = "0";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMatches.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewMatches.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridViewMatches.Location = new System.Drawing.Point(441, 161);
            this.dataGridViewMatches.MultiSelect = false;
            this.dataGridViewMatches.Name = "dataGridViewMatches";
            this.dataGridViewMatches.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMatches.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewMatches.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMatches.RowTemplate.Height = 24;
            this.dataGridViewMatches.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMatches.Size = new System.Drawing.Size(529, 243);
            this.dataGridViewMatches.TabIndex = 15;
            // 
            // addTournamentButton
            // 
            this.addTournamentButton.BackColor = System.Drawing.Color.GreenYellow;
            this.addTournamentButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTournamentButton.Location = new System.Drawing.Point(310, 430);
            this.addTournamentButton.Name = "addTournamentButton";
            this.addTournamentButton.Size = new System.Drawing.Size(305, 55);
            this.addTournamentButton.TabIndex = 16;
            this.addTournamentButton.Text = "Добавить турнир";
            this.addTournamentButton.UseVisualStyleBackColor = false;
            this.addTournamentButton.Click += new System.EventHandler(this.addTournamentButton_Click);
            // 
            // AddTeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Foutball_Tournament.Properties.Resources.TournamentBgVertical;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(982, 497);
            this.Controls.Add(this.addTournamentButton);
            this.Controls.Add(this.dataGridViewMatches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateMatchesButton);
            this.Controls.Add(this.teamsListBox);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 544);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 544);
            this.Name = "AddTeamsForm";
            this.Text = "AddTeamsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.Button generateMatchesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMatches;
        private System.Windows.Forms.Button addTournamentButton;
    }
}