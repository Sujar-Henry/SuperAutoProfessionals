namespace SuperAutoProfessionals; 
public class Demolitionist : Professional
{
    public override string CodeName => "DM";


	internal override bool On(Event e)
	{
		base.On(e);

		if (e.Code == EventCode.Die) {
            EnemyTeam.ForEach(p => {
                Log($"Dealing {2} damage to {p}");
                Game.Attack(p, 2);
            });
            Team.ForEach(p => {
                Log($"Dealing {2} damage to {p}");
                Game.Attack(p, 2);
            });
        }
        return true;

    }	
}

