using System.Collections.Generic;
using static WeaponThread.WeaponStructure;
using static WeaponThread.WeaponStructure.WeaponDefinition;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.RelMove.MoveType;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.RelMove;
namespace WeaponThread
{ // Don't edit above this line
    partial class Weapons
    {
        private AnimationDef MCRNRailGunEmissive => new AnimationDef
        {
			
			
			Emissives = new []
            {
				
				Emissive(
                    EmissiveName: "Emissive",
                    Colors: new []
                    {
                        Color(red:0, green: 0, blue:0, alpha: 0),//will transitions form one color to the next if more than one
                        Color(red:0.2f, green: 0.2f, blue:0.8f, alpha: 1),
                    }, 
                    IntensityFrom:0, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:1, 
                    CycleEmissiveParts: true,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: true,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive"
                    }),
				
				
				
                Emissive(
                    EmissiveName: "PrefireEmissive",
                    Colors: new []
                    {
                        Color(red:0, green: 0, blue:0, alpha: 0),//will transitions form one color to the next if more than one
                        Color(red:0.2f, green: 0.2f, blue:0.8f, alpha: 1),
                    }, 
                    IntensityFrom:0, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:1, 
                    CycleEmissiveParts: true,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: true,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive0",
                        "Emissive1",
                        "Emissive2",
                        "Emissive3",
                        "Emissive4",
                        "Emissive5",
                        "Emissive6"
                        
                    }),	

                Emissive(
                    EmissiveName: "StopFiringEmissive",
                    Colors: new []
                    {
                        Color(red:0, green: 0, blue:0, alpha: 0),//will transitions form one color to the next if more than one
                    }, 
                    IntensityFrom:0, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:0, 
                    CycleEmissiveParts: false,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: false,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive",
                        "Emissive0",
                        "Emissive1",
                        "Emissive2",
                        "Emissive3",
                        "Emissive4",
                        "Emissive5",
                        "Emissive6"
                        
                    }),
                Emissive(
                    EmissiveName: "ChargingEmissive",
                    Colors: new []
                    {
                        Color(red:0.0f, green: 0.0f, blue:0.9f, alpha: 1)
                    }, 
                    IntensityFrom:.5f, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:5, 
                    CycleEmissiveParts: false,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: false,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive"                        
                    }),
                Emissive(
                    EmissiveName: "Overheated",
                    Colors: new []
                    {
                        Color(red:255, green: 0, blue:0, alpha: 1),//will transitions form one color to the next if more than one
                    }, 
                    IntensityFrom:.1f, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:5f, 
                    CycleEmissiveParts: false,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: false,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive",
                        "Emissive0",
                        "Emissive1",
                        "Emissive2",
                        "Emissive3",
                        "Emissive4",
                        "Emissive5",
                        "Emissive6"
                        
                    }),			
            },
			
			
			
			
			
            WeaponAnimationSets = new[]
            {
                #region Barrels Animations
                new PartAnimationSetDef
                {
                    SubpartId = Names("MissileTurretBarrels"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts, OnFireDelay = delaying fire of weapon when turned on
                    Reverse = Events(Reloading, Overheated),
                    Loop = Events(Reloading, Overheated),
                    TriggerOnce = Events(),
					ResetEmissives = Events(Firing, Reloading),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [PreFire] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay,
                                    EmissiveName = "PrefireEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },


                            },
                        [Reloading] =
                            new[] //Firing, Reloading, Overheated, Tracking, Locked, OnOff define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 100, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay,
                                    EmissiveName = "ChargingEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                                

                            },
						[StopFiring] =
                            new[] //Firing, Reloading, Overheated, Tracking, Locked, OnOff define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 100, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay,
                                    EmissiveName = "StopFiringEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                                

                            },
						[Overheated] =
                            new[] //Firing, Reloading, Overheated, Tracking, Locked, OnOff define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 100, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay,
                                    EmissiveName = "Overheated",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },
                    }                             
                }, //EmptyOnLoad
				#endregion
            }
        };
    }
}
