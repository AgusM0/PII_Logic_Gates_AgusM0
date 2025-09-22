namespace LogicGates;

public class Or:IGate
{

    public List<Input> Inputs { get; set; }

    public Or()
    {
        this.Inputs = new List<Input>();
    }
    
    
    public void AddInput(Input input)
    {
        if (!this.Inputs.Contains(input))
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
        bool returnBool = itms[0].Value;
        foreach (Input value in itms)
        {
            returnBool = (returnBool || value.Value);
        }

        return returnBool;
    }
}