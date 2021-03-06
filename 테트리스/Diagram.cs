﻿using System;

namespace 테트리스
{
    class Diagram
    {
        internal static readonly int[,,,] bvalue = new int[,,,]
        {
            {
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {1,1,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {1,1,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                }
            },
            {
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,1,1,0 },
                    {0,0,0,0 }
                }
            },
            {
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,1,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,0,1,1 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,1,1,1 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,1,1,0 },
                    {0,0,1,0 }
                }
            },
            {
                {
                    {0,0,0,0 },
                    {0,0,1,1 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,1,1,1 },
                    {0,0,0,1 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,1,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,0,0 },
                    {0,1,1,1 },
                    {0,0,0,0 }
                }
            },
            {
                {
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,1 },
                    {0,1,1,1 },
                    {0,0,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,0,1,0 },
                    {0,0,1,1 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,1,1,1 },
                    {0,1,0,0 }
                }
            },
            {
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,0,1,1 },
                    {0,1,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,0,0 },
                    {0,1,1,0 },
                    {0,0,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,0,1,1 },
                    {0,1,1,0 }
                },
                {
                    {0,0,0,0 },
                    {0,1,0,0 },
                    {0,1,1,0 },
                    {0,0,1,0 }
                }
            },
            {
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,1 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,1,1,0 },
                    {0,1,0,0 }
                },
                {
                    {0,0,0,0 },
                    {0,0,0,0 },
                    {0,1,1,0 },
                    {0,0,1,1 }
                },
                {
                    {0,0,0,0 },
                    {0,0,1,0 },
                    {0,1,1,0 },
                    {0,1,0,0 }
                }
            }
        };
        internal int X { get; private set; }
        internal int Y { get; private set; }
        internal int TN { get; private set; }
        internal int BN { get; private set; }
        internal Diagram(int x, int y)
        {
            SetXY(x, y);
            TN = 0;
        }
        internal void Turn()
        {
            TN = (TN + 1) % 4;
        }
        Random rand = new Random();
        internal void SetXY(int x, int y)
        {
            BN = rand.Next(7);
            X = x;
            Y = y;
        }
        internal void Move(int cx, int cy)
        {
            X += cx;
            Y += cy;
        }
    }
}
