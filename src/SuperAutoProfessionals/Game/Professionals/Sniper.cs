namespace SuperAutoProfessionals;
public class Sniper : Professional
{
    public override string CodeName => "SP";

	internal override bool On(Event e)
	{
		base.On(e);
            if(e.Code != EventCode.Die) return false;

            EnemyTeam.ForEach(p => {
                Log($"Sniping {p} for 2 damage");
                Game.Attack(p, 2);
            });
            
        return true;

    }	
}