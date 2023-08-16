using OneOf;

namespace PrimeBlazor.Components.Button;

public class ButtonPassthroughOptions
{
    public PassThroughOption? Root { get; set; }
    public string? LoadingIcon { get; set; }
    public string? Icon { get; set; }
    public string? Label { get; set; }
    public string? Badge { get; set; }
}

public class PassThroughOption : OneOfBase<string, Func<ButtonPtContext, string>>
{
    private PassThroughOption(OneOf<string, Func<ButtonPtContext, string>> _) : base(_) { }
    
    public static implicit operator PassThroughOption(string _) => new(_);
    public static implicit operator PassThroughOption(Func<ButtonPtContext, string> _) => new(_);
    
    public static PassThroughOption FromFunc(Func<ButtonPtContext, string> func) => func;
}

public class ButtonPtContext
{
    public object? Instance { get; set; }
}