namespace Foutball_Tournament
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenTournaments = new System.Windows.Forms.Button();
            this.AddTournament = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenTournaments
            // 
            this.OpenTournaments.BackColor = System.Drawing.Color.Bisque;
            this.OpenTournaments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenTournaments.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenTournaments.Location = new System.Drawing.Point(0, 0);
            this.OpenTournaments.Name = "OpenTournaments";
            this.OpenTournaments.Size = new System.Drawing.Size(216, 60);
            this.OpenTournaments.TabIndex = 2;
            this.OpenTournaments.Text = "Открыть список туринров";
            this.OpenTournaments.UseVisualStyleBackColor = false;
            this.OpenTournaments.Click += new System.EventHandler(this.OpenTournaments_Click);
            // 
            // AddTournament
            // 
            this.AddTournament.BackColor = System.Drawing.Color.Bisque;
            this.AddTournament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTournament.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTournament.Location = new System.Drawing.Point(0, 0);
            this.AddTournament.Name = "AddTournament";
            this.AddTournament.Size = new System.Drawing.Size(216, 60);
            this.AddTournament.TabIndex = 1;
            this.AddTournament.Text = "Добавить турнир";
            this.AddTournament.UseVisualStyleBackColor = false;
            this.AddTournament.Click += new System.EventHandler(this.AddTournament_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddTournament);
            this.panel1.Location = new System.Drawing.Point(84, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 60);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Foutball_Tournament.Properties.Resources.MainBg;
            this.panel2.Controls.Add(this.OpenTournaments);
            this.panel2.Location = new System.Drawing.Point(498, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 60);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(200, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Футбольные турниры";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Foutball_Tournament.Properties.Resources.MainBg;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenTournaments;
        private System.Windows.Forms.Button AddTournament;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}