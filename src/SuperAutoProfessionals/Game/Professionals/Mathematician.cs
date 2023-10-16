namespace SuperAutoProfessionals;
public class Mathematician : Professional
{
    public override string CodeName => "MT";
    // for every enemy, add 1 to their attack and health
	internal override bool On(Event e)
	{
		base.On(e);
        
        if (e.Code!=EventCode.StartOfBattle) return false;
        EnemyTeam.ForEach(p => {
                Log($"Increasing attack and health of {p} by 1");
                p.Health +=1;
                p.Attack +=1;
            });
        
        return true;

    }	
}