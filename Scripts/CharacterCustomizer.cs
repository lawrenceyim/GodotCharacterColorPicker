using Godot;

public partial class CharacterCustomizer : Node2D
{
	[Export] private Sprite2D fullBody;
	[Export] private Sprite2D head;
	[Export] private Sprite2D torso;
	[Export] private Sprite2D legs;
	private Sprite2D[] bodyParts;

	public override void _Ready()
	{
		bodyParts = new Sprite2D[4];
		bodyParts[(int)BodyPart.FullBody] = fullBody;
		bodyParts[(int)BodyPart.Head] = head;
		bodyParts[(int)BodyPart.Torso] = torso;
		bodyParts[(int)BodyPart.Legs] = legs;
	}

	public void SetBodyPartColor(BodyPart bodyPart, Color color)
	{
		bodyParts[(int)bodyPart].SelfModulate = color;
	}
}

public enum BodyPart
{
	FullBody = 0,
	Head = 1,
	Torso = 2,
	Legs = 3
}