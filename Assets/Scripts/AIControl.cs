using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIControl : MonoBehaviour
{
    //Aloca o NavMeshAgent do objeto
    public NavMeshAgent agent;

    //Ao iniciar a aplicacao com o script ativo na cena
    void Start()
    {
        //Pega o NavMeshAgent do presente no objeto
        agent = GetComponent<NavMeshAgent>();
    }
}
