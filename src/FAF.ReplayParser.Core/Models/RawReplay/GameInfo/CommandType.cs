using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAF.ReplayParser.Core.Models.RawReplay.GameInfo
{
    internal enum CommandType
    {
        None = 0,
        Stop = 1,
        Move = 2,
        Dive = 3,
        FormMove = 4,
        BuildSiloTactical = 5,
        BuildSiloNuke = 6,
        BuildFactory = 7,
        BuildMobile = 8,
        BuildAssist = 9,
        Attack = 10,
        FormAttack = 11,
        Nuke = 12,
        Tactical = 13,
        Teleport = 14,
        Guard = 15,
        Patrol = 16,
        Ferry = 17,
        FormPatrol = 18,
        Reclaim = 19,
        Repair = 20,
        Capture = 21,
        TransportLoadUnits = 22,
        TransportReverseLoadUnits = 23,
        TransportUnloadUnits = 24,
        TransportUnloadSpecificUnits = 25,
        DetachFromTransport = 26,
        Upgrade = 27,
        Script = 28,
        AssistCommander = 29,
        KillSelf = 30,
        DestroySelf = 31,
        Sacrifice = 32,
        Pause = 33,
        OverCharge = 34,
        AggressiveMove = 35,
        FormAggressiveMove = 36,
        AssistMove = 37,
        SpecialAction = 38,
        Dock = 39
    }
}
