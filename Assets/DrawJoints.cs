using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawJoints : MonoBehaviour
{
    public SpringJoint2D left;
    public SpringJoint2D right;
    public GameObject[] squares;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(transform.position, squares[0].transform.position);
        Gizmos.DrawLine(transform.position, squares[1].transform.position);
    }
    private void Update()
    {
        try
        {
            CutRope();
        }
        catch { }
    }
    void CutRope()
    {
        RaycastHit2D hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
        //foreach (GameObject go in squares)
        //{
        if (Input.GetButtonDown("Fire1") && hit.collider.gameObject == GameObject.Find("Left"))
        {
            left.enabled = false;
        }
        if (Input.GetButtonDown("Fire1") && hit.collider.gameObject == GameObject.Find("Right"))
        {
            right.enabled = false;
        }


        //}
        //Debug.Log(hit.collider.name);
    }
}
