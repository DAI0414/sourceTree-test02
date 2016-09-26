using UnityEngine;
using System.Collections;

public class Move2 : MonoBehaviour {

    [Range(1, 10)]
    public float angle = 0f;
    [Range(0, 10)]
    public float range = 4f;
    [Range(0.01f, 1f)]
    public float yspeed = 0.05f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.gameObject.transform.localPosition;
        this.gameObject.transform.localPosition = new Vector3(pos.x, Mathf.Cos(angle) * range, pos.z);
        angle += yspeed;
    }
}
