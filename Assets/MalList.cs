//The list form that appears in the UI
//Created by James Vanderhyde, 8 October 2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mal;

public class MalList : MalForm
{
    public override types.MalVal read_form()
    {
        Transform contents = transform.GetChild(1);

        types.MalList ml = new types.MalList();
        for (int i=0; i<contents.childCount; i++)
        {
            MalForm child = contents.GetChild(i).GetComponent<MalForm>();
            types.MalVal value = child.read_form();
            ml.cons(value);
        }
        return ml;
    }
}
