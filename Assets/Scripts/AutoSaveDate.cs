using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSaveDate
{
    public int level = -1;
    public string location = "시작의 마을";

    public AutoSaveDate(){
        
    }

    public AutoSaveDate(int level, string location){
        this.level = level;
        this.location = location;
    }
}
