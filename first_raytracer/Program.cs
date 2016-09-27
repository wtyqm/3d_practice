using System;
using System.Collections.Generic;

namespace Practice3d
{
    public class Vec3f
    {
            public float _x,_y,_z;
            
            public Vec3f(float x, float y, float z)
            {
                _x = x;
                _y = y;
                _z = z;
            }

            public float dot(Vec3f v)
            {
                return _x*v._x + _y*v._y + _z*v._z;
            }

            public static Vec3f operator +(Vec3f l, Vec3f r)
            {
                return new Vec3f(l._x+r._x, l._y+r._y, l._z+r._z);
            }

            public static Vec3f operator -(Vec3f l, Vec3f r)
            {
                return new Vec3f(l._x-r._x, l._y-r._y, l._z-r._z);
            }
    }

    public class Sphere
    {
        public Vec3f origin;
        public float radius;

        public bool intersectIn(Vec3f rayOrigin, Vec3f rayDir, out float t1, out float t2)
        {
            t1 = 0;
            t2 = 0; 

            Vec3f rc = rayOrigin - origin;
            float a = rayDir.dot(rayDir);
            float b = rc.dot(rayDir)*2;
            float c = rc.dot(rc) - radius*radius;

            if(b < 0) return false; //reverse line segment not intersect with sphere
            float delta2 = b*b - 4*a*c;
            if(delta2 < 0) return false;
            float delta = (float)Math.Sqrt(delta2);
            float p1 = -b/(2*a);
            float p2 = delta/(2*a);
            t1 = p1 + p2;
            t2 = p1 - p2;
            return true;
        }
    }

    public class FirstRayTracer
    {
        Vec3f trace(Vec3f rayOrigin, Vec3f rayDir, List<Sphere> objs, int depth)
        {
            //find the most close object hit by the ray
            //if no object hited, return env color
            //else return object color
            return new Vec3f(0,0,0);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
