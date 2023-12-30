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
    public partial class MainForm : Form
    {
        private TournamentManager tournamentManager;
        public MainForm()
        {
            InitializeComponent();
            tournamentManager = new TournamentManager();
        }

        private void OpenTournaments_Click(object sender, EventArgs e)
        {
            TournamentsForm tournamentsForm = new TournamentsForm(tournamentManager);
            tournamentsForm.ShowDialog();
        }

        private void AddTournament_Click(object sender, EventArgs e)
        {
            AddTournamentForm addTournamentForm = new AddTournamentForm(tournamentManager);
            addTournamentForm.ShowDialog();
        }
    }
}
