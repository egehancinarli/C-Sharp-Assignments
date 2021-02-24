﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class Character
    {
        public IWeaponBehaviour Weapon { get; set; }
        public Character()
        {
            Weapon = new KnifeBehaviour(); // as default.
        }                        
        
        public void Fight()
        {
            Weapon.UseWeapon();
        }

    }
}
