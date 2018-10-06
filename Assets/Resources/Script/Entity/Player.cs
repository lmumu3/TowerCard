﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int id;
    public List<Card> cardList;
    public List<int> curCardPosList;
    public GameObject cardPrefab;
    private Transform root;

    public void Start() {
        cardList = new List<Card>();
        curCardPosList = new List<int>();
    }

    public void InitCardList() {
        for(int i = 0; i < 15; i++) {
            int randId = i;
            if(i >= 13) {
                randId = Random.Range(1,13) + 1000;
            }
            Card card = CardMgr.ins.createCard(randId);
            cardList.Add(card);
        }
    }

    public void InitHandCard(Transform parent) {
        root = parent;

        for(int i = 0; i < 5; i++) {
            int randomPos = 0;
            while(true) {
                randomPos = Random.Range(0,cardList.Count);
                if(cardList[randomPos].state == Card.CARD_STATE_ENABLED) {
                    break;
                }
            }
            curCardPosList.Add(randomPos);
            cardList[randomPos].state = Card.CARD_STATE_INHAND;
            GameObject go = Instantiate(cardPrefab,root);
            cardList[randomPos].InitGameObject(go);
        }
    }

    public void GetNewCard() {
        int randPos = 0;
        while(true) {
            randPos = Random.Range(0,cardList.Count);
            if(cardList[randPos].state == Card.CARD_STATE_ENABLED) {
                break;
            }
        }
        
        curCardPosList.Add(randPos);
        cardList[randPos].state = Card.CARD_STATE_INHAND;
        GameObject go = Instantiate(cardPrefab,root);
        cardList[randPos].InitGameObject(go);
    }

}