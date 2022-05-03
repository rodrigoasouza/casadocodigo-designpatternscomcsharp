﻿using Design.Patterns.Structural.Flyweight.MusicalKey.Interface;

namespace Design.Patterns.Structural.Flyweight.MusicalKey
{
    public class Fa : IMusicalKey
    {
        public int Frequency
        {
            get => FlyweightConst.FrequencyFa;
        }
    }
}
