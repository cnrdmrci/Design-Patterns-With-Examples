using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public class Bullet
    {
        public int BulletId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get;}

        public Bullet()
        {
            CreateDate = DateTime.Now;
        }
    }
}
