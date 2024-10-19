using Godot;

public partial class CharacterCustomizationMenu : Node2D
{
	[Export] private CharacterCustomizer characterCustomizer;
	private BodyPart selectedBodyPart = BodyPart.FullBody;

	#region Body Part Setter
	private void _on_button__full_body_pressed()
	{
		selectedBodyPart = BodyPart.FullBody;
	}

	private void _on_button__legs_pressed()
	{
		selectedBodyPart = BodyPart.Legs;
	}
	#endregion

	#region Color Setter
	private void _on_button__black_pressed()
	{
		characterCustomizer.SetBodyPartColor(selectedBodyPart, new Color(0, 0, 0));
	}

	private void _on_button__blue_pressed()
	{
		characterCustomizer.SetBodyPartColor(selectedBodyPart, new Color(0, 0, 1));
	}

	private void _on_button__red_pressed()
	{
		characterCustomizer.SetBodyPartColor(selectedBodyPart, new Color(1, 0, 0));
	}
	#endregion
}
