﻿using System;
using UnityEngine;


namespace ExampleGB
{
    [Serializable]
    public sealed class CardProperties
    {
        public CardType Type;
        public Sprite Image;
        public float ProductionTime;
    }
}