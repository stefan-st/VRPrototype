using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathVisualizer : MonoBehaviour
{
    public Color lineColor;

    private List<Transform> nodes = new List<Transform>();

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = lineColor;

        Transform[] pathTransforms = GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; ++i)
        {
            if (pathTransforms[i] != transform)
            {
                nodes.Add(pathTransforms[i]);
            }
        }

        for (int i = 1; i < nodes.Count; ++i)
        {
            Vector3 currNode = nodes[i].position;
            Vector3 prevNode = nodes[i - i].position;

            Gizmos.DrawLine(currNode, prevNode);
            Gizmos.DrawWireSphere(currNode, 0.3f);
        }
    }
}
