using Godot;
using System;

public partial class NSpineAutoPlayer : Node
{
  public override void _Ready()
  {
	MegaSprite sprite = new MegaSprite((Variant) (GodotObject) this.GetParent());
	this.RunWhenSpineReady(sprite, (Action<MegaAnimationState>) (animState =>
	{
	  IReadOnlyList<string> animationNames = sprite.GetSkeleton().GetData().GetAnimationNames();
	  if (animationNames.Count != 1)
		throw new InvalidOperationException($"{nameof (NSpineAutoPlayer)}'s parent's skeleton data must have exactly 1 animation. This has {animationNames.Count}.");
	  animState.SetAnimation(animationNames[0]);
	}));
  }

	public override void _Process(double delta)
	{
	}
  
	[EditorBrowsable(EditorBrowsableState.Never)]
  List<MethodInfo> GetGodotMethodList()
  {
	return new List<MethodInfo>(1)
	{
	  new MethodInfo(NSpineAutoPlayer.MethodName._Ready, new PropertyInfo(Variant.Type.Nil, (StringName) "", PropertyHint.None, "", PropertyUsageFlags.Default, false), MethodFlags.Normal, (List<PropertyInfo>) null, (List<Variant>) null)
	};
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected override bool InvokeGodotClassMethod(
	in godot_string_name method,
	NativeVariantPtrArgs args,
	out godot_variant ret)
  {
	if (!(ref method == NSpineAutoPlayer.MethodName._Ready) || args.Count != 0)
	  return base.InvokeGodotClassMethod(in method, args, out ret);
	this._Ready();
	ret = new godot_variant();
	return true;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected override bool HasGodotClassMethod(in godot_string_name method)
  {
	return ref method == NSpineAutoPlayer.MethodName._Ready || base.HasGodotClassMethod(in method);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected override void SaveGodotObjectData(GodotSerializationInfo info)
  {
	base.SaveGodotObjectData(info);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected override void RestoreGodotObjectData(GodotSerializationInfo info)
  {
	base.RestoreGodotObjectData(info);
  }
  public new class MethodName : Node.MethodName
  {
	public new static readonly StringName _Ready = (StringName) nameof (_Ready);
  }
  public new class PropertyName : Node.PropertyName
  {
  }

  public new class SignalName : Node.SignalName
  {
  }
}
