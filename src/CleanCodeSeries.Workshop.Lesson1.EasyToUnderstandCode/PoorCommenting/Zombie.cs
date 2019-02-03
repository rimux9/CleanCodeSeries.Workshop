﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting
{
    class Zombie
    {
        // Head
        private Brains _brains;

        private Vector3 _location;
        // Here it seeks for brains, not head!!!
        public void Seek(Brains brains)
        {
            // doesn't work
            //while (!Equals(_location, brains.Location))
            //{
            //    Thread.Sleep(1);
            //}
            // Location
            var l = brains.Location;
            Move(l);
        }

        // Goes to location
        public void Move(Vector3 locationTo)
        {
            // moving to location
        }
    }
}
