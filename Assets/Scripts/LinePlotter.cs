using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LinePlotter : MonoBehaviour
{
    private List<Vector3> points;

    public float x1 = 0f;

    public float y1 = 0f;

    public float m = 1f;

    public float c = 0f;

    private float CalculateY( float y1, float x, float x1, float m, float c)
    {
        return m * (x - x1) + c + y1;
    }

    private void OnDrawGizmos()
    {
        if (points != null)
        {
            //Set the colour of the Gizmo
            Gizmos.color = Color.red;

            //For each point in the list, draw a line from it to the next point in the list.
            for(int i = 0; i < points.Count-1; ++i)
            {
                Gizmos.DrawLine(points[i], points[i + 1]);
            }
        }
    }

    public float x = 0f;

    //public float m = 1f;

    //public float c = 0f;


    //private float CalculateY (float x, float m, float c)
    //{
    //    return m * x + c;
    //}

    


    void Start()
    {
        //points = new List<Vector3>();

        //float xPos = x;

        ////Create a number of points to go onto the line
        //for (uint i = 0; i < 30; i++)
        //{
        //    points.Add(new Vector3(xPos, CalculateY(xPos, m, c), 0f));
        //    xPos += 0.2f;
        //}

        points = new List<Vector3>();
        float x = -10f;

        for (float xPos = x; xPos < 50f; xPos += 0.2f)
        {
            points.Add(new Vector3(xPos, CalculateY(y1, xPos, x1, m, c), 0f));
        }


    }

    private void OnValidate()
    //{
    //    points.Clear();
    //    float xPos = x;
    //    for (uint i = 0; i < 30; i++)
    //    {
    //        points.Add(new Vector3(xPos, CalculateY(xPos, m, c), 0f));
    //        xPos += 0.2f;
    //    }
    //    Debug.Log("Repopulating gizmo positions");
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
