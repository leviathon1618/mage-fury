using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCombo : MonoBehaviour
{
    public Dropdown element;
    public Dropdown trajectory;
    public Slider distance;
    public Text output;
    private float dist_val;

    private int traj_item;
    private string traj_choice;

    private int element_item;
    private string element_choice;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        output.text = "element: " + element_choice + " distance: " + dist_val.ToString() + " trajectory: " +  traj_choice;
        dist_val = distance.value;

        element_item = element.value;
        element_choice = element.options[element_item].text;

        traj_item = trajectory.value;
        traj_choice = trajectory.options[traj_item].text;
        
    }
}
