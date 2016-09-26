using System;
using System.Collections.Generic;

namespace Practice3d
{
    public class Vec3<T>
    {
            public T x,y,z;

            public T dot(Vec3<T> v)
            {
                return x*v.x + y*v.y + z*v.z;
            }
    }

}

namespace Practice3d
{
    using Vec3f = Vec3<float>;

    public class Sphere
    {
        public Vec3f origin;
        public float radius;

        public bool intersectIn(Vec3f rayOrigin, Vec3f rayDir, out float t1, out float t2)
        {
            t1 = 0;
            t2 = 0;
            var a = 
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
            return new Vec3f();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
