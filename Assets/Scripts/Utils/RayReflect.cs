using UnityEngine;
 
 
/// <summary>
/// descript:射线反射
/// author: wushengnuo
/// </summary>
public class RayReflect : MonoSingleton<RayReflect>
{
    public Vector2 p1;
    public Vector2 p2;
    private void Update()
    {
        RaycastHit hit;
        Vector3 direction = p2 - p1;
        direction.Normalize();
        if (Physics.Raycast(p1, direction, out hit))
        {
            rayPoint = hit.point;
            Vector3 reflect= Vector3.Reflect(direction, hit.normal);
            reflectRayEnd = reflect * 100+hit.point;
        }
    }
 
 
    Vector3 rayPoint;
    Vector3 reflectRayEnd;
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(p1, rayPoint);
        Gizmos.DrawLine(rayPoint, reflectRayEnd);
    }
}

