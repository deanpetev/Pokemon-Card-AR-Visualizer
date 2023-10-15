using UnityEngine;
using System.Collections;
public class targetmove : MonoBehaviour
{
    Camera cam;
    void Start()
    {
        if (cam == null)
            cam = Camera.main;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = GetMousePositionInPlaneOfLauncher();
            transform.position = mousePos;
        }
    }
    Vector3 GetMousePositionInPlaneOfLauncher()
    {
        Plane p = new Plane(transform.right, transform.position);
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        float d;
        if (p.Raycast(r, out d))
        {
            Vector3 v = r.GetPoint(d);
            return v;
        }

        throw new UnityException("Mouse position ray not intersecting launcher plane");
    }
}