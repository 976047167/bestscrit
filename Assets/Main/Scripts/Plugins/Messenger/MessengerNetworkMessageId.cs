﻿/*
 * 网络消息兼容
 */
#define NETWORK_MESSAGE_ID



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public partial class Messenger
{
#if NETWORK_MESSAGE_ID
    //No parameters
    static public void AddListener(MessageId_Receive messageID, Callback handler)
    {
        uint eventType = (uint)messageID;
        OnListenerAdding(eventType, handler);
        m_eventListenTable[eventType] = (Callback)m_eventListenTable[eventType] + handler;
    }

    //Single parameter
    static public void AddListener<T>(MessageId_Receive messageID, Callback<T> handler)
    {
        uint eventType = (uint)messageID;
        OnListenerAdding(eventType, handler);
        m_eventListenTable[eventType] = (Callback<T>)m_eventListenTable[eventType] + handler;
    }

    //Two parameters
    static public void AddListener<T, U>(MessageId_Receive messageID, Callback<T, U> handler)
    {
        uint eventType = (uint)messageID;
        OnListenerAdding(eventType, handler);
        m_eventListenTable[eventType] = (Callback<T, U>)m_eventListenTable[eventType] + handler;
    }

    //Three parameters
    static public void AddListener<T, U, V>(MessageId_Receive messageID, Callback<T, U, V> handler)
    {
        uint eventType = (uint)messageID;
        OnListenerAdding(eventType, handler);
        m_eventListenTable[eventType] = (Callback<T, U, V>)m_eventListenTable[eventType] + handler;
    }
    //No parameters
    static public void RemoveListener(MessageId_Receive messageID, Callback handler)
    {
        uint eventType = (uint)messageID;
        if (OnListenerRemoving(eventType, handler))
        {
            m_eventListenTable[eventType] = (Callback)m_eventListenTable[eventType] - handler;
            if (m_eventListenTable[eventType] == null)
            {
                Remove(eventType);
            }
        }
    }

    //Single parameter
    static public void RemoveListener<T>(MessageId_Receive messageID, Callback<T> handler)
    {
        uint eventType = (uint)messageID;
        if (OnListenerRemoving(eventType, handler))
        {
            m_eventListenTable[eventType] = (Callback<T>)m_eventListenTable[eventType] - handler;
            if (m_eventListenTable[eventType] == null)
            {
                Remove(eventType);
            }
        }
    }

    //Two parameters
    static public void RemoveListener<T, U>(MessageId_Receive messageID, Callback<T, U> handler)
    {
        uint eventType = (uint)messageID;
        if (OnListenerRemoving(eventType, handler))
        {
            m_eventListenTable[eventType] = (Callback<T, U>)m_eventListenTable[eventType] - handler;
            if (m_eventListenTable[eventType] == null)
            {
                Remove(eventType);
            }
        }
    }

    //Three parameters
    static public void RemoveListener<T, U, V>(MessageId_Receive messageID, Callback<T, U, V> handler)
    {
        uint eventType = (uint)messageID;
        if (OnListenerRemoving(eventType, handler))
        {
            m_eventListenTable[eventType] = (Callback<T, U, V>)m_eventListenTable[eventType] - handler;
            if (m_eventListenTable[eventType] == null)
            {
                Remove(eventType);
            }
        }
    }
    static public void Broadcast(MessageId_Receive eventType)
    {
        DoBroadcast((uint)eventType, false);
    }
    static public void BroadcastAsync(MessageId_Receive eventType)
    {
        DoBroadcast((uint)eventType, true);
    }
    //Single parameter
    static public void Broadcast<T>(MessageId_Receive eventType, T arg1)
    {
        DoBroadcast<T>((uint)eventType, arg1, false);
    }
    static public void BroadcastAsync<T>(MessageId_Receive eventType, T arg1)
    {
        DoBroadcast<T>((uint)eventType, arg1, true);
    }

    //Two parameters
    static public void Broadcast<T, U>(MessageId_Receive eventType, T arg1, U arg2)
    {
        DoBroadcast<T, U>((uint)eventType, arg1, arg2, false);
    }
    static public void BroadcastAsync<T, U>(MessageId_Receive eventType, T arg1, U arg2)
    {
        DoBroadcast<T, U>((uint)eventType, arg1, arg2, true);
    }

    //Three parameters
    static public void Broadcast<T, U, V>(MessageId_Receive eventType, T arg1, U arg2, V arg3)
    {
        DoBroadcast<T, U, V>((uint)eventType, arg1, arg2, arg3, false);
    }
    static public void BroadcastAsync<T, U, V>(MessageId_Receive eventType, T arg1, U arg2, V arg3)
    {
        DoBroadcast<T, U, V>((uint)eventType, arg1, arg2, arg3, true);
    }
#endif
}
