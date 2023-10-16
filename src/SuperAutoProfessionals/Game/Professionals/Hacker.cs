namespace SuperAutoProfessionals;
public class Hacker : Professional
{

    //redeuce enemies attacks by 2  at start of battle

    public override string CodeName => "HK";

	internal override bool On(Event e)
	{
		base.On(e);
        if (e.Code!=EventCode.StartOfBattle) return false;
        EnemyTeam.ForEach(p => {
                Log($"Hacking {p} for 2 Attack");
                p.Attack -= 2;

            });
        
        return true;

    }	
}