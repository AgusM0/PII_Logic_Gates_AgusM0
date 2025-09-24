namespace LogicGates;

public class Input
{
    public string Name { get; set; }
    public bool Value { get; set; }

    public Input(string name, bool value)
    {
        this.Name = name;
        this.Value = value;
    }
}
