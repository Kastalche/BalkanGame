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
    void Atack(Hero sender, hero Atacker); // or just object atack ;) dependig what u chose for the atack.
}