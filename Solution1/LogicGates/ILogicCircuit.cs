namespace LogicGates;

public interface ILogicCircuit
{

    public List<Input> Inputs { get; set; }



    public bool LogicResult(List<Input> ins)
    {
        return true;
    }


}