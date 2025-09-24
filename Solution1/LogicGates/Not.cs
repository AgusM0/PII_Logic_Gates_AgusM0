namespace LogicGates;

public class Not:IGate
{

    public List<Input> Inputs { get; set; }

    public Not()
    {
        this.Inputs = new List<Input>();
    }



    public void AddInput(Input input)
    {
        if (!this.Inputs.Contains(input) && !(this.Inputs.Count>0))
        {
            this.Inputs.Add(input);
        }

    }

    public void RemoveInput(Input input)
    {
        if (Inputs.Contains(input))
        {
            this.Inputs.Remove(input);
        }
    }

    public bool GateConversion(List<Input> itms)
    {
        if (!(itms.Count>0))
        {
            return itms[0].Value;
        }
        else
        {
            return !(itms[0].Value);
        }
        
    }
}