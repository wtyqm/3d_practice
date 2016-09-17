using System;
using System.Collections.Generic;

namespace Practice3d
{
    public class Vec3<Type>
    {
            public Type x,y,z;
    }

}

namespace Practice3d
{
    using Vec3f = Vec3<float>;

    public class Sphere
    {
        public Vec3f origin;
        public float radius;
    }

    public class FirstRayTracer
    {
        Vec3f trace(Vec3f rayOrigin, Vec3f rayDir, List<Sphere> objs, int depth)
        {
            //find the most close object hit by the ray
            //get itself color
            //get reflect color
            //get refraction color
            //mix
            return new Vec3f();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
