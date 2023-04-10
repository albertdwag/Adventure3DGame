using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ebac.Enemy
{
    public class EnemyShoot : EnemyBase
    {
        public GunBase gunBase;

        protected override void Init()
        {
            base.Init();

            gunBase.StartShoot();
        }
    }
}
