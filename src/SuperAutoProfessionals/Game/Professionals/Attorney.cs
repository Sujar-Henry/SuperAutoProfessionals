namespace SuperAutoProfessionals;
public class Attorney : Professional
{
    // If the Attorney dies, it gives 2 health and 2 attack to the teammate behind.
    public override string CodeName => "AT";


	internal override bool On(Event e)
	{
		base.On(e);

        if(e.Code != EventCode.Die) return false;

		var p = e.Professional!;
		if (p != this) return false;
        var index = Team.GetIndex(this);

          Team.ForEach(p => {
                if (p.IsDead) return;
                Log($"In my will, I leave 2 health and 2 attack to {p}");
                if (Team.GetIndex(p)<= index)return;

                p.Health += 2;
                p.Attack += 2;
            });
         return true;

    }
}
