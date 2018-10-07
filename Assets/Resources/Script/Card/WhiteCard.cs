﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

public class WhiteCard : Card {

    public WhiteCard() {
        id = 1011;
        cost = 1;
        name = "升级";
        state = CARD_STATE_ENABLED;
        tagList = new List<string>();

        desc = "使某其他玩家的所有防御塔属性变为白色，5秒";
        existTime = 5;
    }

    public override void Action(int srcPlayerId = -1,int targetId = -1,ArrayList param = null) {

    }

    public override void Finish(int srcPlayerId = -1,int tagetId = -1,ArrayList param = null) {
    }
}