using System;

namespace System.Net.Sockets
{
    public enum SocketOptionName : int
    {
        Debug = 1,
        AcceptConnection = 2,
        ReuseAddress = 4,
        KeepAlive = 8,
        DontRoute = 16,
        Broadcast = 32,
        UseLoopback = 64,
        Linger = 128,
        OutOfBandInline = 256,
        DontLinger = -129,
        ExclusiveAddressUse = -5,
        SendBuffer = 4097,
        ReceiveBuffer = 4098,
        SendLowWater = 4099,
        ReceiveLowWater = 4100,
        SendTimeout = 4101,
        ReceiveTimeout = 4102,
        Error = 4103,
        Type = 4104,
        MaxConnections = 2147483647,
        IPOptions = 1,
        HeaderIncluded = 2,
        TypeOfService = 3,
        IpTimeToLive = 4,
        MulticastInterface = 9,
        MulticastTimeToLive = 10,
        MulticastLoopback = 11,
        AddMembership = 12,
        DropMembership = 13,
        DontFragment = 14,
        AddSourceMembership = 15,
        DropSourceMembership = 16,
        BlockSource = 17,
        UnblockSource = 18,
        PacketInformation = 19,
        HopLimit = 21,
        IPProtectionLevel = 23,
        IPv6Only = 27,
        NoDelay = 1,
        BsdUrgent = 2,
        Expedited = 2,
        NoChecksum = 1,
        ChecksumCoverage = 20,
        UpdateAcceptContext = 28683,
        UpdateConnectContext = 28688
    }
}