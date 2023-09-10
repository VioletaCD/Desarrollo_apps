// Control de empleados
// Instanciar y reservar espacio en memoria
Empleado empleado01 = new Empleado();
// Instanciar, luego reservar espacio en memoria
Empleado empleado02;
empleado02 = new Empleado();
// Asignar valores a los datos a través de las propiedades
empleado01.Nombre = "Juan";
empleado01.Edad = 22;
empleado02.Nombre = "Jose";
empleado02.Edad = 35;
// Invocar los métdos
empleado01.ImprimirDatos();
empleado02.ImprimirDatos();

// Crear tres nuevos empledos usando los constructores
Empleado empleado03 = new Empleado();
Empleado empleado04 = new Empleado("María");
Empleado empleado05 = new Empleado("Rocio",45);
empleado03.ImprimirDatos();
empleado04.ImprimirDatos();
empleado05.ImprimirDatos();
