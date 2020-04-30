using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public class UsageOfObjectPool
    {
        public static void Run()
        {
            Bullet bullet1 = new Bullet();
            bullet1.BulletId = 1;
            bullet1.Name = "Bullet1";

            Bullet bullet2 = new Bullet();
            bullet2.BulletId = 2;
            bullet2.Name = "Bullet2";

            ObjectPoolMultiThread<Bullet> bulletObjectPool = ObjectPoolMultiThread<Bullet>.GetInstance();

            Bullet gettingBulletNone = bulletObjectPool.GetItemFromThePool(); //will be null
            bulletObjectPool.SetMaxPoolSize(20);


            bulletObjectPool.PutItemInThePool(bullet1);
            bulletObjectPool.PutItemInThePool(bullet2);

            Bullet gettingBullet1 = bulletObjectPool.GetItemFromThePool();

            bulletObjectPool.Reset();

        }
    }
}
