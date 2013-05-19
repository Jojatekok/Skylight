﻿// <author>TakoMan02</author>
// <summary>Out.cs is the methods that can be used to edit the world it is in.</summary>
namespace Skylight
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using PlayerIOClient;

    public class Out
    {
        // TODO: Create holdLeft, holdRight, holdUp, holdDown, holdSpace, etc methods.
        private static object[] holdargs = new object[10] { Tools.GameTools.Bot.X, Tools.GameTools.Bot.Y, 0, 0, 0, 0, 0, 0, 0, false };

        private int blockDelay = 6, speechDelay = 60;

        private World w;

        public int BlockDelay
        {
            get { return this.blockDelay; }
            set { this.blockDelay = value; }
        }

        public int SpeechDelay
        {
            get { return this.speechDelay; }
            set { this.speechDelay = value; }
        }

        public World W
        {
            get
            {
                foreach (World wl in World.JoinedWorlds)
                {
                    if (wl.Push == this)
                    {
                        return wl;
                    }
                }

                return new World() { Name = "Null" };
            }

            set
            {
                this.w = value;
            }
        }

        public void Build(Block b)
        {
            if (this.W.C.Connected)
            {
                this.W.C.Send(this.W.WorldKey, b.Layer, b.X, b.Y, b.Id, b.Direction);
                Thread.Sleep(this.BlockDelay);
            }
        }

        public void Build(List<Block> blockList)
        {
            if (this.W.C.Connected)
            {
                foreach (Block b in blockList)
                {
                    this.Build(b);
                }
            }
        }

        public void InputCode(string editKey)
        {
            this.W.C.Send("access", editKey);
        }

        public void Say(string s)
        {
            if (this.W.C.Connected)
            {
                this.W.C.Send("say", s);
                Thread.Sleep(this.SpeechDelay);
            }
        }

        public void Move(object[] args)
        {
            if (this.W.C.Connected)
            {
                this.W.C.Send("m", args);
            }
        }

        public void ChangeTitle(string s)
        {
            if (this.W.C.Connected && s != string.Empty)
            {
                this.W.C.Send("name", s);
            }
        }

        // north = new object[10] { World.bot.x, World.bot.y, 0, 0, 0, 2, 0, -1, 0, false },
        // northeast = new object[10] { World.bot.x, World.bot.y, 0, 0, 0, 2, 0, -1, 0, false },
        // east = new object[10] { World.bot.x, World.bot.y, 0.981319527991571, 0, 1, 2, 1, 0, 0, false },
        // southeast = new object[10] { World.bot.x, World.bot.y, 0, 0, 0, 2, 0, -1, 0, false },
        // south = new object[10] { World.bot.x, World.bot.y, 0, 0, 0, 2, 0, -1, 0, false },
        // southwest = new object[10] { World.bot.x, World.bot.y, 0, 0, 0, 2, 0, -1, 0, false },
        // west = new object[10] { World.bot.x, World.bot.y, 0, 0, 0, 2, 0, -1, 0, false },
        // northwest = new object[10] { World.bot.x, World.bot.y, 0, 0, 0, 2, 0, -1, 0, false },
        // stationary = new object[10] { World.bot.x, World.bot.y, 0, 0, 0, 0, 0, 0, 0, false };
        public void HoldLeft()
        {
            holdargs[2] = 0;
            holdargs[3] = 0;
            holdargs[4] = 0;
            holdargs[5] = 0;
            holdargs[6] = 0;
            holdargs[7] = 0;
            holdargs[8] = 0;
        }

        public void HoldRight()
        {
            holdargs[2] = 0;
            holdargs[3] = 0;
            holdargs[4] = 0;
            holdargs[5] = 0;
            holdargs[6] = 0;
            holdargs[7] = 0;
            holdargs[8] = 0;
        }

        public void HoldUp()
        {
            holdargs[2] = 0;
            holdargs[3] = 0;
            holdargs[4] = 0;
            holdargs[5] = 0;
            holdargs[6] = 0;
            holdargs[7] = 0;
            holdargs[8] = 0;
        }

        public void HoldDown()
        {
            holdargs[2] = 0;
            holdargs[3] = 0;
            holdargs[4] = 0;
            holdargs[5] = 0;
            holdargs[6] = 0;
            holdargs[7] = 0;
            holdargs[8] = 0;
        }

        public void Jump()
        {
            holdargs[2] = 0;
            holdargs[3] = 0;
            holdargs[4] = 0;
            holdargs[5] = 0;
            holdargs[6] = 0;
            holdargs[7] = 0;
            holdargs[8] = 0;
        }

        public void Release()
        {
            holdargs[2] = 0;
            holdargs[3] = 0;
            holdargs[4] = 0;
            holdargs[5] = 0;
            holdargs[6] = 0;
            holdargs[7] = 0;
            holdargs[8] = 0;
        }
    }
}