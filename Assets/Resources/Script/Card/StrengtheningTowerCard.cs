﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class StrengtheningTowerCard:Card {
    private int addHP = 25;
    public StrengtheningTowerCard() {
        id = 1002;
        cost = 1;
        name = "加固";
        state = CARD_STATE_ENABLED;
        tagList = new List<string>();
        tagList.Add("tower1");
        tagList.Add("tower2");
        tagList.Add("tower3");
        tagList.Add("tower0");
        desc = "增加目标防御塔生命25点";
    }

    public override void Action(int srcPlayerId = -1,int targetId = -1,ArrayList param = null) {

    }

    public override void Finish(int srcPlayerId = -1,int tagetId = -1,ArrayList param = null) {
    }
}
