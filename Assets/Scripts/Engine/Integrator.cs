using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Integrator
{
    public static void ExplicitEuler(Body body, float dt)
    {
        /*body.position += (body.velocity * dt);
        body.velocity += (body.acceleration * dt);
        body.velocity *= (1f / (1f + (body.damping * dt)));*/

        //acceleration is already calculated
        body.velocity += (body.acceleration * dt);
        body.velocity *= (1f / (1f + (body.damping * dt)));
        body.position += (body.velocity * dt);

    }
}
