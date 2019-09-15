﻿using static WeaponThread.Session.ShieldDefinition.ShieldType;
using static WeaponThread.Session.AmmoTrajectory.GuidanceType;
using static WeaponThread.Session.HardPointDefinition.Prediction;
using static WeaponThread.Session.AreaDamage.AreaEffectType;
using static WeaponThread.Session.TargetingDefinition.BlockTypes;
using static WeaponThread.Session.TargetingDefinition.Threat;
using static WeaponThread.Session.Shrapnel.ShrapnelShape;
using static WeaponThread.Session.ShapeDefinition.Shapes;
using static WeaponThread.Session;

namespace WeaponThread
{   // Don't edit above this line
    partial class Weapons { WeaponDefinition RailGunMCRN => new WeaponDefinition {
    Assignments = new ModelAssignments
    {
        MountPoints = new[]
        {   
            MountPoint(subTypeId: "MCRNRailGunLB", aimPartId: "MissileTurretBarrels", muzzlePartId: "MissileTurretBarrels"),
        },
        Barrels = Names("muzzle_missile_001")
    },
    HardPoint = new HardPointDefinition
    {
        WeaponId = "RailGunMCRN", // name of weapon in terminal
        AmmoMagazineId = "RailGunAmmoMag",
        Block = AimControl(trackTargets: true, turretAttached: true, turretController: true, rotateRate: 0.01f, elevateRate: 0.01f),
        DeviateShotAngle = 0f,
        AimingTolerance = 2f, // 0 - 180 firing angle
        EnergyCost = 0.00000000001f, //(((EnergyCost * DefaultDamage) * ShotsPerSecond) * BarrelsPerShot) * ShotsPerBarrel
        Hybrid = false, //projectile based weapon with energy cost
        EnergyPriority = 0, //  0 = Lowest shares power with shields, 1 = Medium shares power with thrusters and over powers shields, 2 = Highest Does not share power will use all available power until energy requirements met
        RotateBarrelAxis = 0, // 0 = off, 1 = xAxis, 2 = yAxis, 3 = zAxis
        AimLeadingPrediction = Advanced, // Off, Basic, Accurate, Advanced
        DelayCeaseFire = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
        GridWeaponCap = 1, // 0 = unlimited, the smallest weapon cap assigned to a subTypeId takes priority.
        Ui = Display(rateOfFire: true, damageModifier: true, toggleGuidance: false, enableOverload: true),

        Loading = new AmmoLoading
        {
            RateOfFire = 40,
            BarrelsPerShot = 1,
            TrajectilesPerBarrel = 1, // Number of Trajectiles per barrel per fire event.
            SkipBarrels = 0,
            ReloadTime = 240, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
            DelayUntilFire = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
            HeatPerShot = 1, //heat generated per shot
            MaxHeat = 37000, //max heat before weapon enters cooldown (70% of max heat)
            Cooldown = .95f, //percent of max heat to be under to start firing again after overheat accepts .2-.95
            HeatSinkRate = 200, //amount of heat lost per second
            DegradeROF = true, // progressively lower rate of fire after 80% heat threshold (80% of max heat)
            ShotsInBurst = 1,
            DelayAfterBurst = 60, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
        },
    },
    Targeting = new TargetingDefinition
    {
        Threats = Valid(Characters, Projectiles, Grids),
        SubSystems = Priority(Navigation, Defense, Offense, Power, Production, Any), //define block type targeting order
        ClosestFirst = true, // tries to pick closest targets first (blocks on grids, projectiles, etc...).
        MinimumDiameter = 10, // 0 = unlimited, Minimum radius of threat to engage.
        MaximumDiameter = 600, // 0 = unlimited, Maximum radius of threat to engage.
        TopTargets = 4, // 0 = unlimited, max number of top targets to randomize between.
        TopBlocks = 4, // 0 = unlimited, max number of blocks to randomize between
        StopTrackingSpeed = 1000, // do not track target threats traveling faster than this speed
    },
    DamageScales = new DamageScaleDefinition
    {
        MaxIntegrity = 0f, // 0 = disabled, 1000 = any blocks with currently integrity above 1000 will be immune to damage.
        DamageVoxels = true, // true = voxels are vulnerable to this weapon
        SelfDamage = false, // true = allow self damage.

        // modifier values: -1 = disabled (higher performance), 0 = no damage, 0.01 = 1% damage, 2 = 200% damage.
        Characters = -1f,
        Grids = Options(largeGridModifier: -1f, smallGridModifier: -1f),
        Armor = Options(armor: -1f, light: -1f, heavy: -1f, nonArmor: -1f),
        Shields = Options(modifier: 0.1f, type: Kinetic), // Types: Kinetic, Energy, Emp or Bypass

        // first true/false (ignoreOthers) will cause projectiles to pass through all blocks that do not match the custom subtypeIds.
        Custom = SubTypeIds(false, Block(subTypeId: "Test1", modifier: -1), Block(subTypeId: "Test2", modifier: -1)),
    },
    Ammo = new AmmoDefinition
    {
        BaseDamage = 1f,
        Mass = 0f, // in kilograms
        Health = 0, // 0 = disabled, otherwise how much damage it can take from other trajectiles before dying.
        BackKickForce = 0f,
        Shape = Options(shape: Line, diameter: 0), //defines the collision shape of projectile, defaults line and visual Line Length if set to 0
        ObjectsHit = Options(maxObjectsHit: 0, countBlocks: false), // 0 = disabled, value determines max objects (and/or blocks) penetrated per hit
        Shrapnel = Options(baseDamage: 1, fragments: 0, maxTrajectory: 100, noAudioVisual: true, noGuidance: true, shape: HalfMoon),

        AreaEffect = new AreaDamage
        {
            AreaEffect = Disabled, // Disabled = do not use area effect at all, Explosive, Radiant, AntiSmart, Anchor, JumpNullField, EnergySink, EmpPulse.
            AreaEffectDamage = 0f, // 0 = use spillover from BaseDamage, otherwise use this value.
            AreaEffectRadius = 0f,
            Pulse = Options(interval: 60, pulseChance: 15), // interval measured in game ticks (60 == 1 second), pulseChance chance (0 - 100) that an entity in field will be hit
            Explosions = Options(noVisuals: false, noSound: false, scale: 1, customParticle: "", customSound: ""),
            Detonation = Options(detonateOnEnd: true, armOnlyOnHit: false, detonationDamage: 999999, detonationRadius: 75),
            EwarFields = Options(duration: 600, stackDuration: true, depletable: true)
        },
        Beams = new BeamDefinition
        {
            Enable = true,
            VirtualBeams = true, // Only one hot beam, but with the effectiveness of the virtual beams combined (better performace)
            ConvergeBeams = false, // When using virtual beams this option visually converges the beams to the location of the real beam.
            RotateRealBeam = false, // The real (hot beam) is rotated between all virtual beams, instead of centered between them.
            OneParticle = true, // Only spawn one particle hit per beam weapon.
        },
        Trajectory = new AmmoTrajectory
        {
            Guidance = None,
            TargetLossDegree = 80f,
            TargetLossTime = 0, // 0 is disabled, Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
            AccelPerSec = 40f,
            DesiredSpeed = 10f,
            MaxTrajectory = 5000f,
            RestTime = 0, // 0 is disabled, a value causes the projectile to come to rest and remain for a time (Measured in game ticks, 60 = 1 second)
            SpeedVariance = Random(start: 0, end: 0), // subtracts value from DesiredSpeed
            RangeVariance = Random(start: 0, end: 0), // subtracts value from MaxTrajectory
            Smarts = new Smarts
            {
                Inaccuracy = 0f, // 0 is perfect, hit accuracy will be a random num of meters between 0 and this value.
                Aggressiveness = 1f, // controls how responsive tracking is.
                MaxLateralThrust = 0.5, // controls how sharp the trajectile may turn
                TrackingDelay = 1, // Measured in Shape diameter units traveled.
                MaxChaseTime = 1800, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
            },
        },
    },
    Graphics = new GraphicDefinition
    {
        ModelName = "",
        VisualProbability = 1f,
        ShieldHitDraw = false,
        Particles = new ParticleDefinition
        {
            Ammo = new Particle
            {
                Name = "RailgunEnergyParticle", //ShipWelderArc
                Color = Color(red: 150, green: 0, blue: 255, alpha: 32),
                Offset = Vector(x: 0, y: 0, z: 0),
                Extras = Options(loop: true, restart: false, distance: 5000, duration: 1, scale: 0.2f)
            },
            Hit = new Particle
            {
                Name = "ShipWelderArc",
                Color = Color(red: 243, green: 190, blue: 51, alpha: 1),
                Offset = Vector(x: 0, y: 0, z: 0),
                Extras = Options(loop: false, restart: false, distance: 5000, duration: 1, scale: 1.5f),
            },
            Barrel1 = new Particle
            {
                Name = "", // Smoke_LargeGunShot
                Color = Color(red: 255, green: 0, blue: 0, alpha: 1),
                Offset = Vector(x: 0, y: -1, z: 0),
                Extras = Options(loop: false, restart: false, distance: 50, duration: 6, scale: 1f),
            },
            Barrel2 = new Particle
            {
                Name = "",//Muzzle_Flash_Large
                Color = Color(red: 10, green: 0, blue: 0, alpha: 1),
                Offset = Vector(x: 0, y: -1, z: 0),
                Extras = Options(loop: false, restart: false, distance: 150, duration: 6, scale: 1f),
            },
        },
        Line = new LineDefinition
        {
            Tracer = Base(enable: true, length: 10f, width: 0.15f, color: Color(red: 150, green: 0, blue: 255, alpha: 8)),
            TracerMaterial = "WeaponLaser", // WeaponLaser, ProjectileTrailLine, WarpBubble, etc..
            ColorVariance = Random(start: 0.75f, end: 2f), // multiply the color by random values within range.
            WidthVariance = Random(start: 0f, end: 0.15f), // adds random value to default width (negatives shrinks width)
            Trail = Options(enable: true, material: "WeaponLaser", decayTime: 15, color: Color(red: 32, green: 32, blue: 64, alpha: 1)),
            OffsetEffect = Options(maxOffset: 0.3, minLength: 0.03, maxLength: 0.3), // 0 offset value disables this effect
        },
        Emissive = new EmissiveDefinition
        {
            Heating = Options(enable: true),
            Tracking = Options(enable: true, color: Color(red: 255, green: 0, blue: 0, alpha: 1)),
            Reloading = Options(enable: true, color: Color(red: 255, green: 0, blue: 0, alpha: 1), pulse: false),
            Firing = Options(enable: true, stages: 1, color: Color(red: 255, green: 0, blue: 0, alpha: 1)),
        },
    },
    Audio = new AudioDefinition
    {
        HardPoint = new AudioHardPointDefinition
        {
            FiringSound = "", // WepShipGatlingShot
            FiringSoundPerShot = true,
            ReloadSound = "",
            NoAmmoSound = "",
            HardPointRotationSound = "WepTurretGatlingRotate",
            BarrelRotationSound = "WepShipGatlingRotation",
        },

        Ammo = new AudioAmmoDefinition
        {
            TravelSound = "",
            HitSound = "",
        }, // Don't edit below this line
    },
};}}