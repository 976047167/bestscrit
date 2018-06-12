﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppSettings;

public class MapCardShop : MapCardBase
{
    int shopId;

    public override void OnPlayerEnter()
    {

        int DialogId = ShopTableSettings.Get(shopId).DialogId;
        UIModule.Instance.OpenForm<WND_Dialog>(DialogId);
        base.OnPlayerEnter();
        //进入商店
    }
    public override void OnInit()
    {
        int count = ShopTableSettings.GetInstance().Count;
        shopId = Random.Range(1, count + 1);
    }
}