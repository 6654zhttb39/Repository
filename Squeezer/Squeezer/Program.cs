﻿using System;
    enum Point { A, _2, _3, _4, _5, _6, _7, _8, _9, _10, J, Q, K }//点数
    struct Poker
        private string p1, p2;
            // TODO: Complete member initialization
            this.p1 = p1;
            ArrayList Person1 = new ArrayList();
                for (int j = 0; j <= 12; j++)
                    myPoker.Add(new Poker(
         Enum.GetName(typeof(Color), i),
         Enum.GetName(typeof(Point), j)
         ));
            Console.WriteLine("所有的扑克牌：");
                Poker poAll = (Poker)myPoker[i];
            //开始发牌，一个人一个人的发，每发一张牌得从myPoker中RemoveAt掉扑克牌，Count数减小；第一个人Add到一张牌。
            for (int i = 0; i < 13; i++)