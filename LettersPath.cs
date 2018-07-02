using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LettersPath : MonoBehaviour {
    public List<Transform> musicPath;
    private int pathIndex;
    public float moveSpeed = 15;

    void Update()
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("position", musicPath[pathIndex].position,
            "speed", moveSpeed, "easetype", "linear", "oncomplete", "DrawLetter"));

    }

    void DrawLetter()
    {
        if (pathIndex != musicPath.Count - 1)
        {
            pathIndex++;
        }
    }
}
