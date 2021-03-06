﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    /// <summary>
    /// Пероснаж игрока
    /// </summary>
    class Player : Actor
    {
        /// <summary>
        /// Конструктор, создающий экземпляр игорка по его миру и расположению
        /// </summary>
        /// <param name="context"></param>
        /// <param name="hitbox"></param>
        public Player(World context, HitBox hitbox) : base(context, hitbox) { }

        /// <summary>
        /// Конструктор, создающий экземпляр игорка по его размеру
        /// (нужен для того, чтобы можно было заготорвить игорка до его непосредственного размещения в мире)
        /// </summary>
        /// <param name="size"></param>
        public Player(Vector size) : base(size) { }

        /// <summary>
        /// Конструктор игрока по умолчанию
        /// </summary>
        public Player() : base() { }
    }
}
