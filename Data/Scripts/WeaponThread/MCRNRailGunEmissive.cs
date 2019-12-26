using System.Collections.Generic;
using static WeaponThread.Session.EventTriggers;
using static WeaponThread.Session.RelMove.MoveType;
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
                    EmissiveName: "Emissive0",
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
                        "Emissive0"
                    }),
					
				Emissive(
                    EmissiveName: "Emissive1",
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
                        "Emissive1"
                    }),
					
				Emissive(
                    EmissiveName: "Emissive2",
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
                        "Emissive2"
                    }),
					
				Emissive(
                    EmissiveName: "Emissive3",
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
                        "Emissive3"
                    }),
					
				Emissive(
                    EmissiveName: "Emissive4",
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
                        "Emissive4"
                    }),
					
				Emissive(
                    EmissiveName: "Emissive5",
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
                        "Emissive5"
                    }),
					
				Emissive(
                    EmissiveName: "Emissive6",
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
                    Reverse = Events(TurnOff, BurstReload, Firing),
                    Loop = Events(Overheated, Reloading),
                    TriggerOnce = Events(),
                    EventMoveSets = new Dictionary<EventTriggers, RelMove[]>
                    {
                        
						[PreFire] =
                            new[] //Reloading, Firing, Tracking, Overheated, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire, EmptyOnGameLoad, StopFiring, StopTracking
								  //define a new[] for each animation section
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 45, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 50, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive0",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 55, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive1",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 60, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive2",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 65, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive3",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 70, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive4",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },	
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 75, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive5",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 80, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive6",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						
						[TurnOff] =
                            new[] //Reloading, Firing, Tracking, Overheated, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire, EmptyOnGameLoad, StopFiring, StopTracking
								  //define a new[] for each animation section
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive0",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive1",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive2",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive3",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive4",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },	
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive5",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive6",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
						[Firing] =
                            new[] //Reloading, Firing, Tracking, Overheated, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire, EmptyOnGameLoad, StopFiring, StopTracking
								  //define a new[] for each animation section
                            {
                                
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive0",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive1",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive2",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive3",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive4",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },	
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive5",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive6",//name of defined emissive 
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
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive0",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive1",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive2",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive3",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive4",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },	
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive5",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive6",//name of defined emissive 
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
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive0",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive1",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive2",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive3",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive4",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },	
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive5",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive6",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
							
							
						[TurnOn] =
                            new[] //Reloading, Firing, Tracking, Overheated, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire, EmptyOnGameLoad, StopFiring, StopTracking
								  //define a new[] for each animation section
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
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
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive0",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive1",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive2",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive3",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive4",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },	
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive5",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 0), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
								new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth,  ExpoDecay, Linear, Delay, Show, Hide
                                    EmissiveName = "Emissive6",//name of defined emissive 
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
