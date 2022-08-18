using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EdgeCollider2D))]
public class TrailCollisions : MonoBehaviour
{

    EdgeCollider2D edgeCollider;
    LineRenderer myLine;
    // Start is called before the first frame update
    void Start()
    {
        edgeCollider = this.GetComponent<EdgeCollider2D>();
        myLine = this.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        SetEdgeCollider(myLine);
    }

    void SetEdgeCollider(LineRenderer lineRenderer)
    {
        Transform lineTransform = lineRenderer.transform;
        Debug.Log(lineTransform);
        List<Vector2> edges = new List<Vector2>();

        for (int point = 0; point < lineRenderer.positionCount; point++)
        {
            Vector3 lineRendererPoint = lineRenderer.GetPosition(point);
            edges.Add(new Vector3(lineRendererPoint.x + lineTransform.localPosition.x, lineRendererPoint.y + lineTransform.localPosition.y, lineRendererPoint.z + lineTransform.localPosition.z));
        }

        edgeCollider.SetPoints(edges);
    }    
}
