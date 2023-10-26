public class InicializadorBD {
public static void Inicializar(ContextoDatos contexto) {
if(contexto.Articulos.Any()) {

return;

}
var articulos = new Articulo[] {
    new Articulo { Descripcion = "Martillo", FechaAlta = DateTime.Now, Cantidad = 10, Precio = 66.50, UdeMedida = "Pieza" },
    new Articulo { Descripcion = "Clavos 1/2", FechaAlta = DateTime.Now, Cantidad = 200, Precio = 5.75, UdeMedida = "Kilo" },
    new Articulo { Descripcion = "Tornillos", FechaAlta = DateTime.Now, Cantidad = 15, Precio = 3.00, UdeMedida = "Kilo" },
    new Articulo { Descripcion = "Llave Nariz", FechaAlta = DateTime.Now, Cantidad = 5, Precio = 63.40, UdeMedida = "Pieza" },
    new Articulo { Descripcion = "Codos", FechaAlta = DateTime.Now, Cantidad = 2, Precio = 56.00, UdeMedida = "Caja" }
};
contexto.Articulos.AddRange(articulos);
contexto.SaveChanges();
}
}
