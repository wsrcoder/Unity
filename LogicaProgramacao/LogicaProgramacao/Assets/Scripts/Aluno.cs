using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student
{
    public string studentName;
    public int studentAge;

    private bool isApproved;

    public float bimontlyMediaA;
    public float bimontlyMediaB;
    public float bimontlyMediaC;
    public float bimontlyMediaD;

    private float finalMedia;

    public float getFinalMedia()
    {
        return finalMedia;
    }

    public string studentResult()
    {
        isApproved = finalMedia >= 60 ? true : false;
        return isApproved ? "APROVADO":"REPROVADO";
    }

    public float calculateFinalMedia()
    {
        finalMedia = (bimontlyMediaA + bimontlyMediaB + bimontlyMediaC + bimontlyMediaD) / 4;

        return finalMedia;
    }


}
