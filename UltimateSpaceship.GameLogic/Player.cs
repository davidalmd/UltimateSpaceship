﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSpaceship.GameLogic
{
    public class Player : GameObject
    {
        public Player(Size bounds, Graphics screenPainter) : base(bounds, screenPainter)
        {
            this.Speed = 10;
            this.Sound = Media.explosion_long;
            this.Left = this.Bounds.Width / 2 - this.Width / 2;
            this.Top = this.Bounds.Height - this.Height;
        }

        public override Bitmap GetSprite()
        {
            return Media.jogador;
        }

        public override void UpdateObject()
        {
            base.UpdateObject();
        }

        public override void MoveUp()
        {
            if (this.Top > 0)
                this.Top -= this.Speed;
        }

        public override void MoveDown()
        {
            if (this.Top < this.Bounds.Height - this.Height)
                this.Top += this.Speed;
        }
    }
}
