using Foutball_Tournament.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Match = Foutball_Tournament.Entities.Match;

namespace Foutball_Tournament
{
    public partial class AddTeamsForm : Form
    {
        private Tournament currentTournament;
        private int addedTeamsCount = 1;
        private const int MaxTeams = 4;
        private List<Match> matches;
        private TournamentManager tournamentManager;
        private bool isMatchesGenerated = false;
        public AddTeamsForm(Tournament tournament, TournamentManager tournamentManager)
        {
            InitializeComponent();
            currentTournament = tournament;
            currentTournament.Teams = new List<Team>();
            matches = new List<Match>();
            this.tournamentManager = tournamentManager;
        }
        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            if (addedTeamsCount > MaxTeams)
            {
                MessageBox.Show("Достигнуто максимальное количество команд.");
                return;
            } 
            // Логика добавления команды в турнир
            string teamName = teamNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(teamName))
            {
                MessageBox.Show("ВВедите корректное имя команды.");
                return;
            }
            // Создание новой команды
            Team newTeam = new Team(teamName);

            // Добавление команды к турниру
            currentTournament.Teams.Add(newTeam);

            // Очистить поля для следующей команды
            teamNameTextBox.Text = "";
            addedTeamsCount++;
            if (addedTeamsCount > MaxTeams)
            {
                addTeamButton.Enabled = false;
            }
            teamsListBox.Items.Add(newTeam.Name);
        }

        private void generateMatchesButton_Click(object sender, EventArgs e)
        {
            matches.Clear();
            if (currentTournament.Teams.Count != 4)
            {
                MessageBox.Show("Недостаточно команд для создания матчей.");
                return;
            }
            // Сгенерируем матчи для каждой возможной комбинации команд
            for (int i = 0; i < currentTournament.Teams.Count - 1; i++)
            {
                for (int j = i + 1; j < currentTournament.Teams.Count; j++)
                {
                    Team teamA = currentTournament.Teams[i];
                    Team teamB = currentTournament.Teams[j];

                    // Генерация случайных значений для количества голов
                    Random random = new Random(DateTime.Now.Millisecond + i);
                    int scoreTeamA = random.Next(0, 10);
                    Random random1 = new Random(DateTime.Now.Millisecond+i+j);
                    int scoreTeamB = random.Next(0, 10);

                    // Создание матча и добавление его в список матчей
                    Match newMatch = new Match(teamA, teamB, scoreTeamA, scoreTeamB);
                    matches.Add(newMatch);
                }
            }

            // Отображение матчей в DataGridView или ListBox
            // Например, в DataGridView
            dataGridViewMatches.DataSource = matches.Select(match => new
            {
                TeamA = match.TeamA.Name,
                ScoreTeamA = match.ScoreTeamA,
                ScoreTeamB = match.ScoreTeamB,
                TeamB = match.TeamB.Name
            }).ToList();

            // Сохранение сгенерированных матчей в текущем турнире
            currentTournament.Matches = matches;
            isMatchesGenerated = true;
        }

        private void addTournamentButton_Click(object sender, EventArgs e)
        {
            if (!isMatchesGenerated)
            {
                MessageBox.Show("Сначала сгенерируйте матчи для турнира.");
                return;
            }
            SaveTournamentToXml(currentTournament);
            MessageBox.Show("Турнир сохранен в файл.");
            this.Close();
        }

        private void SaveTournamentToXml(Tournament tournament)
        {
            tournamentManager.AddTournament(tournament);
        }
    }
}
