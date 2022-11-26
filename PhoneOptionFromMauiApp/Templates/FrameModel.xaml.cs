namespace PhoneOptionFromMauiApp.Templates;

public partial class FrameModel : ContentView
{
	public FrameModel()
	{
		InitializeComponent();
	}

	public static BindableProperty SourceProperty =
		BindableProperty.Create(nameof(Source), typeof(string), typeof(FrameModel));

	public static BindableProperty Textproperty =
		BindableProperty.Create(nameof(Text), typeof(string), typeof(FrameModel));

	public static BindableProperty CommandFrameProperty =
		BindableProperty.Create(nameof(CommandFrame), typeof(Command), typeof(FrameModel));

	public string Source
	{
		get => (string)GetValue(SourceProperty); 
		set => SetValue(SourceProperty, value);
	}

	public string Text
	{
		get => (string)GetValue(Textproperty);
		set => SetValue(Textproperty, value);
	}

	public Command CommandFrame
	{
		get => (Command)GetValue(CommandFrameProperty);
		set => SetValue(CommandFrameProperty, value);
	}
}