namespace FillyFinagler;
public class Unlocks
{
	public class CollectedAttribute : Attribute { }
	public class GoldAttribute : CollectedAttribute { }
	public class GemAttribute : CollectedAttribute { }
	public class MiscCollectedAttribute : CollectedAttribute { }

	#region gold

	[Gold]
	public bool GoldSewer1;

	[Gold]
	public bool Sewers4Gold;

	[Gold]
	public bool GoldSlipperyTunnels;
	
	[Gold]
	public bool MinesIntroGold;
	
	[Gold]
	public bool WaterfallGold;
	
	[Gold]
	public bool SlipperyGold;
	
	[Gold]
	public bool WaterEscapeGold;

	[Gold]
	public bool MinesProperGold;
	
	[Gold]
	public bool MinesEnemyRushGold;
	
	[Gold]
	public bool CollapsedMineGold;
	
	[Gold]
	public bool CityGold;
	
	[Gold]
	public bool CityMoreGoal;
	
	[Gold]
	public bool ForestIntro2Gold;
	
	[Gold]
	public bool BirbsGold;
	
	[Gold]
	public bool ForestGold;
	
	[Gold]
	public bool WolfGold;
	
	[Gold]
	public bool BridgeGold;
	
	[Gold]
	public bool HoppiecavesGold;
	
	[Gold]
	public bool FallIntoAPitGold;
	
	[Gold]
	public bool BitchAssPlantGold;
	
	[Gold]
	public bool TimberGold;
	
	[Gold]
	public bool TowerFromForestGold;
	
	[Gold]
	public bool Tower2Gold;

	[Gold]
	public bool SuperSpecialGoldReward;

	[Gold]
	public bool SuperSpecialGoldReward1;

	[Gold]
	public bool SuperSpecialGoldReward2;

	#endregion

	#region gems
	[Gem]
	public bool BlueGem;
	[Gem]
	public bool GreenGem;
	[Gem]
	public bool RedGem;

	[Gem]
	public bool Burst;
	[Gem]
	public bool AirSpecial;
	[Gem]
	public bool Tackle;
	[Gem]
	public bool Mana1;
	[Gem]
	public bool Mana2;
	[Gem]
	public bool Mana3;
	[Gem]
	public bool Mana4;
	[Gem]
	public bool Mana5;

	[Gem]
	[Named("Cool Socks")]
	public bool CoolSocks;
	[Gem]
	[Named("PrettySocks")]
	public bool PrettySocks;
	[Gem]
	[Named("Cute Socks")]
	public bool CuteSocks;
	[Gem]
	[Named("Gold Socks")]
	public bool GoldSocks1;
	[Gem]
	[Named("GoldSocks")]
	public bool GoldSocks2;
	[Gem]
	[Named("Golden Socks")]
	public bool GoldenSocks1;
	[Gem]
	[Named("GoldenSocks")]
	public bool GoldenSocks;
	#endregion

	#region misc
	public bool Key;
	[MiscCollected]
	public bool Key1;
	[MiscCollected]
	public bool Key2;

	public bool Crystal;
	[MiscCollected]
	public bool Crystal1;
	[MiscCollected]
	public bool Crystal2;
	[MiscCollected]
	public bool Crystal3;

	public bool Plate;
	[MiscCollected]
	public bool Plate1;
	[MiscCollected]
	public bool Plate2;
	[MiscCollected]
	public bool Plate3;

	[MiscCollected]
	public bool Bracelet;
	#endregion
}
