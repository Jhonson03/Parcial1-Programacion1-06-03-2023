using Parcial1.Entidades;
using Parcial1.Negocio;

Usuario usuario = new Usuario();
ClsUsuario clsUsuario = new ClsUsuario();
Venta venta = new Venta();
ClsVentas clsVentas = new ClsVentas();

Console.WriteLine("Ingresa tu usuario");
usuario.usuario = Console.ReadLine();
Console.WriteLine("Ingresa tu password");
usuario.password = Console.ReadLine();

bool Resultado = clsUsuario.Autenticacion(usuario);
if (Resultado == true)
{
    Console.WriteLine("Bienvenido su tienda online");
    Console.Write("\nIngrese el identificador del producto -> ");
    venta.IdProducto = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nIngrese el nombre del producto -> ");
    venta.NomProducto = Console.ReadLine();
    Console.WriteLine("\nIngrese una breve descripcion del producto -> ");
    venta.DescripProducto = Console.ReadLine();
    Console.WriteLine("\nIngrese el precio del producto -> ");
    venta.PreProducto = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nIngrese la cantidad del producto que lleva -> ");
    venta.CantidadProducto = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($@"El ID del producto es: {venta.IdProducto}
El producto que lleva es: {venta.NomProducto}
El precio del producto es: {venta.PreProducto}
El precio si aplica descuento es: {venta.NuevoDescue}
El total a pagar es: {clsVentas.Cobro(venta)}");
}
else
{
    Console.WriteLine("Your password is incorret");
}