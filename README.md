# TextBoxUniversal y EntitySelectorCombo

TextBox y ComboBox personalizados para mejorar la productividad de desarrolladores de escritorio(Windows Forms) que trabajen con la plataforma Visual Studio.  

## Modo de uso
Para poder usar los controles hay que agregar la dll que viene en la carpeta Libreria de nombre GlobalTech.TextBoxControl.dll
En el proyecto que esten trabajando pueden crear una carpeta de nombre Libreria a nivel de solucion .sln  y dentro de ella agregar la dll en mención(GlobalTech.TextBoxControl.dll) y podrían agregar desde allí la dll.
Una vez hecho eso deben agregar esa dll como referencia al proyecto de interfaz de usuario que en este caso es un proyecto Windows Forms.
Para poder disponer de los controles y hacer uso de ellos se debe agregar una nueva pestaña al ToolBox poniendo el nombre que ustedes deseen y luego hacer click derecho en la nueva pestaña creada y seleccionar Elegir elementos y escoger la ruta donde se encuentre la dll y de esa manera pueden agregar los nuevos controles TextBoxUniversal y EntitySelectorCombo para su uso.


## 1. TextBox
La caracteristica del TextBoxUniversal es que se le agrego una propiedad que se llama TipoControl en la cual pueden escoger las siguientes elecciones como: Enteros, Letras, Numeric, NumeroDecimales, WaterMarkText

<span style="background-color: #BCE8F1;">ENTEROS:</span> Permite ingresar solo números, no va a permitir ingresar otro caracter que no sea números.  

<span style="background-color: #BCE8F1;">LETRAS:</span> Permite ingresar solo letras.  

<span style="background-color: #BCE8F1;">NUMERIC:</span> Permite ingresar solo números y al pasar al siguiene control le agrega los decimales, el cual se puede manejar la cantidad de decimales con una propiedad que se le agrego al control de nombre NumeroDecimales en el cual usted ingresa la cantidad de decimales que desee agregar.  

<span style="background-color: #BCE8F1;">NUMEROS DECIMALES:</span> Permite ingresar la cantidad de decimales que desee agregar.  

<span style="background-color: #BCE8F1;">WATERMARKTEXT:</span> Permite ingresar una marca de agua en la cual usted puede indicar al usuario como por ejemplo un mensaje que diga ingrese nuevo registro, el cual desaparecera al ingresar algún caracter.  

## 2. ComboBox
La caracteristica del EntitySelectorCombo tiene la particularidad de cargarlo tan solo con pasarle el DataSource.
Pero para esto se tienen que cumplir ciertas convenciones, como:
1) Las entidades de negocio se deben llamar como por ejemplo: Categoria, Persona, Proveedor, etc sin ningún diminutivo como CategoriaEntity.

2) La propiedad que hace de primary key se puede llamar solamente Id, nombre de entidad + Id como por ejemplo CategoriaId, PersonaId. O también nombre de entidad + _Id como por ejemplo Categoria_Id, Personal_Id

```
    	private void Form1_Load(object sender, EventArgs e)
        {
            // De esta manera simple y rápida se puede cargar un ComboBox.
            cboCategoria.DataSource = CategoriaRepository.ListarCategoria();
        }
```

Reseña [TextBox personalizado](https://pedroavilanu.wordpress.com/2017/07/30/textbox-personalizado-textboxuniversal/)



