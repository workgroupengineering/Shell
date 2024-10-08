using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace ShellBottomCustomNavigator.Views;

public partial class PetsTabControlView : TabControl
{
	protected override Type StyleKeyOverride => typeof(TabControl);

	public PetsTabControlView()
	{
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}

	public string Icon => "fa-solid fa-paw";
}

