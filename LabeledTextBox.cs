using Avalonia;
using Avalonia.Controls.Primitives;

namespace LearnTemplateControls;

public class LabeledTextBox : TemplatedControl
{
    public static readonly StyledProperty<string?> LabelTextProperty =
        AvaloniaProperty.Register<LabeledTextBox, string?>(
            "LabelText");

    public string? LabelText
    {
        get => GetValue(LabelTextProperty);
        set => SetValue(LabelTextProperty, value);
    }
}
