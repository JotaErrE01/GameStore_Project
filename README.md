<div align=center>
  <h1>Dragon Games Project</h1>
  <img src="https://user-images.githubusercontent.com/68200856/133003771-8aae1088-6c78-419f-a81f-3d11f3e139a2.png" />
</div>

<p>Para que el sistema logre funcionar de una manera correcta debera seguir los siguientes pasos:</p>

<p>1. Debera tener registrada la base de datos de DigitalGames que se encuentra en el Script.</p>

<p>2. Debera configurar el string de conexion que se encuentra en el  archivo SqlConfig.cs en el paquete Data.</p>

```
connectionString = 
"Data Source=<YOUR_DESKTOP>\\SQLEXPRESS; Initial Catalog=DigitalGames; Integrated Security=True";
```

<p>3. Al momento de generar el PDF este se generara en la carpeta donde se encuentra la solucion del proyecto.</p>

<p>4. Para que el filtrado funcione, debera ingresar los 2 campos de manera obligatoria y estos deberan coincidir con los datos que esten registrados en la base de datos.</p>

<p>5. En el caso de las opciones de registrar y actualizar, los campos de cedula cliente, cedula vendedor y codigo de juego deberan estar registrados en la base de datos para ser registrados o actualizados.</p>

<p>6. El boton de Generar PDF se encontrara activo siempre y este generar los datos que esten en la tabla, si realizaa un filtrado, entonces los datos seran los del filtro.</p>

<p>7. La fecha inicial por default es el mismo dia del registro o la actualizacion, en el caso de la fecha filnal, esta solo se podra editar si la opcion de pago es credito.</p>
