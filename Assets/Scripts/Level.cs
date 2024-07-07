using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Level
{
    [SerializeField]
    public Wave[] WavesINLVL;
    public int CurrentWaveIndex;
    public Wave CurrentWave => WavesINLVL[CurrentWaveIndex];
    public GameObject[] Path;
}

