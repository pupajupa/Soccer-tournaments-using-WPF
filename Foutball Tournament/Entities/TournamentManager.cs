using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Foutball_Tournament.Entities
{
    public class TournamentManager
    {
        private List<Tournament> tournaments;
        private string filePath = "E:\\Tournament\\Foutball Tournament\\Foutball Tournament\\File\\File.xml"; // Путь к файлу XML

        public TournamentManager()
        {
            tournaments = new List<Tournament>(); // Инициализация списка турниров
            LoadTournamentsFromXML(); // Загрузка турниров из файла XML
        }

        public List<Tournament> GetTournaments()
        {
            return tournaments; // Возвращает список турниров
        }

        public void AddTournament(Tournament newTournament)
        {
            tournaments.Add(newTournament); // Добавление нового турнира в список

            // Добавление нового турнира в файл XML
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                // Загрузка существующего XML файла
                xmlDoc.Load(filePath);

                // Создание нового элемента Tournament
                XmlElement tournamentElement = xmlDoc.CreateElement("Tournament");

                // Добавление информации о турнире в XML
                XmlElement nameElement = xmlDoc.CreateElement("Name");
                nameElement.InnerText = newTournament.Name;
                tournamentElement.AppendChild(nameElement);

                XmlElement yearElement = xmlDoc.CreateElement("Year");
                yearElement.InnerText = newTournament.Year.ToString();
                tournamentElement.AppendChild(yearElement);

                XmlElement locationElement = xmlDoc.CreateElement("Location");
                locationElement.InnerText = newTournament.Location;
                tournamentElement.AppendChild(locationElement);

                // Добавление информации о командах и матчах в XML
                XmlElement teamsElement = xmlDoc.CreateElement("Teams");
                tournamentElement.AppendChild(teamsElement);

                // Добавление команд в XML
                foreach (var team in newTournament.Teams)
                {
                    XmlElement teamElement = xmlDoc.CreateElement("Team");
                    teamsElement.AppendChild(teamElement);

                    XmlElement teamNameElement = xmlDoc.CreateElement("Name");
                    teamNameElement.InnerText = team.Name;
                    teamElement.AppendChild(teamNameElement);
                }

                XmlElement matchesElement = xmlDoc.CreateElement("Matches");
                tournamentElement.AppendChild(matchesElement);

                // Добавление матчей в XML
                foreach (var match in newTournament.Matches)
                {
                    XmlElement matchElement = xmlDoc.CreateElement("Match");
                    matchesElement.AppendChild(matchElement);

                    XmlElement teamAElement = xmlDoc.CreateElement("TeamA");
                    XmlElement teamANameElement = xmlDoc.CreateElement("Name");
                    teamANameElement.InnerText = match.TeamA.Name;
                    teamAElement.AppendChild(teamANameElement);
                    matchElement.AppendChild(teamAElement);

                    XmlElement teamBElement = xmlDoc.CreateElement("TeamB");
                    XmlElement teamBNameElement = xmlDoc.CreateElement("Name");
                    teamBNameElement.InnerText = match.TeamB.Name;
                    teamBElement.AppendChild(teamBNameElement);
                    matchElement.AppendChild(teamBElement);

                    XmlElement scoreTeamAElement = xmlDoc.CreateElement("ScoreTeamA");
                    scoreTeamAElement.InnerText = match.ScoreTeamA.ToString();
                    matchElement.AppendChild(scoreTeamAElement);

                    XmlElement scoreTeamBElement = xmlDoc.CreateElement("ScoreTeamB");
                    scoreTeamBElement.InnerText = match.ScoreTeamB.ToString();
                    matchElement.AppendChild(scoreTeamBElement);
                }

                // Добавление нового элемента Tournament в корневой элемент Tournaments
                xmlDoc.DocumentElement.AppendChild(tournamentElement);

                // Сохранение XML в файл
                xmlDoc.Save(filePath);
            }
            catch (XmlException ex)
            {
                // Обработка ошибки при работе с XML
                // Например, вывод сообщения об ошибке или логирование
                MessageBox.Show($"Ошибка при обновлении файла XML: {ex.Message}", "Ошибка XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Match> GetAllMatchesFromTournament(Tournament tournament)
        {
            return tournament.Matches;
        }

        public void EditMatchScore(Match match, int newScoreTeamA, int newScoreTeamB)
        {
            int oldScoreTeamA = match.ScoreTeamA;
            int oldScoreTeamB = match.ScoreTeamB;

            match.ScoreTeamA = newScoreTeamA;
            match.ScoreTeamB = newScoreTeamB;

            // Обновляем статистику для команды A
            UpdateTeamStatistics(match.TeamA, match, oldScoreTeamA, oldScoreTeamB);
            // Обновляем статистику для команды B
            UpdateTeamStatistics(match.TeamB, match, oldScoreTeamB, oldScoreTeamA);

            // Обновляем данные в файле XML
            UpdateMatchesInXml(tournaments, match);
            LoadTournamentsFromXML();
        }

        private void UpdateTeamStatistics(Team team, Match match, int oldScore, int otherTeamOldScore)
        {
            team.Goals -= oldScore + otherTeamOldScore;

            if (match.ScoreTeamA > match.ScoreTeamB)
            {
                team.Points += 2;
            }
            else if (match.ScoreTeamA == match.ScoreTeamB)
            {
                team.Points += 1;
            }

            team.Goals += match.ScoreTeamA + match.ScoreTeamB;
        }

        private void UpdateMatchesInXml(List<Tournament> tournaments, Match match)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(filePath);

                foreach (var tournament in tournaments)
                {
                    foreach (var existingMatch in tournament.Matches)
                    {
                        if (existingMatch.Equals(match))
                        {
                            // Обновление счета в файле XML для соответствующего матча
                            XmlNode matchNode = doc.SelectSingleNode($"//Tournament[Name='{tournament.Name}']/Matches/Match[TeamA='{match.TeamA.Name}' and TeamB='{match.TeamB.Name}']");
                            if (matchNode != null)
                            {
                                matchNode.SelectSingleNode("ScoreTeamA").InnerText = match.ScoreTeamA.ToString();
                                matchNode.SelectSingleNode("ScoreTeamB").InnerText = match.ScoreTeamB.ToString();
                            }
                        }
                    }
                }

                doc.Save(filePath);
            }
            catch (XmlException ex)
            {
                MessageBox.Show($"Ошибка при обновлении файла XML: {ex.Message}", "Ошибка XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTournamentsFromXML()
        {
            tournaments.Clear(); // Очищаем список перед загрузкой данных из файла XML

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            // Проходим по каждому узлу 'Tournament' в XML-файле
            foreach (XmlNode tournamentNode in doc.SelectNodes("//Tournament"))
            {
                string name = tournamentNode.SelectSingleNode("Name").InnerText;
                int year = int.Parse(tournamentNode.SelectSingleNode("Year").InnerText);
                string location = tournamentNode.SelectSingleNode("Location").InnerText;

                Tournament tournament = new Tournament(name, year, location);
                tournament.Teams = new List<Team>();
                // Загрузка списка матчей для текущего турнира
                XmlNodeList matchNodes = tournamentNode.SelectNodes("Matches/Match");
                if (matchNodes != null)
                {
                    foreach (XmlNode matchNode in matchNodes)
                    {
                        // Загрузка информации о матче из XML
                        string teamAName = matchNode.SelectSingleNode("TeamA").InnerText;
                        string teamBName = matchNode.SelectSingleNode("TeamB").InnerText;
                        int scoreTeamA = int.Parse(matchNode.SelectSingleNode("ScoreTeamA").InnerText);
                        int scoreTeamB = int.Parse(matchNode.SelectSingleNode("ScoreTeamB").InnerText);

                        // Создание объекта Match и добавление его к текущему турниру
                        Match match = new Match(new Team(teamAName),new Team(teamBName),scoreTeamA,scoreTeamB);
                        tournament.Matches.Add(match);
                    }
                }

                // Загрузка списка команд для текущего турнира
                XmlNodeList teamNodes = tournamentNode.SelectNodes("Teams/Team");
                if (teamNodes != null)
                {
                    foreach (XmlNode teamNode in teamNodes)
                    {
                        // Загрузка информации о команде из XML
                        string teamName = teamNode.SelectSingleNode("Name").InnerText;
                        // Загрузка других параметров команды из XML

                        // Создание объекта Team и добавление его к текущему турниру
                        Team team = new Team(teamName);
                        tournament.Teams.Add(team);
                    }
                }
                tournaments.Add(tournament);
            }
        }
        public void UpdateTeamStatisticsFromMatches(List<Team> teams, List<Match> matches)
        {
            foreach (Team team in teams)
            {
                UpdateTeamStatisticsFromFile(team, matches);
            }
        }

        // Метод для обновления количества голов и очков команды на основе данных о матчах
        private void UpdateTeamStatisticsFromFile(Team team, List<Match> allMatches)
        {
            foreach (Match match in allMatches)
            {
                if (match.TeamA == team || match.TeamB == team)
                {
                    if (match.TeamA == team)
                    {
                        team.Goals += match.ScoreTeamA;
                        team.Points += CalculatePoints(match.ScoreTeamA, match.ScoreTeamB);
                    }
                    else
                    {
                        team.Goals += match.ScoreTeamB;
                        team.Points += CalculatePoints(match.ScoreTeamB, match.ScoreTeamA);
                    }
                }
            }
        }

        // Метод для расчета очков на основе счета матча
        private int CalculatePoints(int goalsScored, int goalsConceded)
        {
            int points = 0; // Примерный алгоритм, можно заменить на свой
            if (goalsScored > goalsConceded)
            {
                points += 2;
            }
            else if(goalsScored < goalsConceded)
            {
                points += 0;
            }
            else if (goalsScored == goalsConceded)
            {
                points += 1;
            }

            return points;
        }
       
    }
}
