using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PlayerStruct
{
    public Guid id;
    public DeckStruct SummonerDeck;
    public DeckStruct GraveyardDeck;
    public SortedSet<CardStruct> Hand;
}
