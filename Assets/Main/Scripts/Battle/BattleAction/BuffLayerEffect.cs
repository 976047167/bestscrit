﻿using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public partial class BattleAction
{
    public class BuffLayerEffect : BattleAction
    {
        public static BattleActionType ActionType { get { return BattleActionType.BuffLayerEffect; } }
        public override void Excute()
        {
            for (int i = 0; i < owner.Data.BuffList.Count; i++)
            {
                if (actionArg == owner.Data.BuffList[i].BuffId)
                {
                    Create(BattleActionType.RecoverMP, owner.Data.BuffList[i].Layer * actionArg2, 0, sourceData, owner, owner, owner.Data.BuffList[i]).Excute();
                    Create(BattleActionType.RemoveBuff, actionArg, 0, sourceData, owner, owner, owner.Data.BuffList[i]).Excute();
                }
            }
        }

        public override int Excute(int damage)
        {
            throw new NotImplementedException();
        }
    }
}
