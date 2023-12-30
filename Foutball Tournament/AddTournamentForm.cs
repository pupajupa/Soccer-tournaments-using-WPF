using Foutball_Tournament.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foutball_Tournament
{
    public partial class AddTournamentForm : Form
    {
        private TournamentManager tournamentManager;
        private Tournament newTournament;
        public AddTournamentForm(TournamentManager tournamentManager)
        {
            InitializeComponent();
            this.tournamentManager = tournamentManager; // Создаем экземпляр менеджера турниров
        }

        private void btnAddTournament_Click(object sender, EventArgs e)
        {
            string tournamentName = txtTournamentName.Text;

            int year;

            if (!int.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show("Пожалуйста, введите корректный год.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (year < 1900 || year >= 2023)
            {
                MessageBox.Show("Год должен быть больше 1900 и меньше 2023.","Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            string location = txtLocation.Text;
            if (string.IsNullOrWhiteSpace(tournamentName) || string.IsNullOrWhiteSpace(year.ToString()) || string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Создание нового турнира
            newTournament = new Tournament(tournamentName, year, location);
            txtTournamentName.Text = "";
            txtYear.Text = "";
            txtLocation.Text = "";
            // Открытие формы для добавления команд
            this.Hide(); // Скрываем текущую форму перед открытием формы
            using (var addTeamsForm = new AddTeamsForm(newTournament, tournamentManager))
            {
                var result = addTeamsForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show(); // Показываем обратно текущую форму
                }
            }
        }
    }
}
