
# ASP.NET Pokedex

## Descripción

Podemos ver un listado de los pokémones existentes. Permite realizar búsquedas en vivo con Ajax, seleccionar un pokémon y acceder a una página con sus estadísticas y tipo.

## Caracteristicas

- Búsqueda en vivo con Ajax de pokémones.

- Visualización de estadísticas e información del pokémon seleccionado.

- Listado inicial con los primeros 20 pokémones ordenados por su ID.

- Diseño moderno y responsivo con Bootstrap.
## Tecnologías Utilizadas

- ASP.NET 9

- PokeApi

- Microsoft.AspNetCore.Components.WebAssembly

- Microsoft.AspNetCore.WebAssembly.DevServer

- Microsoft.NET.ILLink.Tasks

- Microsoft.NET.Sdk.WebAssembly.Pack

- Bootstrap
## Instalación y Configuración

- Clonar el repositorio:

`git clone https://github.com/tuusuario/tu-repo.git
cd tu-repo`

- Restaurar paquetes NuGet:

`dotnet restore`

- Ejecutar la aplicación:

`dotnet run`

Acceder a la aplicación en http://localhost:5000.
## Uso

1) Al ingresar al home, se muestra un listado de los primeros 20 pokémones ordenados por ID.

2) Se puede hacer clic en cualquier pokémon para ver sus estadísticas y características.

3) En la página de detalles, se muestra el tipo y los stats del pokémon seleccionado.

4) Si no se encuentra el pokémon en la lista, se puede escribir su nombre en la barra de búsqueda y aparecerá.

5) Desde la página de detalles, hay un botón para volver al home.
## Licencia

Este proyecto está licenciado bajo la MIT License. Ver el archivo `LICENSE` para más detalles.
