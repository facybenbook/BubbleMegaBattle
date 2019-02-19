﻿using UnityEngine;
using System.Collections;
using Sirenix.OdinInspector;

namespace Config
{
    public class GameConstant
    {
        public const int   StageRowCount = 14; // 泡泡锚点行数
        public const int   RowBubbMaxNum = 10;
        public const int   RowBubbMinNum = RowBubbMaxNum - 1;
        public const float BubbRadius    = 0.5f; // 泡泡半径(unity单位)
        public static readonly float RowHeight;

        static GameConstant()
        {
            RowHeight = 2 * BubbRadius * Mathf.Sin(Mathf.PI / 3);
        }
    }


    public class GameCfg : SerializedScriptableObject
    {
    }
}