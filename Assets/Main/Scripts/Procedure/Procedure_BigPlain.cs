﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procedure_BigPlain : ProcedureBase
{
    public override void OnEnter(ProcedureBase last)
    {
        base.OnEnter(last);
        Game.UI.OpenForm<UIMapInfo>();
        Game.UI.OpenForm<UIMenu>();
    }

    public override void OnExit(ProcedureBase next)
    {
        base.OnExit(next);
        Game.UI.CloseForm<UIMapInfo>();
        Game.UI.CloseForm<UIMenu>();
    }

    public override bool OnInit(object userdata = null)
    {
        return base.OnInit(userdata);
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
    }
}
