using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public struct PointStruct
    {
        public float fX;
        public float fY;
        public double dX;
        public double dY;
        public PointStruct(float _fX, float _fY, double _dX, double _dY)
        {
            fX = _fX;
            fY = _fY;
            dX = _dX;
            dY = _dY;
        }
    }
}
