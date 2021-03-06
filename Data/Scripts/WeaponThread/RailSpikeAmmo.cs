﻿using static WeaponThread.WeaponStructure.WeaponDefinition;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.ShapeDef.Shapes;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.GraphicDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.TrajectoryDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.TrajectoryDef.GuidanceType;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.DamageScaleDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.DamageScaleDef.ShieldDef.ShieldType;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.AreaDamageDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.AreaDamageDef.AreaEffectType;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.GraphicDef.LineDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.GraphicDef.LineDef.Texture;
using static WeaponThread.WeaponStructure.WeaponDefinition.AmmoDef.GraphicDef.LineDef.TracerBaseDef;
namespace WeaponThread
{ // Don't edit above this line
    partial class Weapons
    {
        private AmmoDef RailSpikeAmmo => new AmmoDef
        {
            AmmoMagazine = "RailGunAmmoMag",
            AmmoRound = "RailSpikeAmmo",
                HybridRound = true, //AmmoMagazine based weapon with energy cost
                EnergyCost = 0.035f, //(((EnergyCost * DefaultDamage) * ShotsPerSecond) * BarrelsPerShot) * ShotsPerBarrel
                BaseDamage = 120000.5f,
                Mass = 1f, // in kilograms
                Health = 10, // 0 = disabled, otherwise how much damage it can take from other trajectiles before dying.
                BackKickForce = 3.2f,
				HardPointUsable = true, // set to false if this is a shrapnel ammoType and you don't want the turret to be able to select it directly.

                Shape = new ShapeDef //defines the collision shape of projectile, defaults line and visual Line Length if set to 0
                {
                    Shape = LineShape,
                    Diameter = 1,
                },
                ObjectsHit = new ObjectsHitDef
                {
                    MaxObjectsHit = 10000, // 0 = disabled
                    CountBlocks = false, // counts gridBlocks and not just entities hit
                },
                Shrapnel = new ShrapnelDef
				{
					AmmoRound = "",
					Fragments = 12,
					Degrees = 90,
					Reverse = false,
					RandomizeDir = false,
				},
				Pattern = new AmmoPatternDef
				{
					Ammos = new[] {
						"",
					},
					Enable = false,
					TriggerChance = 1f,
					Random = false,
					RandomMin = 1,
					RandomMax = 1,
					SkipParent = false,
				},
                DamageScales = new DamageScaleDef
                {
                    MaxIntegrity = 0f, // 0 = disabled, 1000 = any blocks with currently integrity above 1000 will be immune to damage.
                    DamageVoxels = true, // true = voxels are vulnerable to this weapon
                    SelfDamage = false, // true = allow self damage.

                    // modifier values: -1 = disabled (higher performance), 0 = no damage, 0.01 = 1% damage, 2 = 200% damage.
                    Characters = 1.2f,
					FallOff = new FallOffDef
					{
						Distance = 1000f, // Distance at which max damage begins falling off.
						MinMultipler = 0.25f, // value from 0.0f to 1f where 0.1f would be a min damage of 10% of max damage.
					},
                    Grids = new GridSizeDef
                    {
                        Large = -1f,
                        Small = -1f,
                    },
                    Armor = new ArmorDef
                    {
                        Armor = 0.9f,
                        Light = 1.3f,
                        Heavy = 1.1f,
                        NonArmor = 1f,
                    },
                    Shields = new ShieldDef
                    {
                        Modifier = 1f,
                        Type = Kinetic,
                        BypassModifier = -1f,
                    },
                    // first true/false (ignoreOthers) will cause projectiles to pass through all blocks that do not match the custom subtypeIds.
                    Custom = new CustomScalesDef
                    {
                        IgnoreAllOthers = false,
                        Types = new []
                        {
                            new CustomBlocksDef
                            {
                                SubTypeId = "Test1",
                                Modifier = -1f,
                            },
                            new CustomBlocksDef
                            {
                                SubTypeId = "Test2",
                                Modifier = -1f,
                            },
                        },
                    },
                },
                AreaEffect = new AreaDamageDef																																	  
                {
                    AreaEffect = Radiant, // Disabled = do not use area effect at all, Explosive, Radiant, AntiSmart, JumpNullField, JumpNullField, EnergySinkField, AnchorField, EmpField, OffenseField, NavField, DotField.
                    AreaEffectDamage = 500f, // 0 = use spillover from BaseDamage, otherwise use this value.
                    AreaEffectRadius = 70f,
                    Pulse = new PulseDef // interval measured in game ticks (60 == 1 second), pulseChance chance (0 - 100) that an entity in field will be hit
                {
                    Interval = 60,
                    PulseChance = 100,
                    GrowTime = 100,
                    HideModel = false,
                    ShowParticle = false,
                    Particle = new ParticleDef
                    {
                        Name = "", //ShipWelderArc
                        ShrinkByDistance = false,
                        Color = Color(red: 128, green: 0, blue: 0, alpha: 32),
                        Offset = Vector(x: 0, y: -1, z: 0),
                        Extras = new ParticleOptionDef
                        {
                            Loop = true,
                            Restart = false,
                            MaxDistance = 5000,
                            MaxDuration = 1,
                            Scale = 1,
                        },
                    },
                },
                    Explosions = new ExplosionDef
                    {
                        NoVisuals = false,
                        NoSound = false,
                        Scale = 1,
                        CustomParticle = "",
                        CustomSound = "",
                    },
                    Detonation = new DetonateDef
                    {
                        DetonateOnEnd = false,
                        ArmOnlyOnHit = false,
                        DetonationDamage = 1,
                        DetonationRadius = 1,
                    },
                    EwarFields = new EwarFieldsDef
                    {
                        Duration = 360,
                        StackDuration = true,
                        Depletable = false,
                        MaxStacks = 10,
                        TriggerRange = 5f,
                    },
                },
                Beams = new BeamDef
                {
                    Enable = false,
                    VirtualBeams = false, // Only one hot beam, but with the effectiveness of the virtual beams combined (better performace)
                    ConvergeBeams = false, // When using virtual beams this option visually converges the beams to the location of the real beam.
                    RotateRealBeam = false, // The real (hot beam) is rotated between all virtual beams, instead of centered between them.
                    OneParticle = false, // Only spawn one particle hit per beam weapon.
                },
                Trajectory = new TrajectoryDef
                {
                    Guidance = None,
                    TargetLossDegree = 180f,
                    TargetLossTime = 0, // 0 is disabled, Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    MaxLifeTime = 0, // 0 is disabled, Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    AccelPerSec = 0f,
                    DesiredSpeed = 1800,
                    MaxTrajectory = 3000f,
                    FieldTime = 0, // 0 is disabled, a value causes the projectile to come to rest, spawn a field and remain for a time (Measured in game ticks, 60 = 1 second)
                    GravityMultiplier = 0f, // Gravity multiplier, influences the trajectory of the projectile, value greater than 0 to enable.
                    SpeedVariance = Random(start: 0, end: 0), // subtracts value from DesiredSpeed
                    RangeVariance = Random(start: 0, end: 0), // subtracts value from MaxTrajectory
                    MaxTrajectoryTime = 0, // How long the weapon must fire before it reaches MaxTrajectory.
                    Smarts = new SmartsDef
                    {
                    Inaccuracy = 0.5f, // 0 is perfect, hit accuracy will be a random num of meters between 0 and this value.
                    Aggressiveness = 1f, // controls how responsive tracking is.
                    MaxLateralThrust = 0.5, // controls how sharp the trajectile may turn
                    TrackingDelay = 30, // Measured in Shape diameter units traveled.
                    MaxChaseTime = 1800, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    OverideTarget = true, // when set to true ammo picks its own target, does not use hardpoint's.
                    MaxTargets = 0, // Number of targets allowed before ending, 0 = unlimited
                    NoTargetExpire = false, // Expire without ever having a target at TargetLossTime
                    Roam = false, // Roam current area after target loss
                    },
                    Mines = new MinesDef
                    {
                        DetectRadius =  200,
                        DeCloakRadius = 100,
                        FieldTime = 1800,
                        Cloak = true,
                        Persist = false,
                    },
                },
                AmmoGraphics = new GraphicDef
                {
                    ModelName = "", //\\Models\\Ammo\\DeUrSpike.mwm
                    VisualProbability = 1f,
                    ShieldHitDraw = true,
                    Particles = new AmmoParticleDef
                    {
                        Ammo = new ParticleDef
                        {
                            Name = "", //ShipWelderArc
                        ShrinkByDistance = false,
                            Color = Color(red: 2, green: 2, blue: 8f, alpha: 10),
                            Offset = Vector(x: 0, y: 0, z: 0),
                            Extras = new ParticleOptionDef
                            {
                                Loop = true,
                                Restart = false,
                                MaxDistance = 2000,
                                MaxDuration = 1,
                                Scale = 1,
                            },
                        },
                        Hit = new ParticleDef
                        {
                            Name = "RailgunEnergyParticle",
                            ApplyToShield = true,
                            ShrinkByDistance = true,
                            Color = Color(red: 5, green: 5, blue: 80f, alpha: 10),
                            Offset = Vector(x: 0, y: 0, z: 0),
                            Extras = new ParticleOptionDef
                            {
                                Loop = false,
                                Restart = false,
                                MaxDistance = 1500,
                                MaxDuration = 0,
                                Scale = 1,
                                HitPlayChance = 1f,
                            },
                        },
                    },
                    Lines = new LineDef
                    {
                        TracerMaterial = "RailBolt", // WeaponLaser, ProjectileTrailLine, WarpBubble, etc..
                        ColorVariance = Random(start: 1f, end: 5f), // multiply the color by random values within range.
                        WidthVariance = Random(start: 0f, end: 0.045f), // adds random value to default width (negatives shrinks width)
                        Tracer = new TracerBaseDef
                        {
							Enable = true,
							Length = 16f,
							Width = 0.8f,
							Color = Color(red: 5.0f, green: 10, blue: 18.5f, alpha: 1f),
							VisualFadeStart = 0, // Number of ticks the weapon has been firing before projectiles begin to fade their color
							VisualFadeEnd = 0, // How many ticks after fade began before it will be invisible.
							Segmentation = new SegmentDef
							{
								Material = "ProjectileTrailLine",
								SegmentLength = 5f,
								SegmentGap = 3f,
								Speed = 15f,
								Color = Color(red: 5.0f, green: 10, blue: 18.5f, alpha: 1f),
								WidthMultiplier = 1f,
								Reverse = false,
								UseLineVariance = false,
								WidthVariance = Random(start: 0f, end: 0f),
								ColorVariance = Random(start: 0f, end: 0f)
							}
						},
                        Trail = new TrailDef
                        {
                            Enable = true,
                            Material = "WeaponLaser",
                            DecayTime = 40,
                            Color = Color(red: 5.0f, green: 10, blue: 18.5f, alpha: 1f),
                            Back = true,
                            CustomWidth = 0.3f,
                            UseWidthVariance = true,
                            UseColorFade = true,
                        },
                        OffsetEffect = new OffsetEffectDef
                        {
                            MaxOffset =  0,// 0 offset value disables this effect
                            MinLength = 1.1f,
                            MaxLength = 1.2f,
                        },
                    },
                },
                AmmoAudio = new AmmoAudioDef
                {
                    TravelSound = "",
                    HitSound = "ArcImpMetalRockCat0", //ArcImpMetalMetalCat0
					ShieldHitSound = "",
					PlayerHitSound = "",
					VoxelHitSound = "",
					FloatingHitSound = "",
					HitPlayChance = 0.5f,
					HitPlayShield = true,
                }, // Don't edit below this line


        };
    }
}

