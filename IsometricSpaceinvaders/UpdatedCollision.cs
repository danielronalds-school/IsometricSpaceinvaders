﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using IsometricGameEngine;

namespace IsometricSpaceinvaders
{
    static class UpdatedCollision
    {
        public static bool collidersColliding(ColliderComponent colliderOne, ColliderComponent colliderTwo, IsometricGrid2D isometricGridOne, IsometricGrid2D isometricGridTwo)
        {
            if (!colliderOne.Fixed)
            {
                colliderOne.configureCollisionArray(isometricGridOne);
            }

            if (!colliderTwo.Fixed)
            {
                colliderTwo.configureCollisionArray(isometricGridTwo);
            }

            foreach (Rectangle collider1 in colliderOne.Colliders)
            {
                foreach (Rectangle collider2 in colliderTwo.Colliders)
                {
                    if (collider1.IntersectsWith(collider2))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
