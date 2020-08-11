namespace Sapphire.Common.Packets
{
  ////////////////////////////////////////////////////////////////////////////////
  /// Lobby Connection IPC Codes
  /**
  * Server IPC Lobby Type Codes.
  */
  enum ServerLobbyIpcType : ushort
  {
    LobbyError = 0x0002,
    LobbyServiceAccountList = 0x000C,
    LobbyCharList = 0x000D,
    LobbyCharCreate = 0x000E,
    LobbyEnterWorld = 0x000F,
    LobbyServerList = 0x0015,
    LobbyRetainerList = 0x0017,
  };

  /**
  * Client IPC Lobby Type Codes.
  */
  enum ClientLobbyIpcType : ushort
  {
    ReqCharList = 0x0003,
    ReqEnterWorld = 0x0004,
    ClientVersionInfo = 0x0005,

    ReqCharDelete = 0x000A,
    ReqCharCreate = 0x000B,
  };

  ////////////////////////////////////////////////////////////////////////////////
  /// Zone Connection IPC Codes
  /**
  * Server IPC Zone Type Codes.
  */
  enum ServerZoneIpcType : ushort
  {
    Ping = 0x017A, // updated 5.25
    Init = 0x03B9, // updated 5.25

    ActorFreeSpawn = 0x022F, // updated 5.3
    InitZone = 0x0388, // updated 5.3

    EffectResult = 0x030F, // updated 5.25
    ActorControl = 0x0344, // updated 5.3
    ActorControlSelf = 0x0212, // updated 5.3
    ActorControlTarget = 0x01EB, // updated 5.25

    /*!
     * @brief Used when resting
     */
    UpdateHpMpTp = 0x00F8, // updated 5.25

    ///////////////////////////////////////////////////

    //ChatBanned = 0x006B,
    Playtime = 0x0207, // updated 5.3
    Logout = 0x00CD, // updated 5.25
    CFNotify = 0x00FD, // updated 5.3
    //CFMemberStatus = 0x0079,
    //CFDutyInfo = 0x007A,
    //CFPlayerInNeed = 0x007F,
    CFPreferredRole = 0x013C, // updated 5.3

    //SocialRequestError = 0x00AD,

    //CFRegistered = 0x00B8, // updated 4.1
    //SocialRequestResponse = 0x00BB, // updated 4.1
    //CancelAllianceForming = 0x00C6, // updated 4.2

    //LogMessage = 0x00D0,

    //Chat = 0x012B, // updated 5.21 hotfix

    //WorldVisitList = 0x00FE, // added 4.5

    SocialList = 0x0269, // updated 5.25

    ExamineSearchInfo = 0x03A1, // updated 5.3
    UpdateSearchInfo = 0x009E, // updated 5.3
    InitSearchInfo = 0x0347, // updated 5.25
    //ExamineSearchComment = 0x0102, // updated 4.1

    //ServerNoticeShort = 0x0115, // updated 5.0
    ServerNotice = 0x00E9, // updated 5.25
    SetOnlineStatus = 0x0381, // updated 5.25

    //CountdownInitiate = 0x0309, // updated 5.11
    //CountdownCancel = 0x00D9, // updated 5.18

    //PlayerAddedToBlacklist = 0x033F, // updated 5.1
    //PlayerRemovedFromBlacklist = 0x0385, // updated 5.1
    BlackList = 0x027A, // updated 5.25

    LinkshellList = 0x00A9, // updated 5.25

    //MailDeleteRequest = 0x012B, // updated 5.0

    // 12D - 137 - constant gap between 4.5x -> 5.0
    //ReqMoogleMailList = 0x0138, // updated 5.0
    //ReqMoogleMailLetter = 0x0139, // updated 5.0
    //MailLetterNotification = 0x013A, // updated 5.0

    MarketBoardSearchResult = 0x02D8, // updated 5.25
    MarketBoardItemListingCount = 0x016C, // updated 5.3
    MarketBoardItemListingHistory = 0x03BB, // updated 5.3
    MarketBoardItemListing = 0x0233, // updated 5.3
    MarketTaxRates = 0x00C6, // updated 5.3

    //CharaFreeCompanyTag = 0x013B, // updated 4.5
    //FreeCompanyBoardMsg = 0x013C, // updated 4.5
    //FreeCompanyInfo = 0x013D, // updated 4.5
    //ExamineFreeCompanyInfo = 0x013E, // updated 4.5

    //FreeCompanyUpdateShortMessage = 0x0157, // added 5.0

    StatusEffectList = 0x01D7, // updated 5.25
    //EurekaStatusEffectList = 0x0167, // updated 5.18
    //BossStatusEffectList = 0x01F5, // updated 5.21 hotfix
    Effect = 0x00F4, // updated 5.3
    AoeEffect8 = 0x00C9, // updated 5.3
    AoeEffect16 = 0x03BF, // updated 5.3
    AoeEffect24 = 0x027E, // updated 5.3
    AoeEffect32 = 0x017E, // updated 5.3
    PersistantEffect = 0x032E, // updated 5.25

    //GCAffiliation = 0x016F, // updated 5.0

    PlayerSpawn = 0x038E, // updated 5.3
    NpcSpawn = 0x0083, // updated 5.3
    NpcSpawn2 = 0x01CB, // updated 5.3
    ActorMove = 0x0352, // updated 5.3

    ActorSetPos = 0x02A5, // updated 5.3

    ActorCast = 0x00E7, // updated 5.3
    //SomeCustomiseChangePacketProbably = 0x00CD, // added 5.18

    //PartyList = 0x0287, // updated 5.18
    HateRank = 0x012E, // updated 5.25
    HateList = 0x02C4, // updated 5.25
    ObjectSpawn = 0x00D2, // updated 5.25
    //ObjectDespawn = 0x034B, // updated 5.18
    UpdateClassInfo = 0x039A, // updated 5.3
    //SilentSetClassJob = 0x018E, // updated 5.0 - seems to be the case, not sure if it's actually used for anything
    PlayerSetup = 0x00D4, // updated 5.3
    PlayerStats = 0x007C, // updated 5.25
    ActorOwner = 0x0149, // updated 5.25
    PlayerStateFlags = 0x0125, // updated 5.25
    PlayerClassInfo = 0x034F, // updated 5.25
    CharaVisualEffect = 0x0258, // updated 5.25

    ModelEquip = 0x01E5, // updated 5.25
    Examine = 0x03C4, // updated 5.3
    CharaNameReq = 0x011B, // updated 5.25

    // nb: see #565 on github
    //UpdateRetainerItemSalePrice = 0x019F, // updated 5.0
    //RetainerSaleHistory = 0x020E, // updated 5.21 hotfix
    RetainerInformation = 0x02B0, // updated 5.3

    //SetLevelSync = 0x1186, // not updated for 4.4, not sure what it is anymore

    ItemInfo = 0x02A4, // updated 5.3
    ContainerInfo = 0x02A8, // updated 5.25
    InventoryTransactionFinish = 0x0193, // updated 5.25
    InventoryTransaction = 0x0119, // updated 5.25
    CurrencyCrystalInfo = 0x00D7, // updated 5.3

    InventoryActionAck = 0x01AE, // updated 5.25
    UpdateInventorySlot = 0x036A, // updated 5.3

    //HuntingLogEntry = 0x01B3, // updated 5.0

    EventPlay = 0x0379, // updated 5.3
    EventPlay4 = 0x030B, // updated 5.3
    EventPlay8 = 0x014C,   // updated 5.25
    EventPlay16 = 0x0074,   // updated 5.25
    EventPlay32 = 0x02D9,  // updated 5.25
    EventPlay64 = 0x0388,  // updated 5.25
    EventPlay128 = 0x03A4, // updated 5.25
    EventPlay255 = 0x01AC, // updated 5.25

    EventStart = 0x020D, // updated 5.3
    EventFinish = 0x00DF, // updated 5.3

    UseMooch = 0x00C5, // updated 5.3

    //EventLinkshell = 0x1169,

    QuestActiveList = 0x0391, // updated 5.25
    QuestUpdate = 0x0352, // updated 5.25
    QuestCompleteList = 0x0231, // updated 5.25

    QuestFinish = 0x01FE, // updated 5.21 hotfix
    //MSQTrackerComplete = 0x01D6, // updated 5.0
    //MSQTrackerProgress = 0xF1CD, // updated 4.5 ? this actually looks like the two opcodes have been combined, see #474

    QuestMessage = 0x0093, // updated 5.25

    QuestTracker = 0x00AD, // updated 5.25

    Mount = 0x02BE, // updated 5.25

    //DirectorVars = 0x00E6, // updated 5.18
    //SomeDirectorUnk1 = 0x0084, // updated 5.18
    //SomeDirectorUnk2 = 0x00C1, // updated 5.18
    SomeDirectorUnk4 = 0x01DF, // updated 5.3
    //SomeDirectorUnk8 = 0x028A, // updated 5.18
    //SomeDirectorUnk16 = 0x028C, // updated 5.18
    //DirectorPopUp = 0x0162, // updated 5.18 - display dialogue pop-ups in duties and FATEs, for example, Teraflare's countdown
    //DirectorPopUp4 = 0x0214, // updated 5.18
    //DirectorPopUp8 = 0x00F8, // updated 5.18

    //CFAvailableContents = 0xF1FD, // updated 4.2

    WeatherChange = 0x0157, // updated 5.25
    //PlayerTitleList = 0x037D, // updated 5.1
    //Discovery = 0x0091, // updated 5.2

    //EorzeaTimeOffset = 0x03B8, // updated 5.1

    EquipDisplayFlags = 0x010D, // updated 5.25

    /// Housing //////////////////////////////////////

    //LandSetInitialize = 0x0234, // updated 5.0
    //LandUpdate = 0x0235, // updated 5.0
    //YardObjectSpawn = 0x0236, // updated 5.0
    //HousingIndoorInitialize = 0x0237, // updated 5.0
    //LandPriceUpdate = 0x0238, // updated 5.0
    //LandInfoSign = 0x0239, // updated 5.0
    //LandRename = 0x023A, // updated 5.0
    //HousingEstateGreeting = 0x023B, // updated 5.0
    //HousingUpdateLandFlagsSlot = 0x023C, // updated 5.0
    HousingLandFlags = 0x0177, // updated 5.25
    //HousingShowEstateGuestAccess = 0x023E, // updated 5.0

    //HousingObjectInitialize = 0x0240, // updated 5.0
    //HousingInternalObjectSpawn = 0x241, // updated 5.0

    //HousingWardInfo = 0x0243, // updated 5.0
    //HousingObjectMove = 0x0244, // updated 5.0

    //SharedEstateSettingsResponse = 0x0245, // updated 4.5

    //LandUpdateHouseName = 0x0257, // updated 4.5

    //LandSetMap = 0x025B, // updated 4.5

    //////////////////////////////////////////////////

    //DuelChallenge = 0x0277, // 4.2; this is responsible for opening the ui
    //PerformNote = 0x0286, // updated 4.3

    PrepareZoning = 0x00F9, // updated 5.3
    ActorGauge = 0x020F, // updated 5.3

    // daily quest info -> without them sent,  login will take longer...
    DailyQuests = 0x031E, // updated 5.25
    DailyQuestRepeatFlags = 0x00A7, // updated 5.25

    /// Doman Mahjong //////////////////////////////////////
    //MahjongOpenGui = 0x02A4, // only available in mahjong instance
    //MahjongNextRound = 0x02BD, // initial hands(baipai), # of riichi(wat), winds, honba, score and stuff
    //MahjongPlayerAction = 0x02BE, // tsumo(as in drawing a tile) called chi/pon/kan/riichi
    //MahjongEndRoundTsumo = 0x02BF, // called tsumo
    //MahjongEndRoundRon = 0x2C0, // called ron or double ron (waiting for action must be flagged from discard packet to call)
    //MahjongTileDiscard = 0x02C1, // giri (discarding a tile.) chi(1)/pon(2)/kan(4)/ron(8) flags etc..
    //MahjongPlayersInfo = 0x02C2, // actor id, name, rating and stuff..
    // 2C3 and 2C4 are currently unknown
    //MahjongEndRoundDraw = 0x02C5, // self explanatory
    //MahjongEndGame = 0x02C6, // finished oorasu(all-last) round; shows a result screen.
  };

  /**
  * Client IPC Zone Type Codes.
  */
  enum ClientZoneIpcType : ushort
  {
    PingHandler = 0x017A, // updated 5.25
    InitHandler = 0x03B9, // updated 5.25

    FinishLoadingHandler = 0x008A, // updated 5.25

    //CFCommenceHandler = 0x0078, // updated 5.21 hotfix

    //CFRegisterDuty = 0x0118, // updated 5.21 hotfix
    CFRegisterRoulette = 0x037A, // updated 5.21 hotfix
    //PlayTimeHandler = 0x0276, // updated 5.1
    LogoutHandler = 0x00B7, // updated 5.25
    //CancelLogout = 0x008F, // updated 5.1

    //CFDutyInfoHandler = 0x0078, // updated 4.2

    //SocialReqSendHandler = 0x00AE, // updated 4.1
    //CreateCrossWorldLS = 0x00AF, // updated 4.3

    ChatHandler = 0x01E2, // updated 5.3

    SocialListHandler = 0x0371, // updated 5.25
    SetSearchInfoHandler = 0x0210, // updated 5.3
    ReqSearchInfoHandler = 0x0366, // updated 5.25
    //ReqExamineSearchCommentHandler = 0x00E7, // updated 5.0

    //ReqRemovePlayerFromBlacklist = 0x00F1, // updated 5.0
    BlackListHandler = 0x0354, // updated 5.25
    //PlayerSearchHandler = 0x00F4, // updated 5.0

    LinkshellListHandler = 0x01D4, // updated 5.25

    //MarketBoardRequestItemListingInfo = 0x0102, // updated 4.5
    //MarketBoardRequestItemListings = 0x0103, // updated 4.5
    //MarketBoardSearch = 0x0107, // updated 4.5

    //ReqExamineFcInfo = 0x0113, // updated 4.1

    //FcInfoReqHandler = 0x011A, // updated 4.2

    //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

    //ReqMarketWishList = 0x012C, // updated 4.3

    //ReqJoinNoviceNetwork = 0x0129, // updated 4.2

    //ReqCountdownInitiate = 0x0135, // updated 5.0
    //ReqCountdownCancel = 0x0136, // updated 5.0

    ZoneLineHandler = 0x0214, // updated 5.25
    ClientTrigger = 0x02BE, // updated 5.3
    //DiscoveryHandler = 0x019A, // updated 5.2

    //PlaceFieldMarker = 0x013C, // updated 5.0
    SkillHandler = 0x0241, // updated 5.25
    GMCommand1 = 0x01EC, // updated 5.25
    GMCommand2 = 0x0368, // updated 5.25
    //AoESkillHandler = 0x0364, // updated 5.21 hotfix

    UpdatePositionHandler = 0x014D, // updated 5.25

    InventoryModifyHandler = 0x0179, // updated 5.25
    
    //InventoryEquipRecommendedItems = 0x0149, // updated 5.0

    //ReqPlaceHousingItem = 0x014B, // updated 5.0
    //BuildPresetHandler = 0x0150, // updated 5.0

    TalkEventHandler = 0x030F, // updated 5.25
    EmoteEventHandler = 0x01DD, // updated 5.25
    WithinRangeEventHandler = 0x0165, // updated 5.25
    OutOfRangeEventHandler = 0x01EB, // updated 5.25
    EnterTeriEventHandler = 0x00F8, // updated 5.25

    ReturnEventHandler = 0x00BB, // updated 5.25
    TradeReturnEventHandler = 0x03B6, // updated 5.25

    //LinkshellEventHandler = 0x016B, // updated 4.5
    //LinkshellEventHandler1 = 0x016C, // updated 4.5

    ReqEquipDisplayFlagsChange = 0x0202, // updated 5.25

    //LandRenameHandler = 0xF177, // updated 5.0
    //HousingUpdateHouseGreeting = 0x0178, // updated 5.0
    //HousingUpdateObjectPosition = 0x0179, // updated 5.0

    //SetSharedEstateSettings = 0x017B, // updated 5.0

    UpdatePositionInstance = 0x0290, // updated 5.25

    //PerformNoteHandler = 0x029B, // updated 4.3

  };

  ////////////////////////////////////////////////////////////////////////////////
  /// Chat Connection IPC Codes
  /**
  * Server IPC Chat Type Codes.
  */
  enum ServerChatIpcType : ushort
  {
    //Tell = 0x0064, // updated for sb
    //TellErrNotFound = 0x0066,

    //FreeCompanyEvent = 0x012C, // added 5.0
  };

  /**
  * Client IPC Chat Type Codes.
  */
  enum ClientChatIpcType : ushort
  {
    //TellReq = 0x0064,
  };
}
