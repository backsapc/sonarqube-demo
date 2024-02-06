namespace SonarDemo.Modules.Smells;

public abstract class CodeSmellsBase { 
    protected CodeSmellsBase(IDictionary<string, string> dummyDict) {
        DummyDict = dummyDict;
    }

    public IDictionary<string, string> DummyDict { get; }
}

public class CodeSmellsChild : CodeSmellsBase { 
    public CodeSmellsChild() : base(new Dictionary<string, string>()) { 

    }

    public async Task<int> AsyncWithoutAsync() { 
        return 4;
    }

    public async Task<int> inconsistent_naming() { 
        await Task.Delay(5);

        return 6;
    }

    public override string ToString()
    {
        if (DummyDict == null)
        {
            throw new ArgumentException(nameof(DummyDict));
        }

        return DummyDict.ToString();
    }
}