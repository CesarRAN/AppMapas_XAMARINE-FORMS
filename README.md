
# Aplicación de Mapas con Xamarine.Forms


<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">Acerca del proyecto</a>
    </li>
    <li>
      <a href="#about-the-project">Implementación</a>
    </li>
    <li>
      <a href="#getting-started">Funcionamiento</a>
      <ul>
        <li><a href="#prerequisites">Almacenamiento de las notas</a></li>
      </ul>
    </li>
  </ol>
</details>

## Acerca del Proyecto 
---
La aplicación consiste en una implementación básica de Xamarin.Forms y la API de Xamarin.Essentials para móvil, la aplicación permite navegar entre diferentes vistas, buscar una ubicación con sus coordenadas, guardar, almacenar, modificar y eliminar ubicaciones
## Implementación
---
1.- Crear un proyecto tipo "Aplicación móvil (Xamarin.Forms)" en visual studio usando la p´lantilla con pestañas para navegar entre secciones

![alt text](https://github.com/CesarRAN/AppMapas_XAMARINE-FORMS/blob/main/assets/t1.jpg)

2.- Remplazar los archivos de la Carpeta App por los del proyecto 

![alt text](https://github.com/CesarRAN/AppMapas_XAMARINE-FORMS/blob/main/assets/t2.jpg)

## Funcionamiento

Se tiene un menu para navegar en la aplicacion 

![alt text](https://github.com/CesarRAN/AppMapas_XAMARINE-FORMS/blob/main/assets/1.jpg)

La aplicacion permite ingresar las cordenadas de una ubicacion y buscarla en google maps usando la API Xamarin.Essentials


![alt text](https://github.com/CesarRAN/AppMapas_XAMARINE-FORMS/blob/main/assets/2.jpg)

Tambien se pueden guardar ubicaciones


![alt text](https://github.com/CesarRAN/AppMapas_XAMARINE-FORMS/blob/main/assets/3.jpg)

Ademas es posible modificar las ubicacionmes guardadas o eliminarlas 


![alt text](https://github.com/CesarRAN/AppMapas_XAMARINE-FORMS/blob/main/assets/4.jpg)

### Almacenamiento de las notas
---
Cuando se guarda una ubicación se crea un archivo de texto plano en donde se guardan los datos, para recuperar la información un objeto de la clase "Locate.cs" recupera el nombre del archivo y los datos, de la misma forma, cuando se modifica la ubicación el archivo se sobrescribe, de esta forma, las ubicaciones permanecen aun si se cierra la aplicación   
