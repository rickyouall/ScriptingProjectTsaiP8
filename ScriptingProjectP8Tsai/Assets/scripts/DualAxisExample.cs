using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine;
public class DualAxisExample : MonoBehaviour
{

    public float hRange;
    public float vRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        float xPos = h * hRange;
        float yPos = v * vRange;

        transform.position = new Vector3(xPos,yPos, 0);
        Debug.Log (h.ToString("F2"));
        Debug.Log (v.ToString("F2"));
    }
}