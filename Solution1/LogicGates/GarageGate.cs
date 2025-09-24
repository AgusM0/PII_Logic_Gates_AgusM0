namespace LogicGates;

public class GarageGate: ILogicCircuit
{

    public List<Input> Inputs { get; set; }

    public GarageGate()
    {
        this.Inputs = new List<Input>();
    }

    public bool LogicResult(List<Input> ins)
    {

        if (!(ins.Count<3))
        {
            Input A = ins[0];
            Input B = ins[1];
            Input C = ins[2];

            // AND1
            And and1 = new And();
            and1.AddInput(A);
            and1.AddInput(B);
            bool afterA1=and1.GateConversion(and1.Inputs);
            Input afterAnd1 = new Input("afterA1",afterA1);

            // Negados A y B
            Not not1 = new Not();
            not1.AddInput(A);
            bool noA =not1.GateConversion(not1.Inputs);
            Input notA = new Input("A negado", noA);
            
            Not not2 = new Not();
            not2.AddInput(B);
            bool noB =not1.GateConversion(not2.Inputs);
            Input notB = new Input("B negado", noB);
           
            //Segundo And con negados
            And and2 = new And();
            and2.AddInput(notA);
            and2.AddInput(notB);
            Console.WriteLine(and2.Inputs);
            bool afterA2=and2.GateConversion(and2.Inputs);
            Input afterAnd2 = new Input("afterA2",afterA2);
            
            // or con and1 y and 2 inputs resultantes
            Or or = new Or();
            or.AddInput(afterAnd1);
            or.AddInput(afterAnd2);
            bool afterO=or.GateConversion(or.Inputs);
            Input afterOr = new Input("after or", afterO);
            //tercer and y final
            And and3 = new And();
            and3.AddInput(afterOr);
            and3.AddInput(C);
            bool result=and3.GateConversion(and3.Inputs);
            return result;


        }
        
        
        
        return true;
    }


}