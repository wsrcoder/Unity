using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Fundamentos : MonoBehaviour

{


    //classe pura
    private Student aluno = new Student();




    // Start is called before the first frame update
    void Start()
    {
        aluno.studentName = "Wellington";
        aluno.studentAge = 36;

       



    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            aluno.bimontlyMediaA = Random.Range(0, 100);
            aluno.bimontlyMediaB = Random.Range(0, 100);
            aluno.bimontlyMediaC = Random.Range(0, 100);
            aluno.bimontlyMediaD= Random.Range(0, 100);

            aluno.calculateFinalMedia();
            print(aluno.studentName);
            print(aluno.getFinalMedia());

            print($"Resultado: {aluno.studentResult()}");
        }
    }
}
