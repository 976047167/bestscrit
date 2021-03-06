﻿//generate by code
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BigHead.Net;
using Google.Protobuf;
using BigHead.protocol;

public class GCExitInstanceHandler : BasePacketHandler
{
    public override ushort OpCode
    {
        get
        {
            return (ushort)MessageId_Receive.GCExitInstance;
        }
    }

    public override void Handle(object sender, IMessage packet)
    {
        base.Handle(sender, packet);
        GCExitInstance data = packet as GCExitInstance;
        //处理完数据和逻辑后,发送消息通知其他模块,绝对不可以直接操作UI等Unity主线程的东西!
        //TODO: 退出副本的总结算
        //RewardData rewardData = new RewardData(data.Gold,data.Diamonds)
        
        Messenger.Broadcast(MessageId.MAP_BACK_TO_MAINTOWN);
    }
}
