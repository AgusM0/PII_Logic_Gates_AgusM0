namespace LogicGates;

public interface IGate
{

    public List<Input> Inputs { get; set; }

    public void AddInput(Input input)
    {
        if (!Inputs.Contains(input))
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
        return true;
    }
}

