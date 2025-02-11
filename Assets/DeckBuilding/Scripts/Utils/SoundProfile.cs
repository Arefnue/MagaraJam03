﻿using System.Collections.Generic;
using UnityEngine;

namespace DeckBuilding
{
    [CreateAssetMenu(fileName = "SoundProfile", menuName = "SoundProfile", order = 0)]
    public class SoundProfile : ScriptableObject
    {
        public List<AudioClip> randomClipList;
        
        public AudioClip GetRandomClip()
        {
            return randomClipList[Random.Range(0, randomClipList.Count)];
        }
    }
}