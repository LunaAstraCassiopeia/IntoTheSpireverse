using BaseLib.Abstracts;
using Godot;

namespace IntoTheSpireverse.IntoTheSpireverseCode.Character;

public class ShadowSilentPotionPool : CustomPotionPoolModel
{
    public override string EnergyColorName => ShadowSilent.ShadowSilent.CharacterId;
    public override Color LabOutlineColor => ShadowSilent.ShadowSilent.Color;
}