using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float mouseSensitivity = 500f;
    public float xRotation = 0f;
    public float yRotation = 0f;

    public float topClamp = -90f;
    public float bottomClamp = 90f;
    // Start is called before the first frame update
    void Start()
    {
        // Trava cursor no centro da tela e esconde ele
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Inputs do mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotação do jogador no eixo X (Olhar pra baixo e pra cima)
        xRotation -= mouseY;

        // Limitar a rotação para não virar o jogador de cabeça pra baixo
        xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);

        // Rotação do jogador no eixo Y (Olhar para os lados)
        yRotation += mouseX;
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
