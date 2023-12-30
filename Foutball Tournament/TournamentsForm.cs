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
    public partial class TournamentsForm : Form
    {

        private TournamentManager tournamentManager;

        public TournamentsForm(TournamentManager tournamentManager)
        {
            InitializeComponent();
            this.tournamentManager = tournamentManager; // Создаем экземпляр менеджера турниров

            LoadTournaments(); // Загружаем турниры из файла или другого источника
        }

        private void LoadTournaments()
        {
            List<Tournament> tournaments = tournamentManager.GetTournaments();
            dataGridViewTournaments.DataSource = tournaments; // Устанавливаем список турниров в DataGridView
        }

        private void DataGridViewTournaments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedTournament = dataGridViewTournaments.CurrentRow?.DataBoundItem as Tournament;
            this.Hide();
            if (selectedTournament != null)
            {
                // Открываем форму TournamentDetailForm для отображения выбранного турнира
                using (var tournamentDetailForm = new TournamentDetailForm(selectedTournament, tournamentManager,this))
                {
                    var result = tournamentDetailForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Обновление статистики и сохранение изменений
                        LoadTournamentStatistics(selectedTournament);
                        this.Show();
                    }
                }
            }
        }
        private void LoadTournamentStatistics(Tournament tournament)
        {
            dataGridViewTournaments.DataSource = null; // Очищаем существующие данные в DataGridView

            if (tournament.Teams != null && tournament.Teams.Any()) // Проверка на null и пустой список
            {
                // Загрузка статистики турнира (примерный код)
                tournamentManager.UpdateTeamStatisticsFromMatches(tournament.Teams, tournament.Matches);
            }
            else
            {
                // Обработка случая, если список команд пуст или null
                // Например, вывод сообщения об отсутствии данных
                MessageBox.Show("Нет данных о командах для отображения статистики.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
