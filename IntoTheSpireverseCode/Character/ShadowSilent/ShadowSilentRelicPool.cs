using BaseLib.Abstracts;
using Godot;
using IntoTheSpireverse.IntoTheSpireverseCode.Relics;
using MegaCrit.Sts2.Core.Models;

namespace IntoTheSpireverse.IntoTheSpireverseCode.Character;

public class ShadowSilentRelicPool : CustomRelicPoolModel
{
    public override string EnergyColorName => ShadowSilent.ShadowSilent.CharacterId;
    public override Color LabOutlineColor => ShadowSilent.ShadowSilent.Color;
    
    
    protected override IEnumerable<RelicModel> GenerateAllRelics()
    {
        return new List<RelicModel>([
            //starter
            ModelDb.Relic<MysticCharm>(),
            //common
            ModelDb.Relic<WiltedRose>(),
            //uncommon
            ModelDb.Relic<Gambeson>(),
            ModelDb.Relic<PrayerBeads>(),
            //rare
            ModelDb.Relic<ArmoredCore>(),
            ModelDb.Relic<SistersCrown>(),
            ModelDb.Relic<PaperSnecko>(),
            //shop
            ModelDb.Relic<Mithridatium>(),
        ]);
    }
}