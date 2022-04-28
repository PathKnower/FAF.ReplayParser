namespace FAF.ReplayParser.Core.Models.RawReplay
{
    internal enum ReplayContentCommand
    {
        Advance = 0,
        SetCommandSource = 1,
        CommandSourceTerminated = 2,
        VerifyChecksum = 3,
        RequestPause = 4,
        Resume = 5,
        SingleStep = 6,
        CreateUnit = 7,
        CreateProp = 8,
        DestroyEntity = 9,
        WarpEntity = 10,
        ProcessInfoPair = 11,
        IssueCommand = 12,
        IssueFactoryCommand = 13,
        IncreaseCommandCount = 14,
        DecreaseCommandCount = 15,
        SetCommandTarget = 16,
        SetCommandType = 17,
        SetCommandCells = 18,
        RemoveCommandFromQueue = 19,
        DebugCommand = 20,
        ExecuteLuaInSim = 21,
        LuaSimCallback = 22,
        EndGame = 23
    }
}
