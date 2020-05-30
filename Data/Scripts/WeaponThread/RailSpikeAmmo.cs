using static WeaponThread.WeaponStructure.WeaponDefinition;
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
                HybridRound = false, //AmmoMagazine based weapon with energy cost
                EnergyCost = 0.0002f, //(((EnergyCost * DefaultDamage) * ShotsPerSecond) * BarrelsPerShot) * ShotsPerBarrel
                BaseDamage = 120000f,
                Mass = 10f, // in kilograms
                Health = 150000, // 0 = disabled, otherwise how much damage it can take from other trajectiles before dying.
                BackKickForce = 4f,
            HardPointUsable = true, // set to false if this is a shrapnel ammoType and you don't want the turret to be able to select it directly.

                Shape = new ShapeDef //defines the collision shape of projectile, defaults line and visual Line Length if set to 0
                {
                    Shape = LineShape,
                    Diameter = 1,
                },
                ObjectsHit = new ObjectsHitDef
                {
                    MaxObjectsHit = 100000, // 0 = disabled
                    CountBlocks = true, // counts gridBlocks and not just entities hit
                },
                Shrapnel = new ShrapnelDef
                {
                AmmoRound = "",
                Fragments = 100,
                Degrees = 15,
                Reverse = false,
                RandomizeDir = false, // randomzie between forward and backward directions
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
                    DamageVoxels = false, // true = voxels are vulnerable to this weapon
                    SelfDamage = false, // true = allow self damage.

                    // modifier values: -1 = disabled (higher performance), 0 = no damage, 0.01 = 1% damage, 2 = 200% damage.
                    Characters = -1f,
                    Grids = new GridSizeDef
                    {
                        Large = -1f,
                        Small = -1f,
                    },
                    Armor = new ArmorDef
                    {
                        Armor = 1f,
                        Light = 1f,
                        Heavy = 0.8f,
                        NonArmor = 1.5f,
                    },
                    Shields = new ShieldDef
                    {
                        Modifier = 1f,
                        Type = Bypass,
                        BypassModifier = 0.5f,
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
                AreaEffect = Disabled, // Disabled = do not use area effect at all, Explosive, Radiant, AntiSmart, JumpNullField, JumpNullField, EnergySinkField, AnchorField, EmpField, OffenseField, NavField, DotField.
                AreaEffectDamage = 0f, // 0 = use spillover from BaseDamage, otherwise use this value.
                AreaEffectRadius = 0f,
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
                    DetonationDamage = 1000000,
                    DetonationRadius = 75,
                },
                EwarFields = new EwarFieldsDef
                {
                    Duration = 0,
                    StackDuration = false,
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
                    TargetLossDegree = 50f,
                    TargetLossTime = 0, // 0 is disabled, Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    MaxLifeTime = 0, // 0 is disabled, Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    AccelPerSec = 0f,
                    DesiredSpeed = 1000f,
                    MaxTrajectory = 10000f,
                    FieldTime = 0, // 0 is disabled, a value causes the projectile to come to rest, spawn a field and remain for a time (Measured in game ticks, 60 = 1 second)
                    SpeedVariance = Random(start: 0, end: 0), // subtracts value from DesiredSpeed
                    RangeVariance = Random(start: 0, end: 0), // subtracts value from MaxTrajectory
					MaxTrajectoryTime = 120, // How long the weapon must fire before it reaches MaxTrajectory.
                    Smarts = new SmartsDef
                    {
                    Inaccuracy = 0f, // 0 is perfect, hit accuracy will be a random num of meters between 0 and this value.
                    Aggressiveness = 1f, // controls how responsive tracking is.
                    MaxLateralThrust = 0.5, // controls how sharp the trajectile may turn
                    TrackingDelay = 1, // Measured in Shape diameter units traveled.
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
                    ModelName = "\\Models\\Ammo\\DeUrSpike.mwm",
                    VisualProbability = 1f,
                    ShieldHitDraw = true,
                    Particles = new AmmoParticleDef
                    {
                        Ammo = new ParticleDef
                        {
                            Name = "EnergyBubble", //ShipWelderArc
                        ShrinkByDistance = false,
                            Color = Color(red: 0.2f, green: 0.2f, blue: 0.8f, alpha: 1),
                            Offset = Vector(x: 0, y: -1, z: 0),
                            Extras = new ParticleOptionDef
                            {
                                Loop = true,
                                Restart = false,
                                MaxDistance = 5000,
                                MaxDuration = 1,
                                Scale = 3f,
                            },
                        },
                        Hit = new ParticleDef
                        {
                            Name = "RailgunEnergyParticle",
                            ApplyToShield = true,
                            ShrinkByDistance = true,
                            Color = Color(red: 22f, green: 22f, blue: 88f, alpha: 1),
                            Offset = Vector(x: 0, y: 0, z: 0),
                            Extras = new ParticleOptionDef
                            {
                                Loop = false,
                                Restart = false,
                                MaxDistance = 5000,
                                MaxDuration = 1,
                                Scale = 0.8f,
                                HitPlayChance = 1f,
                            },
                        },
                    },
                    Lines = new LineDef
                    {
                        TracerMaterial = "ProjectileTrailLine", // WeaponLaser, ProjectileTrailLine, WarpBubble, etc..
                        ColorVariance = Random(start: 5f, end: 10f), // multiply the color by random values within range.
                        WidthVariance = Random(start: 0f, end: 0.045f), // adds random value to default width (negatives shrinks width)
                        Tracer = new TracerBaseDef
                        {
                            Enable = true,
                            Length = 240f,
                            Width = 0.55f,
                            Color = Color(red: 0.2f, green: 0.2f, blue: 0.8f, alpha: 1),
							VisualFadeStart = 0, // Number of ticks the weapon has been firing before projectiles begin to fade their color
							VisualFadeEnd = 0, // How many ticks after fade began before it will be invisible.
							Textures = new[] {// WeaponLaser, ProjectileTrailLine, WarpBubble, etc..
								"WeaponLaser",
							},
							TextureMode = Normal, // Normal, Cycle, Chaos, Wave
							Segmentation = new SegmentDef
							{
								Enable = true, // If true Tracer TextureMode is ignored
								Textures = new[] {
									"WeaponLaser",
								},
								SegmentLength = 30f, // Uses the values below.
								SegmentGap = 0f, // Uses Tracer textures and values
								Speed = 150f, // meters per second
								Color = Color(red: 1, green: 2, blue: 2.5f, alpha: 1),
								WidthMultiplier = 1f,
								Reverse = false,
								UseLineVariance = true,
								WidthVariance = Random(start: 0f, end: 0f),
								ColorVariance = Random(start: 0f, end: 0f)
							}
						},
						Trail = new TrailDef
						{
							Enable = false,
							Textures = new[] {
								"WeaponLaser",
							},
							TextureMode = Normal,
							DecayTime = 128,
							Color = Color(red: 0, green: 0, blue: 1, alpha: 1),
							Back = false,
							CustomWidth = 0,
							UseWidthVariance = false,
							UseColorFade = true,
						},
						OffsetEffect = new OffsetEffectDef
						{
							MaxOffset = 0,// 0 offset value disables this effect
							MinLength = 0.2f,
							MaxLength = 3,
						},
                    },
                },
                AmmoAudio         = new AmmoAudioDef
                {
                    TravelSound = "RealToolLrgGrindMetal",
                    HitSound = "WepSmallWarheadExpl",
                    HitPlayChance = 1f,
                    HitPlayShield = true,
                }, // Don't edit below this line
            

        };
    }
}
