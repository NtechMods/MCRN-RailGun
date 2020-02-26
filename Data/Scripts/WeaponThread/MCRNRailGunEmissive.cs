using System.Collections.Generic;
using static WeaponThread.WeaponStructure;
using static WeaponThread.WeaponStructure.PartAnimationSetDef.EventTriggers;
using static WeaponThread.WeaponStructure.RelMove.MoveType;
using static WeaponThread.Session;

namespace WeaponThread
{ // Don't edit above this line
    partial class Weapons
    {
        private AnimationDefinition MCRNRailGunEmissive => new AnimationDefinition
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
                new PartAnimationSetDef()
                {
                    SubpartId = Names("MissileTurretBarrels"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(Reloading, Overheated),
                    Loop = Events(Reloading, Overheated),
                    TriggerOnce = Events(),
					ResetEmissives = Events(Firing, Reloading),
                    EventMoveSets = new Dictionary<EventTriggers, RelMove[]>
                    {
                        
						[PreFire] =
                            new[] //Reloading, Firing, Tracking, Overheated, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire, EmptyOnGameLoad, StopFiring, StopTracking
								  //define a new[] for each animation section
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 240, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "PrefireEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						[Reloading] =
                            new[] //Reloading, Firing, Tracking, Overheated, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire, EmptyOnGameLoad, StopFiring, StopTracking
								  //define a new[] for each animation section
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 60, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "ChargingEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },						
						[StopFiring] =
                            new[] //Reloading, Firing, Tracking, Overheated, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire, EmptyOnGameLoad, StopFiring, StopTracking
								  //define a new[] for each animation section
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "StopFiringEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                        [Overheated] =
                            new[] //Reloading, Firing, Tracking, Overheated, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire, EmptyOnGameLoad, StopFiring, StopTracking
								  //define a new[] for each animation section
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 20, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Overheated",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },

            }
        };
    }
}
