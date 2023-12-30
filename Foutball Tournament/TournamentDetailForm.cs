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
    public partial class TournamentDetailForm : Form
    {
        private TournamentsForm tournamentsForm;
        private Tournament selectedTournament;
        private TournamentManager tournamentManager;
        public TournamentDetailForm(Tournament tournament,TournamentManager tournamentManager,TournamentsForm tournamentsForm)
        {
            InitializeComponent();
            selectedTournament = tournament;
            this.tournamentsForm = tournamentsForm;
            this.tournamentManager = tournamentManager;
            // Инициализация и заполнение элементов управления информацией о турнире
            lblTournamentName.Text = selectedTournament.Name;
            lblYear.Text = selectedTournament.Year.ToString();
            lblLocation.Text = selectedTournament.Location;

            LoadTournamentStatistics(selectedTournament);
        }
        private void LoadTournamentStatistics(Tournament tournament)
        {
            dataGridViewTournaments.DataSource = null; // Очищаем существующие данные в DataGridView

            if (tournament.Teams != null && tournament.Teams.Any()) // Проверка на null и пустой список
            {
                // Загрузка статистики турнира (примерный код)
                tournamentManager.UpdateTeamStatisticsFromMatches(tournament.Teams, tournament.Matches);
                RecalculateTeamsStatistics();
            }
            else
            {
                // Обработка случая, если список команд пуст или null
                // Например, вывод сообщения об отсутствии данных
                MessageBox.Show("Нет данных о командах для отображения статистики.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnEditTournament_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрываем текущую форму перед открытием формы редактирования матчей
            using (var editForm = new EditMatchesForm(selectedTournament, tournamentManager, this))
            {
                var result = editForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadTournamentStatistics(selectedTournament); // Обновляем данные после закрытия формы редактирования
                    this.Show(); // Показываем обратно текущую форму
                }
            }
        }
        private void RecalculateTeamsStatistics()
        {
            // Получаем все матчи для выбранного турнира (selectedTournament)
            List<Match> matches = tournamentManager.GetAllMatchesFromTournament(selectedTournament);

            // Создаем словарь для отслеживания статистики команд (команда -> количество очков и голов)
            Dictionary<string, Tuple<int, int>> teamStatistics = new Dictionary<string, Tuple<int, int>>();

            // Проходим по каждому матчу и обновляем статистику команд
            foreach (var match in matches)
            {
                string teamAName = match.TeamA.Name;
                string teamBName = match.TeamB.Name;
                int scoreTeamA = match.ScoreTeamA;
                int scoreTeamB = match.ScoreTeamB;

                // Подсчитываем очки и голы для каждой команды
                int pointsTeamA = 0;
                int goalsTeamA = 0;
                int pointsTeamB = 0;
                int goalsTeamB = 0;

                if (scoreTeamA > scoreTeamB)
                {
                    pointsTeamA = 2;
                }
                else if (scoreTeamA < scoreTeamB)
                {
                    pointsTeamB = 2;
                }
                else
                {
                    pointsTeamA = 1;
                    pointsTeamB = 1;
                }

                goalsTeamA = scoreTeamA;
                goalsTeamB = scoreTeamB;

                // Обновляем статистику для команд
                if (!teamStatistics.ContainsKey(teamAName))
                {
                    teamStatistics[teamAName] = new Tuple<int, int>(pointsTeamA, goalsTeamA);
                }
                else
                {
                    var stats = teamStatistics[teamAName];
                    teamStatistics[teamAName] = new Tuple<int, int>(stats.Item1 + pointsTeamA, stats.Item2 + goalsTeamA);
                }

                if (!teamStatistics.ContainsKey(teamBName))
                {
                    teamStatistics[teamBName] = new Tuple<int, int>(pointsTeamB, goalsTeamB);
                }
                else
                {
                    var stats = teamStatistics[teamBName];
                    teamStatistics[teamBName] = new Tuple<int, int>(stats.Item1 + pointsTeamB, stats.Item2 + goalsTeamB);
                }
            }

            // Создаем список объектов для отображения в DataGridView
            var teamsStatsList = teamStatistics.Select(kv => new
            {
                TeamName = kv.Key,
                Points = kv.Value.Item1,
                GoalsScored = kv.Value.Item2
            }).ToList();

            // Загружаем обновленный список команд в DataGridView
            dataGridViewTournaments.DataSource = teamsStatsList;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            tournamentsForm.Show();
        }
        public void RefreshTournamentData()
        {
            LoadTournamentStatistics(selectedTournament);
        }
    }
}
