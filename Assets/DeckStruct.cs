using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckStruct : MonoBehaviour
{
    public SortedSet<CardStruct> contents;
    public Guid ownerId;
}
