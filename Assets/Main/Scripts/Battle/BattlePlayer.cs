﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayer
{
    public bool UseAI { private set; get; }
    public BattlePlayerData Data { get; private set; }
    private BattlePlayerAI playerAI;
    public bool IsMe { get; private set; }
    public Player Player { get; private set; }

    public BattlePlayer(Player player)
    {
        this.Player = player;
        Data = new BattlePlayerData();
        Data.Name = player.Data.Name;
        Data.HP = player.Data.HP;
        Data.MaxHP = player.Data.MaxHP;
        Data.MP = player.Data.MP;
        Data.MaxMP = player.Data.MaxMP;
        //玩家的行动值初始1
        Data.AP = Data.MaxAP = 0;
        Data.Level = player.Data.Level;
        Data.SkillId = player.Data.BattleSkillID;
        Data.HeadIcon = player.Data.HeadIcon;
        Data.CardList.Clear();

        Data.EquipList = new List<BattleEquipData>(player.Data.EquipList.Count);
        for (int i = 0; i < player.Data.EquipList.Count; i++)
        {
            List<int> actions = player.Data.EquipList[i].Data.ActionTypes;
            for (int j = 0; j < actions.Count; j++)
            {
                if (actions[i] == (int)BattleActionType.AddEuipment)
                {
                    Data.EquipList.Add(new BattleEquipData(player.Data.EquipList[j].Data.ActionParams[0], this));
                    break;
                }
            }
        }
        Data.CardList = new List<BattleCardData>(player.Data.CardList.Count);
        for (int i = 0; i < player.Data.CardList.Count; i++)
        {
            Data.CardList.Add(new BattleCardData(player.Data.CardList[i].CardId, this));
        }
        Data.BuffList = new List<BattleBuffData>(player.Data.BuffList.Count);
        for (int i = 0; i < player.Data.BuffList.Count; i++)
        {
            Data.BuffList.Add(new BattleBuffData(player.Data.BuffList[i].Data.ActionParams[0], -1, new BattleCardData(player.Data.BuffList[i].CardId, this), this, this));
        }



        Data.CurrentCardList = new List<BattleCardData>(Data.CardList);
        IsMe = player == Game.DataManager.MyPlayer;

    }
    public BattlePlayer(int monsterId)
    {
        Data = new BattlePlayerData();





        Data.CurrentCardList = new List<BattleCardData>(Data.CardList);
        Data.AP = 0;
        Data.MaxAP = 0;
        IsMe = false;

    }
    /// <summary>
    /// 应用卡牌的效果
    /// </summary>
    /// <param name="cardData"></param>
    public void ApplyCardEffect(BattleCardData cardData)
    {
        cardData.Owner.Data.UsedCardList.Add(cardData);
        cardData.Owner.Data.AP -= cardData.Data.Spending;
        for (int i = 0; i < cardData.Data.ActionTypes.Count; i++)
        {
            ApplyAction(cardData.Data.ActionTypes[i], cardData.Data.ActionParams[i], cardData.Data.ActionParams[i], cardData, cardData.Owner, null);
        }
    }
    /// <summary>
    /// 应用触发效果
    /// </summary>
    public void ApplyTimeEffects(BattleActionTime actionTime)
    {
        ApplyBuffs(actionTime);
        ApplyEquips(actionTime);
    }
    /// <summary>
    /// 触发buff的时机
    /// </summary>
    /// <param name="playerData"></param>
    /// <param name="actionTime">当前使用特效的时机</param>
    public void ApplyBuffs(BattleActionTime actionTime)
    {
        List<BattleBuffData> removeList = new List<BattleBuffData>();
        foreach (var buff in this.Data.BuffList)
        {
            for (int i = 0; i < buff.Data.ActionTimes.Count; i++)
            {
                if (buff.Data.ActionTimes[i] == (int)actionTime)
                {
                    ApplyAction(buff.Data.ActionTypes[i], buff.Data.ActionPrarms[i], buff.Data.ActionParams2[i], buff.CardData, this, this);
                    buff.Time--;
                    if (buff.Time == 0)
                    {
                        removeList.Add(buff);
                    }
                    if (buff.Time < 0)
                    {
                        buff.Time = -1;
                    }
                }
            }
        }
        foreach (var item in removeList)
        {
            this.Data.BuffList.Remove(item);
        }
    }
    public void ApplyEquips(BattleActionTime actionTime)
    {
        List<BattleEquipData> removeList = new List<BattleEquipData>();
        foreach (var equip in this.Data.EquipList)
        {
            for (int i = 0; i < equip.Data.ActionTimes.Count; i++)
            {
                if (equip.Data.ActionTimes[i] == (int)actionTime)
                {
                    ApplyAction(equip.Data.ActionTypes[i], equip.Data.ActionPrarms[i], equip.Data.ActionParams2[i], equip.CardData, this);
                    //equip.Time--;
                    //if (equip.Time == 0)
                    //{
                    //    removeList.Add(equip);
                    //}
                    //if (equip.Time < 0)
                    //{
                    //    equip.Time = -1;
                    //}
                }
            }
        }
        foreach (var item in removeList)
        {
            this.Data.EquipList.Remove(item);
        }
    }
    void ApplyAction(int actionType, int actionArg, int actionArg2, BattleCardData cardData, BattlePlayer owner, BattlePlayer target = null)
    {
        if (target == null)
        {
            target = IsMe ? Game.BattleManager.OppPlayer : this;
        }
        BattleAction battleAction = BattleAction.Create((BattleActionType)actionType, actionArg, actionArg2, cardData, owner, target);
        battleAction.Excute();
    }
    /// <summary>
    /// 游戏逻辑里面的效果实现
    /// </summary>
    public void ApplyAction(BattleActionType actionType, int actionArg, int actionArg2 = 0)
    {
        ApplyAction((int)actionType, actionArg, actionArg2, null, this, this);
    }
    public void EndRound()
    {
        Game.BattleManager.RoundEnd();
    }
    
    public void StartAI()
    {
        if (playerAI == null)
        {
            playerAI = new BattlePlayerAI(this);
        }
        UseAI = true;
        playerAI.StartAI();
    }

    public void UpdateAI()
    {
        if (UseAI == false)
        {
            return;
        }
        playerAI.UpdateAI();
    }
    public void StopAI()
    {
        if (UseAI)
        {
            UseAI = false;
            playerAI.StopAI();
        }
    }

}
