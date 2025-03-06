using System.Collections;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;


public class AxisExample : MonoBehaviour
{

    public float range;
    public Text textOutput;
    // Start is called before the first frame update
    void Start()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");
    }
} 