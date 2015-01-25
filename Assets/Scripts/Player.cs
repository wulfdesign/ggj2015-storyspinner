﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player {

    public List<CardData> hand;
    public List<CardData> goals;
    public bool isYou;
    public string playerName;
    public Game game;
    public NetworkPlayer mPlayer;
    int points;

	public Player (string name, Game theGame, NetworkPlayer player)
	{
		playerName = name;
		game = theGame;
		mPlayer = player;
		
		hand = new List<CardData> ();
		goals = new List<CardData> ();
	}

    void OnGUI()
    {
        if (isYou)
        {
            if (hand.Count == 0)
            {
                GUI.Label(new Rect(10, 10, 200, 20), "HAND IS EMPTY");
            }

            for (int i = 0; i < hand.Count; i++)
            {
                GUI.Label(new Rect(10, 10 + 25*i, 200, 20), hand[i].ToString());
            }

            GUI.skin.button.wordWrap = true;
            for (int i = 0; i < hand.Count; i++)
            {
                GUI.Button(new Rect(20 + 85 * i, 375, 75, 140), hand[i].ToString());
            }

            for (int i = 0; i < goals.Count; i++)
            {
                GUI.Button(new Rect(720 + 110 * i, 375, 90, 140), goals[i].ToString());
            }
        }
    }

    public void AddGoal(CardData c)
    {
        if (isYou)
        {

        }

        goals.Add(c);
    }

    public void AddCard(CardData c)
    {
        if (isYou)
        {
            //GameObject cardObject = (GameObject)GameObject.Instantiate(Resources.Load("Card"), Vector3.zero, Quaternion.identity);

        }

        hand.Add(c);
    }
}
