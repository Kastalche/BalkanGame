using System;
public interface IDisplayable
{
    void WelcomePlayer();
    void DisplayTeams();
    void BattleBegin();
    void AtackReceived();
    void ShowRoundSummary();
    void ShowWinner();
    void NewGame();
     void HealtTeamMate();
}