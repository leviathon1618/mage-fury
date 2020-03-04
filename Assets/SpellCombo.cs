using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCombo : MonoBehaviour
{
    
    public Dropdown element;
    public Dropdown spell_path;
    public Slider range;
    public Slider width;
    public Slider damage;
    public Toggle explosion;
    public Slider expl_dmg;
    public Slider expl_range;
    


    private int element_item;
    private string element_choice;

    private int spell_item;
    private string traj_choice;

    private float range_val;
    private float width_val;
    private float damage_val;
    private bool explosion_state;
    private float expl_dmg_val;
    private float expl_range_val;

    private string spell_features;

    


    public List<string> spell_properties = new List<string>();
    private void Awake()
    {
        //spell_properties.Add("empty");
    }
    // Start is called before the first frame update
    void Start()
    {
        
        //print(spell_properties[0]);
    }

    public void spellGenerator()
    {
        spell_features = element_choice+
            " "+ traj_choice+
            " "+range_val.ToString()+
            " "+width_val.ToString()+
            " "+damage_val.ToString()+
            " "+explosion_state.ToString()+
            " "+expl_dmg_val.ToString()+
            " "+ expl_range_val.ToString() ;
        
        spell_properties.Add(spell_features);
        
    }

    // Update is called once per frame
    void Update()
    {
        element_item = element.value;
        element_choice = element.options[element_item].text;

        spell_item = spell_path.value;
        traj_choice = spell_path.options[spell_item].text;

        range_val = range.value;
        width_val = width.value;
        damage_val = damage.value;
        if (explosion.isOn == true)
        {
            explosion_state = true;
        }
        else
        {
            explosion_state = false;
        }
        expl_dmg_val = expl_dmg.value;
        expl_range_val = expl_range.value;

        

        

        
        
    }
}
