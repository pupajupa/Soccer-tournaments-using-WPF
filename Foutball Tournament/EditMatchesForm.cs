using Foutball_Tournament.Entities;
using Microsoft.VisualBasic;
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
    public partial class EditMatchesForm : Form
    {
        private TournamentDetailForm tournamentDetailForm;
        private TournamentManager tournamentManager;
        private Tournament tournament;
        public EditMatchesForm(Tournament tournament, TournamentManager tournamentManager, TournamentDetailForm tournamentDetailForm)
        {
            InitializeComponent();
            this.tournament = tournament;
            InitializeDataGridView();
            this.tournamentManager = tournamentManager;
            this.tournamentDetailForm = tournamentDetailForm;
        }
        private void InitializeDataGridView()
        {
            // Настройка DataGridView для отображения матчей
            dataGridViewMatches.AutoGenerateColumns = false;

            // Создание столбцов DataGridView
            DataGridViewTextBoxColumn teamAColumn = new DataGridViewTextBoxColumn();
            teamAColumn.DataPropertyName = "TeamAName"; // Связывание с данными
            teamAColumn.HeaderText = "Команда А";
            dataGridViewMatches.Columns.Add(teamAColumn);

            DataGridViewTextBoxColumn scoreAColumn = new DataGridViewTextBoxColumn();
            scoreAColumn.DataPropertyName = "ScoreTeamA"; // Связывание с данными
            scoreAColumn.HeaderText = "Счёт А";
            dataGridViewMatches.Columns.Add(scoreAColumn);

            DataGridViewTextBoxColumn scoreBColumn = new DataGridViewTextBoxColumn();
            scoreBColumn.DataPropertyName = "ScoreTeamB"; // Связывание с данными
            scoreBColumn.HeaderText = "Счёт Б";
            dataGridViewMatches.Columns.Add(scoreBColumn);

            DataGridViewTextBoxColumn teamBColumn = new DataGridViewTextBoxColumn();
            teamBColumn.DataPropertyName = "TeamBName"; // Связывание с данными
            teamBColumn.HeaderText = "Команда B";
            dataGridViewMatches.Columns.Add(teamBColumn);

            // Заполнение DataGridView данными о матчах
            dataGridViewMatches.DataSource = tournament.Matches.Select(match => new
            {
                TeamAName = match.TeamA.Name,
                ScoreTeamA = match.ScoreTeamA,
                ScoreTeamB = match.ScoreTeamB,
                TeamBName = match.TeamB.Name
            }).ToList();
        }

        int selectRowIndex;

        private void changeCellBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewMatches.Rows[selectRowIndex];

            if (row.Cells[1].Value != null && row.Cells[2].Value != null)
            {
                try
                {
                    string scoreA = Interaction.InputBox($"Введите новое количество голов команды {dataGridViewMatches.Rows[selectRowIndex].Cells[0].Value}", "Обновление информации", row.Cells[1].Value.ToString(), -1, -1);
                    string scoreB = Interaction.InputBox($"Введите новое количество голов команды {dataGridViewMatches.Rows[selectRowIndex].Cells[3].Value}", "Обновление информации", row.Cells[2].Value.ToString(), -1, -1);

                    if (int.TryParse(scoreA, out int newScoreTeamA) && int.TryParse(scoreB, out int newScoreTeamB))
                    {
                        int rowIndex = row.Index;
                        Match match = tournament.Matches[rowIndex];

                        if (newScoreTeamA < 0 || newScoreTeamB < 0)
                        {
                            MessageBox.Show("Введите корректное количество голов", "Ошибка");
                            return;
                        }
                        else
                        {
                            // Вызов метода для изменения данных в объекте tournamentManager
                            tournamentManager.EditMatchScore(match, newScoreTeamA, newScoreTeamB);
                            List<Match> updatedMatches = tournamentManager.GetAllMatchesFromTournament(tournament);
                            // Обновление соответствующих ячеек в DataGridView
                            dataGridViewMatches.DataSource = null; // Отключение источника данных
                            dataGridViewMatches.DataSource = updatedMatches.Select(m => new
                            {
                                TeamAName = m.TeamA.Name,
                                ScoreTeamA = m.ScoreTeamA,
                                ScoreTeamB = m.ScoreTeamB,
                                TeamBName = m.TeamB.Name
                            }).ToList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректные значения для счёта", "Ошибка");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Введите корректное значение счёта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRowIndex = e.RowIndex;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            tournamentDetailForm.RefreshTournamentData();
            tournamentDetailForm.Show();
        }
    }
}
