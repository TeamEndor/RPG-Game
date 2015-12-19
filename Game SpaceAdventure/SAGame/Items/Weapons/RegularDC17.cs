﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame.Attributes;


namespace SAGame.Items.Weapons
{
    [Item]
    public class RegularDC17: Weapon
    {
        private const int DefaultRegularDC17Damage = 100;

        public RegularDC17(Position position) : base(position, DefaultRegularDC17Damage)
        {
        }
    }
}
