using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell_applier : MonoBehaviour
{
    public SpellCombo spell_list;
    public Material[] element = new Material[4];
    Renderer m_ObjectRenderer;
    public Transform orb;
    public string long_string;
    public string[] words;
    public Vector3 scale;
    private int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        m_ObjectRenderer = GetComponent<Renderer>();
    }

    public void item_seperator()
    {
        
        long_string = spell_list.spell_properties[count];
        words = long_string.Split(' ');

        
        //print(spell_list.spell_properties[0]);
        foreach (var word in words)
        {
            print($"<{word}>");

            if (words[0] == "fire")
            {
                m_ObjectRenderer.material = element[0];
            }
            if (words[0] == "water")
            {
                m_ObjectRenderer.material = element[1];
            }
            if (words[0] == "air")
            {
                m_ObjectRenderer.material = element[2];
            }
            if (words[0] == "earth")
            {
                m_ObjectRenderer.material = element[3];
            }
            scale = new Vector3(float.Parse(words[3]), float.Parse(words[3]), float.Parse(words[3]));
            orb.localScale = scale;
        }

        count += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
