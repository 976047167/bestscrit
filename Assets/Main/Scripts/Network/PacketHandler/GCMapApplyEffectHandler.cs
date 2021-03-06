﻿//generate by code
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BigHead.Net;
using Google.Protobuf;
using BigHead.protocol;

public class GCMapApplyEffectHandler : BasePacketHandler
{
    public override ushort OpCode
    {
        get
        {
            return (ushort)MessageId_Receive.GCMapApplyEffect;
        }
    }

    public override void Handle(object sender, IMessage packet)
    {
        base.Handle(sender, packet);
        GCMapApplyEffect data = packet as GCMapApplyEffect;
        //处理完数据和逻辑后,发送消息通知其他模块,绝对不可以直接操作UI等Unity主线程的东西!
        //此处发送消息不允许使用Messenger.BroadcastSync同步通知
        //throw new System.NotImplementedException(GetType().ToString());
        Messenger.BroadcastAsync(MessageId.MAP_APPLY_EFFECT);
    }
}
