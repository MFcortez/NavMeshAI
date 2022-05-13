using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    //Array de agentes (guarda o gameobject dos agentes)
    GameObject[] agents;

    //Ao iniciar a aplicacao com o script ativo na cena
    void Start()
    {
        //Adiciona dentro do array todos os gameobjects com a tag "ai"
        agents = GameObject.FindGameObjectsWithTag("ai");
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//true se jogador clicar
        {
            //Variável para receber valor do raycast
            RaycastHit hit;
            //Cria raycast q tem como origem a camera e fim a posicao do mouse
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000))
            {
                foreach (GameObject a in agents)//Para cada Gameobject dentro de agents execute...
                {
                    //A partir do NavMeshAgent dentro do objeto a, coloca como destino de movimento o ponto de clique do mouse
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
                }
            }
        }
    }
}
