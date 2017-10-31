using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BibliotecaMensajesController : MonoBehaviour {

	public static string[] bibliotecaMensajes;

	void Start()
	{
		BibliotecaMensajesController.bibliotecaMensajes = new string[4];
		llenarArray();

	}

    private void llenarArray()
    {
		BibliotecaMensajesController.bibliotecaMensajes[0]= "Hola";
		BibliotecaMensajesController.bibliotecaMensajes[1]= "Chao";
		BibliotecaMensajesController.bibliotecaMensajes[3]= "Bien Hecho";
		BibliotecaMensajesController.bibliotecaMensajes[4]= "Mal Hecho";     
    }
}
