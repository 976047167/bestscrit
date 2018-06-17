using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public partial class BattleAction
{
    public class AttackIgnoreDefense : BattleAction
    {
        public static BattleActionType ActionType { get { return BattleActionType.AttackIgnoreDefense; } }
        public override void Excute()
        {
            target.Data.HP -= actionArg;
            battleMgr.AddUIAction(new UIAction.UIHpDamage(target, actionArg));
        }
    }
}
