using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public partial class BattleAction
{
    public class EquipEndReplace : BattleAction
    {
        public static BattleActionType ActionType { get { return BattleActionType.EquipEndReplace; } }
        public override void Excute()
        {
            throw new System.NotImplementedException();
        }
    }
}
